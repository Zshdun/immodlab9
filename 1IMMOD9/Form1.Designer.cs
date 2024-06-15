namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Prob7 = new System.Windows.Forms.Label();
            this.tbpr1 = new System.Windows.Forms.NumericUpDown();
            this.tbpr2 = new System.Windows.Forms.NumericUpDown();
            this.tbpr3 = new System.Windows.Forms.NumericUpDown();
            this.tbpr6 = new System.Windows.Forms.NumericUpDown();
            this.tbpr5 = new System.Windows.Forms.NumericUpDown();
            this.tbpr4 = new System.Windows.Forms.NumericUpDown();
            this.tbN = new System.Windows.Forms.NumericUpDown();
            this.tbpr7 = new System.Windows.Forms.TextBox();
            this.tbprEx1 = new System.Windows.Forms.TextBox();
            this.tbprEx2 = new System.Windows.Forms.TextBox();
            this.tbprEx4 = new System.Windows.Forms.TextBox();
            this.tbprEx3 = new System.Windows.Forms.TextBox();
            this.tbprEx6 = new System.Windows.Forms.TextBox();
            this.tbprEx5 = new System.Windows.Forms.TextBox();
            this.tbprEx7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbMean = new System.Windows.Forms.Label();
            this.tbVariance = new System.Windows.Forms.Label();
            this.tbChiSquare = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.checkText = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.n3 = new System.Windows.Forms.Label();
            this.n4 = new System.Windows.Forms.Label();
            this.n5 = new System.Windows.Forms.Label();
            this.n6 = new System.Windows.Forms.Label();
            this.n7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.meanErr = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.varErr = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbN)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(311, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(594, 449);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Теоретическая";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Эмпирическая";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "вер-ть 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "вер-ть 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "вер-ть 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "вер-ть 6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "вер-ть 5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "вер-ть 4";
            // 
            // Prob7
            // 
            this.Prob7.AutoSize = true;
            this.Prob7.Location = new System.Drawing.Point(12, 206);
            this.Prob7.Name = "Prob7";
            this.Prob7.Size = new System.Drawing.Size(51, 13);
            this.Prob7.TabIndex = 10;
            this.Prob7.Text = "вер-ть 7 ";
            // 
            // tbpr1
            // 
            this.tbpr1.DecimalPlaces = 2;
            this.tbpr1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tbpr1.Location = new System.Drawing.Point(67, 36);
            this.tbpr1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbpr1.Name = "tbpr1";
            this.tbpr1.Size = new System.Drawing.Size(96, 20);
            this.tbpr1.TabIndex = 11;
            this.tbpr1.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // tbpr2
            // 
            this.tbpr2.DecimalPlaces = 2;
            this.tbpr2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tbpr2.Location = new System.Drawing.Point(67, 64);
            this.tbpr2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbpr2.Name = "tbpr2";
            this.tbpr2.Size = new System.Drawing.Size(96, 20);
            this.tbpr2.TabIndex = 12;
            this.tbpr2.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // tbpr3
            // 
            this.tbpr3.DecimalPlaces = 2;
            this.tbpr3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tbpr3.Location = new System.Drawing.Point(67, 90);
            this.tbpr3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbpr3.Name = "tbpr3";
            this.tbpr3.Size = new System.Drawing.Size(96, 20);
            this.tbpr3.TabIndex = 13;
            this.tbpr3.Value = new decimal(new int[] {
            11,
            0,
            0,
            131072});
            // 
            // tbpr6
            // 
            this.tbpr6.DecimalPlaces = 2;
            this.tbpr6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tbpr6.Location = new System.Drawing.Point(67, 173);
            this.tbpr6.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbpr6.Name = "tbpr6";
            this.tbpr6.Size = new System.Drawing.Size(96, 20);
            this.tbpr6.TabIndex = 16;
            this.tbpr6.Value = new decimal(new int[] {
            19,
            0,
            0,
            131072});
            // 
            // tbpr5
            // 
            this.tbpr5.DecimalPlaces = 2;
            this.tbpr5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tbpr5.Location = new System.Drawing.Point(67, 147);
            this.tbpr5.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbpr5.Name = "tbpr5";
            this.tbpr5.Size = new System.Drawing.Size(96, 20);
            this.tbpr5.TabIndex = 15;
            this.tbpr5.Value = new decimal(new int[] {
            14,
            0,
            0,
            131072});
            // 
            // tbpr4
            // 
            this.tbpr4.DecimalPlaces = 2;
            this.tbpr4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tbpr4.Location = new System.Drawing.Point(67, 119);
            this.tbpr4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbpr4.Name = "tbpr4";
            this.tbpr4.Size = new System.Drawing.Size(96, 20);
            this.tbpr4.TabIndex = 14;
            this.tbpr4.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(133, 244);
            this.tbN.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(63, 20);
            this.tbN.TabIndex = 17;
            this.tbN.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tbpr7
            // 
            this.tbpr7.Location = new System.Drawing.Point(67, 203);
            this.tbpr7.Name = "tbpr7";
            this.tbpr7.ReadOnly = true;
            this.tbpr7.Size = new System.Drawing.Size(96, 20);
            this.tbpr7.TabIndex = 18;
            // 
            // tbprEx1
            // 
            this.tbprEx1.Location = new System.Drawing.Point(209, 36);
            this.tbprEx1.Name = "tbprEx1";
            this.tbprEx1.ReadOnly = true;
            this.tbprEx1.Size = new System.Drawing.Size(96, 20);
            this.tbprEx1.TabIndex = 19;
            // 
            // tbprEx2
            // 
            this.tbprEx2.Location = new System.Drawing.Point(209, 62);
            this.tbprEx2.Name = "tbprEx2";
            this.tbprEx2.ReadOnly = true;
            this.tbprEx2.Size = new System.Drawing.Size(96, 20);
            this.tbprEx2.TabIndex = 20;
            // 
            // tbprEx4
            // 
            this.tbprEx4.Location = new System.Drawing.Point(209, 119);
            this.tbprEx4.Name = "tbprEx4";
            this.tbprEx4.ReadOnly = true;
            this.tbprEx4.Size = new System.Drawing.Size(96, 20);
            this.tbprEx4.TabIndex = 22;
            // 
            // tbprEx3
            // 
            this.tbprEx3.Location = new System.Drawing.Point(209, 90);
            this.tbprEx3.Name = "tbprEx3";
            this.tbprEx3.ReadOnly = true;
            this.tbprEx3.Size = new System.Drawing.Size(96, 20);
            this.tbprEx3.TabIndex = 21;
            // 
            // tbprEx6
            // 
            this.tbprEx6.Location = new System.Drawing.Point(209, 172);
            this.tbprEx6.Name = "tbprEx6";
            this.tbprEx6.ReadOnly = true;
            this.tbprEx6.Size = new System.Drawing.Size(96, 20);
            this.tbprEx6.TabIndex = 24;
            // 
            // tbprEx5
            // 
            this.tbprEx5.Location = new System.Drawing.Point(209, 147);
            this.tbprEx5.Name = "tbprEx5";
            this.tbprEx5.ReadOnly = true;
            this.tbprEx5.Size = new System.Drawing.Size(96, 20);
            this.tbprEx5.TabIndex = 23;
            // 
            // tbprEx7
            // 
            this.tbprEx7.Location = new System.Drawing.Point(209, 203);
            this.tbprEx7.Name = "tbprEx7";
            this.tbprEx7.ReadOnly = true;
            this.tbprEx7.Size = new System.Drawing.Size(96, 20);
            this.tbprEx7.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Количество опытов";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(105, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 60);
            this.button1.TabIndex = 34;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbMean
            // 
            this.tbMean.AutoSize = true;
            this.tbMean.Location = new System.Drawing.Point(122, 346);
            this.tbMean.Name = "tbMean";
            this.tbMean.Size = new System.Drawing.Size(0, 13);
            this.tbMean.TabIndex = 35;
            // 
            // tbVariance
            // 
            this.tbVariance.AutoSize = true;
            this.tbVariance.Location = new System.Drawing.Point(122, 380);
            this.tbVariance.Name = "tbVariance";
            this.tbVariance.Size = new System.Drawing.Size(0, 13);
            this.tbVariance.TabIndex = 35;
            // 
            // tbChiSquare
            // 
            this.tbChiSquare.AutoSize = true;
            this.tbChiSquare.Location = new System.Drawing.Point(122, 409);
            this.tbChiSquare.Name = "tbChiSquare";
            this.tbChiSquare.Size = new System.Drawing.Size(0, 13);
            this.tbChiSquare.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Выбороч.Среднее:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Дисперсия:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 409);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "стат.ХиКвадрат";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 440);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Проверка:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkText
            // 
            this.checkText.AutoSize = true;
            this.checkText.Location = new System.Drawing.Point(122, 440);
            this.checkText.Name = "checkText";
            this.checkText.Size = new System.Drawing.Size(0, 13);
            this.checkText.TabIndex = 35;
            this.checkText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Location = new System.Drawing.Point(169, 39);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(0, 13);
            this.n1.TabIndex = 35;
            this.n1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Location = new System.Drawing.Point(169, 69);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(0, 13);
            this.n2.TabIndex = 35;
            this.n2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // n3
            // 
            this.n3.AutoSize = true;
            this.n3.Location = new System.Drawing.Point(169, 93);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(0, 13);
            this.n3.TabIndex = 35;
            this.n3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // n4
            // 
            this.n4.AutoSize = true;
            this.n4.Location = new System.Drawing.Point(169, 124);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(0, 13);
            this.n4.TabIndex = 35;
            this.n4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // n5
            // 
            this.n5.AutoSize = true;
            this.n5.Location = new System.Drawing.Point(169, 150);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(0, 13);
            this.n5.TabIndex = 35;
            this.n5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // n6
            // 
            this.n6.AutoSize = true;
            this.n6.Location = new System.Drawing.Point(169, 176);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(0, 13);
            this.n6.TabIndex = 35;
            this.n6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // n7
            // 
            this.n7.AutoSize = true;
            this.n7.Location = new System.Drawing.Point(169, 206);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(0, 13);
            this.n7.TabIndex = 35;
            this.n7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Погрешность:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // meanErr
            // 
            this.meanErr.AutoSize = true;
            this.meanErr.Location = new System.Drawing.Point(272, 346);
            this.meanErr.Name = "meanErr";
            this.meanErr.Size = new System.Drawing.Size(0, 13);
            this.meanErr.TabIndex = 35;
            this.meanErr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(180, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Погрешность";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // varErr
            // 
            this.varErr.AutoSize = true;
            this.varErr.Location = new System.Drawing.Point(272, 380);
            this.varErr.Name = "varErr";
            this.varErr.Size = new System.Drawing.Size(0, 13);
            this.varErr.TabIndex = 35;
            this.varErr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(180, 409);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Сравнивается с";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(272, 409);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "12,592";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 473);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.checkText);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.meanErr);
            this.Controls.Add(this.varErr);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbChiSquare);
            this.Controls.Add(this.tbVariance);
            this.Controls.Add(this.tbMean);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbprEx7);
            this.Controls.Add(this.tbprEx6);
            this.Controls.Add(this.tbprEx5);
            this.Controls.Add(this.tbprEx4);
            this.Controls.Add(this.tbprEx3);
            this.Controls.Add(this.tbprEx2);
            this.Controls.Add(this.tbprEx1);
            this.Controls.Add(this.tbpr7);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.tbpr6);
            this.Controls.Add(this.tbpr5);
            this.Controls.Add(this.tbpr4);
            this.Controls.Add(this.tbpr3);
            this.Controls.Add(this.tbpr2);
            this.Controls.Add(this.tbpr1);
            this.Controls.Add(this.Prob7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbpr4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Prob7;
        private System.Windows.Forms.NumericUpDown tbpr1;
        private System.Windows.Forms.NumericUpDown tbpr2;
        private System.Windows.Forms.NumericUpDown tbpr3;
        private System.Windows.Forms.NumericUpDown tbpr6;
        private System.Windows.Forms.NumericUpDown tbpr5;
        private System.Windows.Forms.NumericUpDown tbpr4;
        private System.Windows.Forms.NumericUpDown tbN;
        private System.Windows.Forms.TextBox tbpr7;
        private System.Windows.Forms.TextBox tbprEx1;
        private System.Windows.Forms.TextBox tbprEx2;
        private System.Windows.Forms.TextBox tbprEx4;
        private System.Windows.Forms.TextBox tbprEx3;
        private System.Windows.Forms.TextBox tbprEx6;
        private System.Windows.Forms.TextBox tbprEx5;
        private System.Windows.Forms.TextBox tbprEx7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tbMean;
        private System.Windows.Forms.Label tbVariance;
        private System.Windows.Forms.Label tbChiSquare;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label checkText;
        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label n3;
        private System.Windows.Forms.Label n4;
        private System.Windows.Forms.Label n5;
        private System.Windows.Forms.Label n6;
        private System.Windows.Forms.Label n7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label meanErr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label varErr;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

