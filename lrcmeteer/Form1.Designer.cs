namespace lrcmeteer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCVstop = new System.Windows.Forms.Button();
            this.btnCVstart = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCVPermittivity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCVArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCVSweepRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCVOscVoltage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCVACfrequency = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCVStepVoltage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCVStopVoltage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCVStartVoltage = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAveRate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbInterLong = new System.Windows.Forms.RadioButton();
            this.rbInterMedium = new System.Windows.Forms.RadioButton();
            this.rbInterShort = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbSeries = new System.Windows.Forms.RadioButton();
            this.rbParallel = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtStepLogf = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtStopLogf = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnCfCalculate = new System.Windows.Forms.Button();
            this.btnCfStop = new System.Windows.Forms.Button();
            this.btnCfStart = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtStartLogf = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtCfArea = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtCfOscVoltage = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtCfMeasVoltage = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.tmrCV = new System.Windows.Forms.Timer(this.components);
            this.tmrCf = new System.Windows.Forms.Timer(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnTest1 = new System.Windows.Forms.Button();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.chartCV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCV_2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.chartCf_2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCV_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCf_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.btnCVstop);
            this.groupBox1.Controls.Add(this.btnCVstart);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCVPermittivity);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCVArea);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCVSweepRate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCVOscVoltage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCVACfrequency);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCVStepVoltage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCVStopVoltage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCVStartVoltage);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 457);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "C-V";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(10, 368);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(81, 23);
            this.btnCalculate.TabIndex = 77;
            this.btnCalculate.Text = "Caculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnCVstop
            // 
            this.btnCVstop.Enabled = false;
            this.btnCVstop.Location = new System.Drawing.Point(10, 428);
            this.btnCVstop.Name = "btnCVstop";
            this.btnCVstop.Size = new System.Drawing.Size(81, 25);
            this.btnCVstop.TabIndex = 25;
            this.btnCVstop.Text = "Stop";
            this.btnCVstop.UseVisualStyleBackColor = true;
            this.btnCVstop.Click += new System.EventHandler(this.btnCVstop_Click);
            // 
            // btnCVstart
            // 
            this.btnCVstart.Location = new System.Drawing.Point(10, 397);
            this.btnCVstart.Name = "btnCVstart";
            this.btnCVstart.Size = new System.Drawing.Size(81, 25);
            this.btnCVstart.TabIndex = 24;
            this.btnCVstart.Text = "Start";
            this.btnCVstart.UseVisualStyleBackColor = true;
            this.btnCVstart.Click += new System.EventHandler(this.btnCVstart_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(108, 295);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 7);
            this.label16.TabIndex = 23;
            this.label16.Text = "-2";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(96, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "cm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(96, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "ms";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(96, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "mV";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "KHz";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(96, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "V";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "V";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "V";
            // 
            // txtCVPermittivity
            // 
            this.txtCVPermittivity.Location = new System.Drawing.Point(9, 335);
            this.txtCVPermittivity.Name = "txtCVPermittivity";
            this.txtCVPermittivity.Size = new System.Drawing.Size(81, 20);
            this.txtCVPermittivity.TabIndex = 15;
            this.txtCVPermittivity.Text = "11";
            this.txtCVPermittivity.TextChanged += new System.EventHandler(this.txtCVPermittivity_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Permittivity";
            // 
            // txtCVArea
            // 
            this.txtCVArea.Location = new System.Drawing.Point(9, 293);
            this.txtCVArea.Name = "txtCVArea";
            this.txtCVArea.Size = new System.Drawing.Size(81, 20);
            this.txtCVArea.TabIndex = 13;
            this.txtCVArea.Text = "0.24";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Area";
            // 
            // txtCVSweepRate
            // 
            this.txtCVSweepRate.Location = new System.Drawing.Point(9, 250);
            this.txtCVSweepRate.Name = "txtCVSweepRate";
            this.txtCVSweepRate.Size = new System.Drawing.Size(81, 20);
            this.txtCVSweepRate.TabIndex = 11;
            this.txtCVSweepRate.Text = "100";
            this.txtCVSweepRate.TextChanged += new System.EventHandler(this.txtCVSweepRate_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sweep Rate(DC-Bias)";
            // 
            // txtCVOscVoltage
            // 
            this.txtCVOscVoltage.Location = new System.Drawing.Point(9, 208);
            this.txtCVOscVoltage.Name = "txtCVOscVoltage";
            this.txtCVOscVoltage.Size = new System.Drawing.Size(81, 20);
            this.txtCVOscVoltage.TabIndex = 9;
            this.txtCVOscVoltage.Text = "25";
            this.txtCVOscVoltage.TextChanged += new System.EventHandler(this.txtCVOscVoltage_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Oscillation Voltage";
            // 
            // txtCVACfrequency
            // 
            this.txtCVACfrequency.Location = new System.Drawing.Point(9, 166);
            this.txtCVACfrequency.Name = "txtCVACfrequency";
            this.txtCVACfrequency.Size = new System.Drawing.Size(81, 20);
            this.txtCVACfrequency.TabIndex = 7;
            this.txtCVACfrequency.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "AC Frequency";
            // 
            // txtCVStepVoltage
            // 
            this.txtCVStepVoltage.Location = new System.Drawing.Point(9, 124);
            this.txtCVStepVoltage.Name = "txtCVStepVoltage";
            this.txtCVStepVoltage.Size = new System.Drawing.Size(81, 20);
            this.txtCVStepVoltage.TabIndex = 5;
            this.txtCVStepVoltage.Text = "0.05";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Step Voltage";
            // 
            // txtCVStopVoltage
            // 
            this.txtCVStopVoltage.Location = new System.Drawing.Point(9, 81);
            this.txtCVStopVoltage.Name = "txtCVStopVoltage";
            this.txtCVStopVoltage.Size = new System.Drawing.Size(81, 20);
            this.txtCVStopVoltage.TabIndex = 3;
            this.txtCVStopVoltage.Text = "0.5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stop Voltage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Voltage";
            // 
            // txtCVStartVoltage
            // 
            this.txtCVStartVoltage.Location = new System.Drawing.Point(9, 39);
            this.txtCVStartVoltage.Name = "txtCVStartVoltage";
            this.txtCVStartVoltage.Size = new System.Drawing.Size(81, 20);
            this.txtCVStartVoltage.TabIndex = 0;
            this.txtCVStartVoltage.Text = "-2";
            this.txtCVStartVoltage.TextChanged += new System.EventHandler(this.txtCVStartVoltage_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAveRate);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(153, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Intergration";
            // 
            // txtAveRate
            // 
            this.txtAveRate.Location = new System.Drawing.Point(145, 85);
            this.txtAveRate.Name = "txtAveRate";
            this.txtAveRate.Size = new System.Drawing.Size(81, 20);
            this.txtAveRate.TabIndex = 4;
            this.txtAveRate.Text = "4";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(143, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Averaging Rate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbInterLong);
            this.groupBox3.Controls.Add(this.rbInterMedium);
            this.groupBox3.Controls.Add(this.rbInterShort);
            this.groupBox3.Location = new System.Drawing.Point(6, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 90);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Intergration Time";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rbInterLong
            // 
            this.rbInterLong.AutoSize = true;
            this.rbInterLong.Location = new System.Drawing.Point(6, 67);
            this.rbInterLong.Name = "rbInterLong";
            this.rbInterLong.Size = new System.Drawing.Size(55, 17);
            this.rbInterLong.TabIndex = 2;
            this.rbInterLong.Text = "LONG";
            this.rbInterLong.UseVisualStyleBackColor = true;
            // 
            // rbInterMedium
            // 
            this.rbInterMedium.AutoSize = true;
            this.rbInterMedium.Checked = true;
            this.rbInterMedium.Location = new System.Drawing.Point(6, 44);
            this.rbInterMedium.Name = "rbInterMedium";
            this.rbInterMedium.Size = new System.Drawing.Size(69, 17);
            this.rbInterMedium.TabIndex = 1;
            this.rbInterMedium.TabStop = true;
            this.rbInterMedium.Text = "MEDIUM";
            this.rbInterMedium.UseVisualStyleBackColor = true;
            this.rbInterMedium.CheckedChanged += new System.EventHandler(this.rbInterMedium_CheckedChanged);
            // 
            // rbInterShort
            // 
            this.rbInterShort.AutoSize = true;
            this.rbInterShort.Location = new System.Drawing.Point(6, 22);
            this.rbInterShort.Name = "rbInterShort";
            this.rbInterShort.Size = new System.Drawing.Size(63, 17);
            this.rbInterShort.TabIndex = 0;
            this.rbInterShort.Text = "SHORT";
            this.rbInterShort.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbSeries);
            this.groupBox4.Controls.Add(this.rbParallel);
            this.groupBox4.Location = new System.Drawing.Point(398, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(119, 119);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Equivalent Circuit";
            // 
            // rbSeries
            // 
            this.rbSeries.AutoSize = true;
            this.rbSeries.Location = new System.Drawing.Point(23, 70);
            this.rbSeries.Name = "rbSeries";
            this.rbSeries.Size = new System.Drawing.Size(54, 17);
            this.rbSeries.TabIndex = 2;
            this.rbSeries.TabStop = true;
            this.rbSeries.Text = "Series";
            this.rbSeries.UseVisualStyleBackColor = true;
            // 
            // rbParallel
            // 
            this.rbParallel.AutoSize = true;
            this.rbParallel.Checked = true;
            this.rbParallel.Location = new System.Drawing.Point(23, 43);
            this.rbParallel.Name = "rbParallel";
            this.rbParallel.Size = new System.Drawing.Size(59, 17);
            this.rbParallel.TabIndex = 1;
            this.rbParallel.TabStop = true;
            this.rbParallel.Text = "Parallel";
            this.rbParallel.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.txtStepLogf);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.txtStopLogf);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.btnCfCalculate);
            this.groupBox5.Controls.Add(this.btnCfStop);
            this.groupBox5.Controls.Add(this.btnCfStart);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.txtStartLogf);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.txtCfArea);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.txtCfOscVoltage);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.txtCfMeasVoltage);
            this.groupBox5.Location = new System.Drawing.Point(12, 476);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(135, 434);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "C-f";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(108, 249);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(12, 7);
            this.label23.TabIndex = 43;
            this.label23.Text = "-2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(95, 252);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "cm";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 210);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "log(f)";
            // 
            // txtStepLogf
            // 
            this.txtStepLogf.Location = new System.Drawing.Point(39, 207);
            this.txtStepLogf.Name = "txtStepLogf";
            this.txtStepLogf.Size = new System.Drawing.Size(50, 20);
            this.txtStepLogf.TabIndex = 40;
            this.txtStepLogf.Text = "0.1";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 191);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(82, 13);
            this.label28.TabIndex = 39;
            this.label28.Text = "Frequency Step";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 168);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 13);
            this.label21.TabIndex = 38;
            this.label21.Text = "log(f)";
            // 
            // txtStopLogf
            // 
            this.txtStopLogf.Location = new System.Drawing.Point(40, 165);
            this.txtStopLogf.Name = "txtStopLogf";
            this.txtStopLogf.Size = new System.Drawing.Size(50, 20);
            this.txtStopLogf.TabIndex = 37;
            this.txtStopLogf.Text = "6.0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 149);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(82, 13);
            this.label26.TabIndex = 36;
            this.label26.Text = "Stop Frequency";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 126);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 13);
            this.label22.TabIndex = 35;
            this.label22.Text = "log(f)";
            // 
            // btnCfCalculate
            // 
            this.btnCfCalculate.Location = new System.Drawing.Point(10, 285);
            this.btnCfCalculate.Name = "btnCfCalculate";
            this.btnCfCalculate.Size = new System.Drawing.Size(81, 25);
            this.btnCfCalculate.TabIndex = 31;
            this.btnCfCalculate.Text = "Calculate";
            this.btnCfCalculate.UseVisualStyleBackColor = true;
            this.btnCfCalculate.Click += new System.EventHandler(this.btnCfCalculate_Click);
            // 
            // btnCfStop
            // 
            this.btnCfStop.Enabled = false;
            this.btnCfStop.Location = new System.Drawing.Point(10, 347);
            this.btnCfStop.Name = "btnCfStop";
            this.btnCfStop.Size = new System.Drawing.Size(81, 25);
            this.btnCfStop.TabIndex = 25;
            this.btnCfStop.Text = "Stop";
            this.btnCfStop.UseVisualStyleBackColor = true;
            this.btnCfStop.Click += new System.EventHandler(this.btnCfStop_Click);
            // 
            // btnCfStart
            // 
            this.btnCfStart.Location = new System.Drawing.Point(10, 316);
            this.btnCfStart.Name = "btnCfStart";
            this.btnCfStart.Size = new System.Drawing.Size(81, 25);
            this.btnCfStart.TabIndex = 24;
            this.btnCfStart.Text = "Start";
            this.btnCfStart.UseVisualStyleBackColor = true;
            this.btnCfStart.Click += new System.EventHandler(this.btnCfStart_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(96, 85);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(22, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "mV";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(96, 42);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 13);
            this.label25.TabIndex = 16;
            this.label25.Text = "V";
            // 
            // txtStartLogf
            // 
            this.txtStartLogf.Location = new System.Drawing.Point(40, 123);
            this.txtStartLogf.Name = "txtStartLogf";
            this.txtStartLogf.Size = new System.Drawing.Size(50, 20);
            this.txtStartLogf.TabIndex = 7;
            this.txtStartLogf.Text = "1.4";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(7, 107);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(82, 13);
            this.label30.TabIndex = 6;
            this.label30.Text = "Start Frequency";
            // 
            // txtCfArea
            // 
            this.txtCfArea.Location = new System.Drawing.Point(10, 249);
            this.txtCfArea.Name = "txtCfArea";
            this.txtCfArea.Size = new System.Drawing.Size(81, 20);
            this.txtCfArea.TabIndex = 5;
            this.txtCfArea.Text = "0.24";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 233);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 13);
            this.label31.TabIndex = 4;
            this.label31.Text = "Area";
            // 
            // txtCfOscVoltage
            // 
            this.txtCfOscVoltage.Location = new System.Drawing.Point(9, 81);
            this.txtCfOscVoltage.Name = "txtCfOscVoltage";
            this.txtCfOscVoltage.Size = new System.Drawing.Size(81, 20);
            this.txtCfOscVoltage.TabIndex = 3;
            this.txtCfOscVoltage.Text = "25";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 65);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(94, 13);
            this.label32.TabIndex = 2;
            this.label32.Text = "Oscillation Voltage";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 23);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(110, 13);
            this.label33.TabIndex = 1;
            this.label33.Text = "Measurement Voltage";
            // 
            // txtCfMeasVoltage
            // 
            this.txtCfMeasVoltage.Location = new System.Drawing.Point(9, 39);
            this.txtCfMeasVoltage.Name = "txtCfMeasVoltage";
            this.txtCfMeasVoltage.Size = new System.Drawing.Size(81, 20);
            this.txtCfMeasVoltage.TabIndex = 0;
            this.txtCfMeasVoltage.Text = "1.0";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(688, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tmrCV
            // 
            this.tmrCV.Interval = 1000;
            // 
            // tmrCf
            // 
            this.tmrCf.Tick += new System.EventHandler(this.tmrGf_Tick);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(526, 14);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(156, 23);
            this.btnConnect.TabIndex = 63;
            this.btnConnect.Text = "Connect Instruments";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(526, 94);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(682, 95);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 65;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(184, 441);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(555, 211);
            this.dgvData.TabIndex = 66;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnTest1
            // 
            this.btnTest1.Location = new System.Drawing.Point(526, 43);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(75, 23);
            this.btnTest1.TabIndex = 67;
            this.btnTest1.Text = "Test1";
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click);
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(603, 43);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(75, 23);
            this.btnTest2.TabIndex = 68;
            this.btnTest2.Text = "Test2";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // chartCV
            // 
            this.chartCV.BackColor = System.Drawing.Color.Transparent;
            this.chartCV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            this.chartCV.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartCV.Legends.Add(legend1);
            this.chartCV.Location = new System.Drawing.Point(179, 151);
            this.chartCV.Name = "chartCV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCV.Series.Add(series1);
            this.chartCV.Size = new System.Drawing.Size(280, 270);
            this.chartCV.TabIndex = 69;
            this.chartCV.Text = "C-V";
            this.chartCV.Click += new System.EventHandler(this.chartCV_Click);
            // 
            // chartCV_2
            // 
            this.chartCV_2.BackColor = System.Drawing.Color.Transparent;
            this.chartCV_2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartCV_2.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartCV_2.Legends.Add(legend2);
            this.chartCV_2.Location = new System.Drawing.Point(483, 151);
            this.chartCV_2.Name = "chartCV_2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCV_2.Series.Add(series2);
            this.chartCV_2.Size = new System.Drawing.Size(280, 270);
            this.chartCV_2.TabIndex = 70;
            this.chartCV_2.Text = "chart1";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(181, 139);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(24, 13);
            this.label40.TabIndex = 72;
            this.label40.Text = "C-V";
            this.label40.Click += new System.EventHandler(this.label40_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(486, 138);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(38, 13);
            this.label41.TabIndex = 73;
            this.label41.Text = "1/C²-V";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(309, 416);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(14, 13);
            this.label42.TabIndex = 74;
            this.label42.Text = "V";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(632, 416);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(14, 13);
            this.label43.TabIndex = 75;
            this.label43.Text = "V";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(176, 163);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(13, 13);
            this.label44.TabIndex = 76;
            this.label44.Text = "F";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(175, 688);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(13, 13);
            this.label39.TabIndex = 83;
            this.label39.Text = "F";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(485, 666);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(53, 13);
            this.label47.TabIndex = 80;
            this.label47.Text = "dC/dln(ω)";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(180, 667);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(40, 13);
            this.label48.TabIndex = 79;
            this.label48.Text = "C-log(f)";
            // 
            // chartCf_2
            // 
            this.chartCf_2.BackColor = System.Drawing.Color.Transparent;
            this.chartCf_2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartCf_2.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartCf_2.Legends.Add(legend3);
            this.chartCf_2.Location = new System.Drawing.Point(483, 679);
            this.chartCf_2.Name = "chartCf_2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartCf_2.Series.Add(series3);
            this.chartCf_2.Size = new System.Drawing.Size(280, 270);
            this.chartCf_2.TabIndex = 78;
            this.chartCf_2.Text = "chart1";
            // 
            // chartCf
            // 
            this.chartCf.BackColor = System.Drawing.Color.Transparent;
            this.chartCf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea4.Name = "ChartArea1";
            this.chartCf.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartCf.Legends.Add(legend4);
            this.chartCf.Location = new System.Drawing.Point(179, 679);
            this.chartCf.Name = "chartCf";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartCf.Series.Add(series4);
            this.chartCf.Size = new System.Drawing.Size(280, 270);
            this.chartCf.TabIndex = 77;
            this.chartCf.Text = "C-V";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(lrcmeteer.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(774, 961);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.chartCf_2);
            this.Controls.Add(this.chartCf);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.chartCV_2);
            this.Controls.Add(this.chartCV);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.btnTest1);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "C-V/C-f Sweep";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCV_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCf_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCVstop;
        private System.Windows.Forms.Button btnCVstart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCVPermittivity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCVArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCVSweepRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCVOscVoltage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCVACfrequency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCVStepVoltage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCVStopVoltage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCVStartVoltage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAveRate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbInterLong;
        private System.Windows.Forms.RadioButton rbInterMedium;
        private System.Windows.Forms.RadioButton rbInterShort;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbSeries;
        private System.Windows.Forms.RadioButton rbParallel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCfCalculate;
        private System.Windows.Forms.Button btnCfStop;
        private System.Windows.Forms.Button btnCfStart;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtCfArea;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtCfOscVoltage;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtCfMeasVoltage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer tmrCV;
        private System.Windows.Forms.Timer tmrCf;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCV_2;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtStepLogf;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtStopLogf;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtStartLogf;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCf_2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCf;
        private System.Windows.Forms.Label label23;
    }
}

