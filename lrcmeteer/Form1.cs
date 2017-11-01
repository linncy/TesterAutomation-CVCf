using System;
using System.Windows.Forms;
using System.Data;
using Ivi.Visa;
using Ivi.Visa.FormattedIO;
using LogRecord;

namespace lrcmeteer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

       // private DataTable dt = new DataTable();          
 
        //change widget state
        private void widgetStateChange(RunState type)
        {
            bool state;
            if (type==RunState.running)
            {
                state = true;
            }
            else
            {
                state = false;
            }
            txtCVStartVoltage.Enabled = !state;
            txtCVStopVoltage.Enabled = !state;
            txtCVStepVoltage.Enabled = !state;
            txtCVACfrequency.Enabled = !state;
            txtCVOscVoltage.Enabled = !state;
            txtCVSweepRate.Enabled = !state;
            txtCVArea.Enabled = !state;
            txtCVPermittivity.Enabled = !state;
            btnCVstart.Enabled = !state;
            btnCVstop.Enabled = state;

            txtGMeasVoltage.Enabled = !state;
            txtGOscVoltage.Enabled = !state;
            txtGArea.Enabled = !state;
            txtGTemper.Enabled = !state;
            txtGkusai.Enabled = !state;
            txtGBuiltIn.Enabled = !state;
            txtGDepLayer.Enabled = !state;
            txtGGAcomp.Enabled = !state;
            txtGBGE.Enabled = !state;
            btnGstart.Enabled = !state;
            btnGstop.Enabled = state;
        }


        //mark run type
        public enum RunState
        {
            running,
            stop
        }

        int i = 0;
        RunState state = RunState.stop;

        //get data save data and plot data
        LogClass logfile = new LogClass();
        private void RunCV(object sender, EventArgs e)
        {
            tmrCV.Enabled = false;
            double[] data = { };
            double[] plotx = { };
            double[] ploty = { };
            string CommBias;
            string[] FetchResult;
            double startvoltage, stepvoltage, stopvoltage, idnResponseBiasV;
            startvoltage = Convert.ToDouble(txtCVStartVoltage.Text);
            stepvoltage = Convert.ToDouble(txtCVStepVoltage.Text);
            stopvoltage = Convert.ToDouble(txtCVStopVoltage.Text);

            //change bias voltage & draw the figure
            if (state==RunState.running)
            {
                if (startvoltage + stepvoltage * i <= stopvoltage)
                {
                    //change bias voltage
                    CommBias = "BIAS:VOLT " + Convert.ToString(startvoltage + i * stepvoltage) + "V";
                    formattedIO.WriteLine(CommBias);
                    formattedIO.WriteLine("BIAS:VOLT?");
                    idnResponseBiasV = Convert.ToDouble(formattedIO.ReadLine());
                    Shell.WriteLine("[Send]Send Command is {0}", CommBias);
                    Shell.WriteLine("[Receive]BIAS Voltage is {0}V", idnResponseBiasV);

                    //get the data
                    FetchResult = sendCommand("Fetch?");
                    logfile.WriteLogFile(Convert.ToString(startvoltage + i * stepvoltage) + "," + FetchResult[0]);

                    //deal the data

                    //plotx[i] = startvoltage + i * stepvoltage;
                    //ploty[i] = Convert.ToDouble(FetchResult[0]);
                    //Shell.WriteLine("[Output Data]{0},{1}", plotx[i], ploty[i]);
                    i++;
                    tmrCV.Enabled = true;
                }
                else
                {
                    i = 0;
                    tmrCV.Enabled = false;
                    state = RunState.stop;
                    widgetStateChange(state);
                    sendCommand("BIAS:STAT 0");
                    session.Dispose();
                }

            }
        }




        // GPIB instruments on the GPIB0 interface
        // Change this variable to the address of your instrument
        string VISA_ADDRESS = "GPIB0::25::INSTR";

        // Create a connection (session) to the instrument
        IMessageBasedSession session;

        // Create a formatted I/O object which will help us format the data we want to send/receive to/from the instrument
        MessageBasedFormattedIO formattedIO;

        //integration time select
        private string Inter()
        {
            string result = "";
            if (rbInterShort.Checked == true)
            {
                result = "SHOR,";
            }
            else if (rbInterMedium.Checked == true)
            {
                result = "MED,";
            }
            else if (rbInterLong.Checked == true)
            {
                result = "LONG,";
            }
            return result;
        }

        private void openGPIB()
        {
            try
            {
                session = GlobalResourceManager.Open(VISA_ADDRESS,AccessModes.None,50000) as IMessageBasedSession;
                formattedIO = new MessageBasedFormattedIO(session);
            }
            catch (NativeVisaException visaException)
            {
                Shell.WriteLine("Error is:\r\n{0}\r\nPress any key to exit...", visaException);
                MessageBox.Show("Please check GPIB conncetion. GPIB port of the instrument should be set as GPIB0::25", "Connection Error");
                return;
            }
        }

        //command send and read the response
        private string[] sendCommand(string comm)
        {
            string Comm;
            string idnResponse;
            double volt, order, freq;
            string[] normalreturn = {DateTime.Now.ToString(), ":success" };
            try
            {
                switch (comm)
                {
                    case "APER":
                        Comm = comm + " " + Inter() + txtAveRate.Text;
                        formattedIO.WriteLine(Comm);
                        formattedIO.WriteLine("APER?");
                        idnResponse = formattedIO.ReadLine().Replace("\n", "");
                        string[] idnResponseAper = idnResponse.Split(new string[] { "," }, StringSplitOptions.None);
                        Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        Shell.WriteLine("[Receive]APERture setting is {0} integration time, Averaging rate is {1}", idnResponseAper[0], Convert.ToDouble(idnResponseAper[1]));
                        return normalreturn; 
                    case "Volt":
                        Comm = comm + " " + txtCVOscVoltage.Text + "mV";
                        formattedIO.WriteLine(Comm);
                        formattedIO.WriteLine("VOLT?");
                        idnResponse = formattedIO.ReadLine().Replace("\n", "");
                        string[] idnResponseVolt = idnResponse.Split(new string[] { "E" }, StringSplitOptions.None);
                        volt = Convert.ToDouble(idnResponseVolt[0]);
                        order = Convert.ToDouble(idnResponseVolt[1]);
                        Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        if (order >= 0)
                        {
                            Shell.WriteLine("[Receive]Volt setting is {0} V", volt);
                        }
                        else
                        {
                            volt = volt * Math.Pow(10, order + 3);
                            Shell.WriteLine("[Receive]Volt setting is {0} mV", volt);
                        }
                        return normalreturn;
                    case "Freq":
                        Comm = comm + " " + txtCVACfrequency.Text + "KHz";
                        formattedIO.WriteLine(Comm);
                        formattedIO.WriteLine("Freq?");
                        idnResponse = formattedIO.ReadLine().Replace("\n", "");
                        string[] idnResponseFreq = idnResponse.Split(new string[] { "E" }, StringSplitOptions.None);
                        freq = Convert.ToDouble(idnResponseFreq[0]);
                        order = Convert.ToDouble(idnResponseFreq[1]);
                        Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        if (order >= 0 && order <= 5)
                        {
                            freq = freq * Math.Pow(10, order - 3);
                            Shell.WriteLine("[Receive]Frequency setting is {0} KHz", freq);
                        }
                        else
                        {
                            Shell.WriteLine("[Receive]Frequency setting is {0} MHz", freq);
                        }
                        return normalreturn;
                    case "Func:IMP CPG":
                        Comm = comm;
                        formattedIO.WriteLine(Comm);
                        formattedIO.WriteLine("Func:IMP?");
                        idnResponse = formattedIO.ReadLine().Replace("\n", "");
                        Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        Shell.WriteLine("[Receive]Function setting is {0}", idnResponse);
                        return normalreturn;
                    case "Func:IMP CSRS":
                        Comm = comm;
                        formattedIO.WriteLine(Comm);
                        formattedIO.WriteLine("Func:IMP?");
                        idnResponse = formattedIO.ReadLine().Replace("\n", "");
                        Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        Shell.WriteLine("[Receive]Function setting is {0}", idnResponse);
                        return normalreturn;
                    case "BIAS:STAT 1":
                        Comm = comm;
                        formattedIO.WriteLine(Comm);
                        formattedIO.WriteLine("BIAS:STAT?");
                        idnResponse = formattedIO.ReadLine().Replace("\n", "");
                        Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        Shell.WriteLine("[Receive]BIAS is {0}", (idnResponse == "0") ? "OFF" : "ON");
                        return normalreturn;
                    case "BIAS:STAT 0":
                        Comm = comm;
                        formattedIO.WriteLine(Comm);
                        formattedIO.WriteLine("BIAS:STAT?");
                        idnResponse = formattedIO.ReadLine().Replace("\n", "");
                        Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        Shell.WriteLine("[Receive]BIAS is {0}", (idnResponse == "0") ? "OFF" : "ON");
                        return normalreturn;
                    case "Fetch?":
                        string[] idnResponseFetch;
                        Comm = comm;
                        formattedIO.WriteLine(Comm);
                        idnResponse = formattedIO.ReadLine().Replace("\n", "");
                        idnResponseFetch = idnResponse.Split(new string[] { "," }, StringSplitOptions.None);
                        Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        Shell.WriteLine("[Receive]Measured result is {0}", idnResponse);
                        return idnResponseFetch;
                }
            }
            catch (NativeVisaException visaException)
            {
                Shell.WriteLine("Error is:\r\n{0}\r\nPress any key to exit...", visaException);
                return null;
            }
            return null;
        }

        private void btnCVstart_Click(object sender, EventArgs e)
        {
            //OPEN GPIB & set parameter
            openGPIB();
            sendCommand("APER");
            sendCommand("Volt");
            sendCommand("Freq");
            if (rbParallel.Checked==true)
            {
                sendCommand("Func:IMP CPG");
            }
            else if (rbSeries.Checked==true)
            {
                sendCommand("Func:IMP CSRS");
            }
            //Initialize datagridview and insert comment row

            //start measure
            sendCommand("BIAS:STAT 1");
            tmrCV.Interval = Convert.ToInt32(txtCVSweepRate.Text);
            tmrCV.Tick += new EventHandler(RunCV);
            tmrCV.Enabled = true;
            state = RunState.running;
            widgetStateChange(state);
        }

        private void btnCVstop_Click(object sender, EventArgs e)
        {
            i = 0;
            tmrCV.Enabled = false;
            state = RunState.stop;
            widgetStateChange(state);
            sendCommand("BIAS:STAT 0");
            session.Dispose();
        }

        private void btnGstart_Click(object sender, EventArgs e)
        {

        }

        private void btnGstop_Click(object sender, EventArgs e)
        {
            i = 0;
            tmrCV.Enabled = false;
            state = RunState.stop;
            widgetStateChange(state);
            sendCommand("BIAS:STAT 0");
            session.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalBandGap_Click(object sender, EventArgs e)
        {
            double GaCom;
            GaCom = Convert.ToDouble(txtGGAcomp.Text);
            txtGBGE.Text = Convert.ToString(1+0.564*GaCom+0.116*GaCom*GaCom);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                session = GlobalResourceManager.Open(VISA_ADDRESS) as IMessageBasedSession;
                formattedIO = new MessageBasedFormattedIO(session);
            }
            catch (NativeVisaException visaException)
            {
                Shell.WriteLine("Error is:\r\n{0}\r\nPress any key to exit...", visaException);
                return;
            }

            // Send the *IDN? and read the response as strings
            formattedIO.WriteLine("*IDN?");
            Shell.WriteLine("[Send]Send Command is *IDN?");
            string idnResponse = formattedIO.ReadLine();
            Shell.WriteLine("[Receive]*IDN? returned: {0}", idnResponse);
            session.Dispose();
        }

        private void picboxCf_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtCVSweepRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCVOscVoltage_TextChanged(object sender, EventArgs e)
        {

        }

        private void picboxCV_Click(object sender, EventArgs e)
        {

        }

        private void txtSave_TextChanged(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void picboxC2V_Click(object sender, EventArgs e)
        {

        }

        private void tmrGf_Tick(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            openGPIB();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Voltage(V)" ,typeof(System.Int32));
            dt.Rows.Add(1);
            dgvData.DataSource = dt;
           // DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
           // c.DataPropertyName = "c";
            //c.HeaderText = "c";
           // c.Name = "ccolumn";
           // string[] row = { "a", "b", "c" };
            //dgvData.Columns.Add(c);
           // dgvData.Rows.Add(row);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dgvData.DataSource = dt;
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            string value = dgvData.Rows[0].Cells[0].Value.ToString();
            Shell.WriteLine(value);
        }
    }
}
