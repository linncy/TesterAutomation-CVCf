using System;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using Ivi.Visa;
using Ivi.Visa.FormattedIO;
using LogRecord;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace lrcmeteer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }
        // Initialize two datatable
        DataTable dtCV = new DataTable();
        DataTable dtCF = new DataTable();
        List<double> listCVx;
        List<double> listCVy;
        List<double> listCVy_2;
        List<double> listCfx;
        List<double> listCfx_2;
        List<double> listCfy;
        List<double> listCfy_2;
        Queue<double> doubleQ1;
        Queue<double> doubleQ2;

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

            txtCfMeasVoltage.Enabled = !state;
            txtCfOscVoltage.Enabled = !state;
            txtCfArea.Enabled = !state;
            txtStartLogf.Enabled = !state;
            txtStopLogf.Enabled = !state;
            txtStepLogf.Enabled = !state;
            btnCfStart.Enabled = !state;
            btnCfStop.Enabled = state;
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
      //  LogClass logfile = new LogClass();
        private void RunCV(object sender, EventArgs e)
        {
            tmrCV.Enabled = false;
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
                    //Shell.WriteLine("[Send]Send Command is {0}", CommBias);
                    //Shell.WriteLine("[Receive]BIAS Voltage is {0}V", idnResponseBiasV);

                    //get the data
                    System.Threading.Thread.Sleep(1);
                    FetchResult = sendCommand("Fetch?");
                    dtCV.Rows.Add((startvoltage + i * stepvoltage), Convert.ToDouble(FetchResult[0]));
                    listCVx.Add((startvoltage + i * stepvoltage));
                    listCVy.Add(Convert.ToDouble(FetchResult[0]));
                    listCVy_2.Add(1 / (Convert.ToDouble(FetchResult[0]) * Convert.ToDouble(FetchResult[0])));
                    plot(chartCV, "C-V",listCVx, listCVy);
                    plot(chartCV_2,"1/C²-V", listCVx, listCVy_2);
                    //    logfile.WriteLogFile(Convert.ToString(startvoltage + i * stepvoltage) + "," + FetchResult[0]);

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
                    caculateCV(dtCV,dgvData);
                    session.Dispose();
                }

            }
        }
        
        private void RunCf(object sender, EventArgs e)
        {
            tmrCf.Enabled = false;
            string CommFreq;
            string strFreq;
            string[] FetchResult;
            double StartLogf, StepLogf, StopLogf;
            StartLogf = Convert.ToDouble(txtStartLogf.Text);
            StepLogf = Convert.ToDouble(txtStepLogf.Text);
            StopLogf = Convert.ToDouble(txtStopLogf.Text);

            //change bias voltage & draw the figure
            if (state == RunState.running)
            {
                if (StartLogf + StepLogf * i <= StopLogf)
                {
                    //change frequency
                    strFreq = Math.Pow(10, StartLogf + StepLogf * i).ToString("f4");
                    CommFreq = "Freq" + " " + strFreq + "Hz";
                    formattedIO.WriteLine(CommFreq);
                    //Shell.WriteLine("[Send]Send Command is {0}", CommFreq);
                    //sendCommand("Freq");
                    //System.Threading.Thread.Sleep(1);
                    //formattedIO.WriteLine("Freq?");
                    //System.Threading.Thread.Sleep(1);
                    //idnResponse = formattedIO.ReadLine().Replace("\n", "");
                    //string[] idnResponseFreq = idnResponse.Split(new string[] { "E" }, StringSplitOptions.None);
                    //freq = Convert.ToDouble(idnResponseFreq[0]);
                    //order = Convert.ToDouble(idnResponseFreq[1]);
                    //if (order >= 0 && order <= 5)
                    //{
                    //    freq = freq * Math.Pow(10, order - 3);
                    //    //Shell.WriteLine("[Receive]Frequency setting is {0} KHz", freq);
                    //}
                    //else
                    //{
                    //    //Shell.WriteLine("[Receive]Frequency setting is {0} MHz", freq);
                    //}
                    System.Threading.Thread.Sleep(1);
                    ////get the data
                    if (StartLogf + StepLogf * i<=2)
                    {
                        FetchResult = sendCommand("Fetch?[Special]");
                    }
                    else
                    {
                        FetchResult = sendCommand("Fetch?[Special2]");
                    }
                    dtCF.Rows.Add(Math.Pow(10, StartLogf + StepLogf * i), StartLogf + StepLogf * i,Math.Log(2*Math.PI* Math.Pow(10, StartLogf + StepLogf * i)), Convert.ToDouble(FetchResult[0]), Convert.ToDouble(FetchResult[1]));
                    listCfx.Add(StartLogf + StepLogf * i);
                    listCfy.Add(Convert.ToDouble(FetchResult[0]));
                    plot(chartCf, "C-log(f)", listCfx, listCfy);
                    if(listCfx.Count>=2)
                    {
                        listCfx_2.Add(listCfx[i - 1]);
                        listCfy_2.Add((listCfy[i] - listCfy[i - 1]) / (listCfx[i] - listCfx[i - 1]));
                    }
                    plot(chartCf_2, "dC-dlog(f)", listCfx_2, listCfy_2);
                    i++;
                    tmrCf.Enabled = true;
                }
                else
                {
                    i = 0;
                    tmrCf.Enabled = false;
                    state = RunState.stop;
                    widgetStateChange(state);
                    sendCommand("BIAS:STAT 0");
                    caculateCf(dtCF, dgvData);
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

        private bool openGPIB()
        {
            try
            {
                session = GlobalResourceManager.Open(VISA_ADDRESS,AccessModes.None,50000) as IMessageBasedSession;
                formattedIO = new MessageBasedFormattedIO(session);
                MessageBox.Show("The instrument has been successfully connected on GPIB0::25", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (NativeVisaException visaException)
            {
                //Shell.WriteLine("Error is:\r\n{0}\r\nPress any key to exit...", visaException);
                MessageBox.Show("Please check GPIB conncetion. GPIB port of the instrument should be set as GPIB0::25", "Error: Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
                        //Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        //Shell.WriteLine("[Receive]APERture setting is {0} integration time, Averaging rate is {1}", idnResponseAper[0], Convert.ToDouble(idnResponseAper[1]));
                        return normalreturn; 
                    case "Volt":
                        Comm = comm + " " + txtCVOscVoltage.Text + "mV";
                        formattedIO.WriteLine(Comm);
                        formattedIO.WriteLine("VOLT?");
                        idnResponse = formattedIO.ReadLine().Replace("\n", "");
                        string[] idnResponseVolt = idnResponse.Split(new string[] { "E" }, StringSplitOptions.None);
                        volt = Convert.ToDouble(idnResponseVolt[0]);
                        order = Convert.ToDouble(idnResponseVolt[1]);
                        //Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        if (order >= 0)
                        {
                            //Shell.WriteLine("[Receive]Volt setting is {0} V", volt);
                        }
                        else
                        {
                            volt = volt * Math.Pow(10, order + 3);
                            //Shell.WriteLine("[Receive]Volt setting is {0} mV", volt);
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
                        //Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        if (order >= 0 && order <= 5)
                        {
                            freq = freq * Math.Pow(10, order - 3);
                            //Shell.WriteLine("[Receive]Frequency setting is {0} KHz", freq);
                        }
                        else
                        {
                            //Shell.WriteLine("[Receive]Frequency setting is {0} MHz", freq);
                        }
                        return normalreturn;
                    case "Func:IMP CPG":
                        Comm = comm;
                        formattedIO.WriteLine(Comm);
                        formattedIO.WriteLine("Func:IMP?");
                        idnResponse = formattedIO.ReadLine().Replace("\n", "");
                        //Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        //Shell.WriteLine("[Receive]Function setting is {0}", idnResponse);
                        return normalreturn;
                    case "Func:IMP CSRS":
                        Comm = comm;
                        formattedIO.WriteLine(Comm);
                        formattedIO.WriteLine("Func:IMP?");
                        idnResponse = formattedIO.ReadLine().Replace("\n", "");
                        //Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        //Shell.WriteLine("[Receive]Function setting is {0}", idnResponse);
                        return normalreturn;
                    case "BIAS:STAT 1":
                        Comm = comm;
                        formattedIO.WriteLine(Comm);
                        formattedIO.WriteLine("BIAS:STAT?");
                        idnResponse = formattedIO.ReadLine().Replace("\n", "");
                        //Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        //Shell.WriteLine("[Receive]BIAS is {0}", (idnResponse == "0") ? "OFF" : "ON");
                        return normalreturn;
                    case "BIAS:STAT 0":
                        Comm = comm;
                        formattedIO.WriteLine(Comm);
                        formattedIO.WriteLine("BIAS:STAT?");
                        idnResponse = formattedIO.ReadLine().Replace("\n", "");
                        //Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        //Shell.WriteLine("[Receive]BIAS is {0}", (idnResponse == "0") ? "OFF" : "ON");
                        return normalreturn;
                    case "Fetch?":
                        string[] idnResponseFetch;
                        Comm = comm;
                        formattedIO.WriteLine(Comm);
                        idnResponse = formattedIO.ReadLine().Replace("\n", "");
                        idnResponseFetch = idnResponse.Split(new string[] { "," }, StringSplitOptions.None);
                        //Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        //Shell.WriteLine("[Receive]Measured result is {0}", idnResponse);
                        return idnResponseFetch;

                    //Special Fetch
                    case "Fetch?[Special]":
                        string[] idnResponseFetchSpecial;
                        Comm = "Fetch?";
                        System.Threading.Thread.Sleep(1000);
                        formattedIO.WriteLine(Comm);
                        while(1==1)
                        {
                            try
                            {
                                System.Threading.Thread.Sleep(1000);
                                idnResponse = formattedIO.ReadLine().Replace("\n", "");
                                break;
                            }
                            catch
                            {

                            }
                        }
                        idnResponseFetchSpecial = idnResponse.Split(new string[] { "," }, StringSplitOptions.None);
                        //Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        //Shell.WriteLine("[Receive]Measured result is {0}", idnResponse);
                        return idnResponseFetchSpecial;

                    case "Fetch?[Special2]":
                        string[] idnResponseFetchSpecial2;
                        Comm = "Fetch?";
                        System.Threading.Thread.Sleep(100);
                        formattedIO.WriteLine(Comm);
                        System.Threading.Thread.Sleep(100);
                        idnResponse = formattedIO.ReadLine().Replace("\n", "");
                        idnResponseFetchSpecial2 = idnResponse.Split(new string[] { "," }, StringSplitOptions.None);
                        //Shell.WriteLine("[Send]Send Command is {0}", Comm);
                        //Shell.WriteLine("[Receive]Measured result is {0}", idnResponse);
                        return idnResponseFetchSpecial2;
                }
            }
            catch (NativeVisaException visaException)
            {
                //Shell.WriteLine("Error is:\r\n{0}\r\nPress any key to exit...", visaException);
                return null;
            }
            return null;
        }

        private void btnCVstart_Click(object sender, EventArgs e)
        {
            dtCV = new DataTable();
            dtCV.Columns.Add("V(V)", typeof(float));
            dtCV.Columns.Add("C(F)", typeof(System.Double));
            dgvData.DataSource = dtCV;
            listCVx = new List<double>();
            listCVy = new List<double>();
            listCVy_2 = new List<double>();
            //OPEN GPIB & set parameter
            if (!openGPIB())
            {
                return;
            }
            if (Convert.ToDouble(txtCVACfrequency.Text) < 0.02 || Convert.ToDouble(txtCVACfrequency.Text) > 1000)
            {
                MessageBox.Show("AC Frequency is out of range. The allowed range is 0.02 to 1000, namely 20Hz to 1Mhz.", "Error: Invalid Parameter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            i = 0;
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

        private void btnCfStart_Click(object sender, EventArgs e)
        {
            string Comm;
            doubleQ1 = new Queue<double>();
            doubleQ2 = new Queue<double>();
            dtCF = new DataTable();
            dtCF.Columns.Add("f(Hz)", typeof(System.Double));
            dtCF.Columns.Add("log f", typeof(float));
            dtCF.Columns.Add("ln ω", typeof(System.Double));
            dtCF.Columns.Add("C(F)", typeof(System.Double));
            dtCF.Columns.Add("G(S)", typeof(System.Double));
            dgvData.DataSource = dtCF;
            listCfx = new List<Double>();
            listCfx_2 = new List<Double>();
            listCfy = new List<Double>();
            listCfy_2 = new List<Double>();
            if (!openGPIB())
            {
                return;
            }
            if (Convert.ToDouble(txtStartLogf.Text) < 1.29 || Convert.ToDouble(txtStartLogf.Text) > 6.01)
            {
                MessageBox.Show("Start Frequency is out of range. The allowed range is 1.3 to 6.0, namely 20Hz to 1Mhz.", "Error: Invalid Parameter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToDouble(txtStopLogf.Text) < 1.29 || Convert.ToDouble(txtStopLogf.Text) > 6.01)
            {
                MessageBox.Show("Stop Frequency is out of range. The allowed range is 1.3 to 6.0, namely 20Hz to 1Mhz.", "Error: Invalid Parameter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            i = 0;
            sendCommand("APER");
            ////sendCommand("VOLT");
            ////sendCommand("Freq");
            if (rbParallel.Checked == true)
            {
                sendCommand("Func:IMP CPG");
            }
            else if (rbSeries.Checked == true)
            {
                sendCommand("Func:IMP CSRS");
            }
            sendCommand("BIAS:STAT 1");
            tmrCf.Interval = Convert.ToInt32(txtCVSweepRate.Text);
            ////change bias voltage
            Comm = "BIAS:VOLT " + txtCfMeasVoltage.Text + "V";
            formattedIO.WriteLine(Comm);
            Comm = "Volt" + " " + txtCfOscVoltage.Text + "mV";
            formattedIO.WriteLine(Comm);
            tmrCf.Tick += new EventHandler(RunCf);
            tmrCf.Enabled = true;
            state = RunState.running;
            widgetStateChange(state);
        }

        private void btnCfStop_Click(object sender, EventArgs e)
        {
            i = 0;
            tmrCf.Enabled = false;
            state = RunState.stop;
            widgetStateChange(state);
            sendCommand("BIAS:STAT 0");
            session.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCfCalculate_Click(object sender, EventArgs e)
        {
            caculateCf(dtCF, dgvData);
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
                return;
            }

            // Send the *IDN? and read the response as strings
            formattedIO.WriteLine("*IDN?");
            System.Threading.Thread.Sleep(1);
            //Shell.WriteLine("[Send]Send Command is *IDN?");
            string idnResponse = formattedIO.ReadLine();
            //Shell.WriteLine("[Receive]*IDN? returned: {0}", idnResponse);
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
            double[] res = new double[6];
            res[0] = 2.14E-10; res[1] = 3.12E-10; res[2] = 4.52E-10; res[3] = 6.51E-10; res[4] = 8.12E-10; res[5] = 7.82E-10;
            dtCF = new DataTable();
            dtCF.Columns.Add("f(Hz)", typeof(System.Double));
            dtCF.Columns.Add("log f", typeof(float));
            dtCF.Columns.Add("ln ω", typeof(System.Double));
            dtCF.Columns.Add("C(F)", typeof(System.Double));
            dgvData.DataSource = dtCF;
            listCfx = new List<Double>();
            listCfx_2 = new List<Double>();
            listCfy = new List<Double>();
            listCfy_2 = new List<Double>();
            double StartLogf = 1.4;
            double StepLogf = 0.1;
            for(i=0;i<6;i++)
            {
                dtCF.Rows.Add(Math.Pow(10, StartLogf + StepLogf * i), StartLogf + StepLogf * i, Math.Log(2 * Math.PI * Math.Pow(10, StartLogf + StepLogf * i)), Convert.ToDouble(res[i]));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtCV = new DataTable();
            dtCF = new DataTable();
            dgvData.DataSource = dtCV;
            listCVx = new List<double>();
            listCVy = new List<double>();
            listCVy_2 = new List<double>();
            plot(chartCV, "C-V", listCVx, listCVy);
            plot(chartCV_2, "1/C²-V", listCVx, listCVy_2);
            plot(chartCf, "C-log(f)", listCVx, listCVy);
            plot(chartCf_2, "dC-dln(ω)", listCVx, listCVy_2);
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            caculateCf(dtCF, dgvData);
            List<double> listX = new List<double>();
            List<double> listX_2 = new List<double>();
            List<double> listY = new List<double>();
            List<double> listY_2 = new List<double>();
            for (i=0;i<40;i++)
            {
                listX.Add(-1 + 0.05 * i);
                listY.Add(2.14E-11 * i);
                if (listX.Count >= 2)
                {
                    listY_2.Add((listY[i] - listY[i - 1]) / (listX[i] - listX[i - 1]));
                    listX_2.Add(listX[i-1]);
                    plot(chartCf_2, "dC-dlog(f)", listX_2, listY_2);
                }
                
            }
            
        }
        private void plot(Chart chart, string tag, List<double> listx, List<double> listy)
        {
            chart.Series.Clear();
            Series series = new Series(tag);
            series.ChartType = SeriesChartType.Spline;
            series.Points.DataBindXY(listx, listy);
            chart.Series.Add(series);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataGridViewToCSV(dgvData);
        }

        private void txtCVPermittivity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void chartCV_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            caculateCV(dtCV, dgvData);
        }

        private void txtCVStartVoltage_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbInterMedium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C-V/C-f Sweep \nDeveloped for Agilent 4284A Precision LCR Meter\nVersion 1.0\nBuilt on 11/13/2017", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
