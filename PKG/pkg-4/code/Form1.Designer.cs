
namespace PKG_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pBresenham = new System.Windows.Forms.Panel();
            this.pDDA = new System.Windows.Forms.Panel();
            this.pCircle = new System.Windows.Forms.Panel();
            this.pWu = new System.Windows.Forms.Panel();
            this.pNaive = new System.Windows.Forms.Panel();
            this.nYa = new System.Windows.Forms.NumericUpDown();
            this.nXa = new System.Windows.Forms.NumericUpDown();
            this.nXb = new System.Windows.Forms.NumericUpDown();
            this.nYb = new System.Windows.Forms.NumericUpDown();
            this.bLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bCircle = new System.Windows.Forms.Button();
            this.nCenterX = new System.Windows.Forms.NumericUpDown();
            this.nRadius = new System.Windows.Forms.NumericUpDown();
            this.nScale = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bScale = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nCenterY = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tbBresenham = new System.Windows.Forms.TextBox();
            this.tbDDA = new System.Windows.Forms.TextBox();
            this.tbWu = new System.Windows.Forms.TextBox();
            this.tbNaive = new System.Windows.Forms.TextBox();
            this.tbCircle = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.vsbCircle = new System.Windows.Forms.VScrollBar();
            this.vsbBreseham = new System.Windows.Forms.VScrollBar();
            this.vsbNaive = new System.Windows.Forms.VScrollBar();
            this.vsbWu = new System.Windows.Forms.VScrollBar();
            this.vsbDDA = new System.Windows.Forms.VScrollBar();
            this.hsbBresenham = new System.Windows.Forms.HScrollBar();
            this.hsbDDA = new System.Windows.Forms.HScrollBar();
            this.hsbNaive = new System.Windows.Forms.HScrollBar();
            this.hsbWu = new System.Windows.Forms.HScrollBar();
            this.hsbCircle = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.nYa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCenterX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCenterY)).BeginInit();
            this.SuspendLayout();
            // 
            // pBresenham
            // 
            this.pBresenham.BackColor = System.Drawing.Color.White;
            this.pBresenham.Location = new System.Drawing.Point(25, 48);
            this.pBresenham.Name = "pBresenham";
            this.pBresenham.Size = new System.Drawing.Size(436, 278);
            this.pBresenham.TabIndex = 0;
            this.pBresenham.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pDDA
            // 
            this.pDDA.BackColor = System.Drawing.Color.White;
            this.pDDA.Location = new System.Drawing.Point(492, 48);
            this.pDDA.Name = "pDDA";
            this.pDDA.Size = new System.Drawing.Size(436, 278);
            this.pDDA.TabIndex = 1;
            this.pDDA.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pCircle
            // 
            this.pCircle.BackColor = System.Drawing.Color.White;
            this.pCircle.Location = new System.Drawing.Point(965, 48);
            this.pCircle.Name = "pCircle";
            this.pCircle.Size = new System.Drawing.Size(435, 623);
            this.pCircle.TabIndex = 3;
            this.pCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pWu
            // 
            this.pWu.BackColor = System.Drawing.Color.White;
            this.pWu.Location = new System.Drawing.Point(492, 393);
            this.pWu.Name = "pWu";
            this.pWu.Size = new System.Drawing.Size(436, 278);
            this.pWu.TabIndex = 2;
            this.pWu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pNaive
            // 
            this.pNaive.BackColor = System.Drawing.Color.White;
            this.pNaive.Location = new System.Drawing.Point(25, 393);
            this.pNaive.Name = "pNaive";
            this.pNaive.Size = new System.Drawing.Size(436, 278);
            this.pNaive.TabIndex = 4;
            this.pNaive.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // nYa
            // 
            this.nYa.Location = new System.Drawing.Point(105, 755);
            this.nYa.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nYa.Name = "nYa";
            this.nYa.Size = new System.Drawing.Size(70, 27);
            this.nYa.TabIndex = 6;
            // 
            // nXa
            // 
            this.nXa.Location = new System.Drawing.Point(105, 722);
            this.nXa.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nXa.Name = "nXa";
            this.nXa.Size = new System.Drawing.Size(70, 27);
            this.nXa.TabIndex = 7;
            // 
            // nXb
            // 
            this.nXb.Location = new System.Drawing.Point(232, 722);
            this.nXb.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nXb.Name = "nXb";
            this.nXb.Size = new System.Drawing.Size(70, 27);
            this.nXb.TabIndex = 8;
            // 
            // nYb
            // 
            this.nYb.Location = new System.Drawing.Point(232, 755);
            this.nYb.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nYb.Name = "nYb";
            this.nYb.Size = new System.Drawing.Size(70, 27);
            this.nYb.TabIndex = 9;
            // 
            // bLine
            // 
            this.bLine.Location = new System.Drawing.Point(338, 720);
            this.bLine.Name = "bLine";
            this.bLine.Size = new System.Drawing.Size(88, 61);
            this.bLine.TabIndex = 10;
            this.bLine.Text = "Rasterize line";
            this.bLine.UseVisualStyleBackColor = true;
            this.bLine.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bresenham algorithm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "DDA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Wu algorithm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Naive algorithm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(965, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Bresenham algorithm for circle";
            // 
            // bCircle
            // 
            this.bCircle.Location = new System.Drawing.Point(1247, 722);
            this.bCircle.Name = "bCircle";
            this.bCircle.Size = new System.Drawing.Size(94, 57);
            this.bCircle.TabIndex = 21;
            this.bCircle.Text = "Rasterize circle";
            this.bCircle.UseVisualStyleBackColor = true;
            this.bCircle.Click += new System.EventHandler(this.button2_Click);
            // 
            // nCenterX
            // 
            this.nCenterX.Location = new System.Drawing.Point(1043, 723);
            this.nCenterX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nCenterX.Name = "nCenterX";
            this.nCenterX.Size = new System.Drawing.Size(63, 27);
            this.nCenterX.TabIndex = 18;
            // 
            // nRadius
            // 
            this.nRadius.Location = new System.Drawing.Point(1145, 723);
            this.nRadius.Name = "nRadius";
            this.nRadius.Size = new System.Drawing.Size(72, 27);
            this.nRadius.TabIndex = 17;
            // 
            // nScale
            // 
            this.nScale.Location = new System.Drawing.Point(596, 738);
            this.nScale.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nScale.Name = "nScale";
            this.nScale.Size = new System.Drawing.Size(109, 27);
            this.nScale.TabIndex = 22;
            this.nScale.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 740);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Scale";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 724);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "X0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 757);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Y0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 724);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "X1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(200, 757);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Y1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1000, 697);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Circle center";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1153, 697);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Radius";
            // 
            // bScale
            // 
            this.bScale.Location = new System.Drawing.Point(739, 736);
            this.bScale.Name = "bScale";
            this.bScale.Size = new System.Drawing.Size(123, 29);
            this.bScale.TabIndex = 30;
            this.bScale.Text = "Change scale";
            this.bScale.UseVisualStyleBackColor = true;
            this.bScale.Click += new System.EventHandler(this.button3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(185, 699);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "Point B";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(53, 699);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "Point A";
            // 
            // nCenterY
            // 
            this.nCenterY.Location = new System.Drawing.Point(1043, 757);
            this.nCenterY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nCenterY.Name = "nCenterY";
            this.nCenterY.Size = new System.Drawing.Size(63, 27);
            this.nCenterY.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(998, 759);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Y0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(997, 725);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 20);
            this.label18.TabIndex = 36;
            this.label18.Text = "X0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label19.Location = new System.Drawing.Point(272, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 20);
            this.label19.TabIndex = 38;
            this.label19.Text = "Execution, ms:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label21.Location = new System.Drawing.Point(726, 363);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 20);
            this.label21.TabIndex = 41;
            this.label21.Text = "Execution, ms:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label22.Location = new System.Drawing.Point(726, 19);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(102, 20);
            this.label22.TabIndex = 40;
            this.label22.Text = "Execution, ms:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label23.Location = new System.Drawing.Point(1206, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(102, 20);
            this.label23.TabIndex = 43;
            this.label23.Text = "Execution, ms:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label24.Location = new System.Drawing.Point(266, 364);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(102, 20);
            this.label24.TabIndex = 42;
            this.label24.Text = "Execution, ms:";
            // 
            // tbBresenham
            // 
            this.tbBresenham.Location = new System.Drawing.Point(380, 14);
            this.tbBresenham.Name = "tbBresenham";
            this.tbBresenham.ReadOnly = true;
            this.tbBresenham.Size = new System.Drawing.Size(80, 27);
            this.tbBresenham.TabIndex = 44;
            // 
            // tbDDA
            // 
            this.tbDDA.Location = new System.Drawing.Point(847, 14);
            this.tbDDA.Name = "tbDDA";
            this.tbDDA.ReadOnly = true;
            this.tbDDA.Size = new System.Drawing.Size(80, 27);
            this.tbDDA.TabIndex = 46;
            // 
            // tbWu
            // 
            this.tbWu.Location = new System.Drawing.Point(847, 358);
            this.tbWu.Name = "tbWu";
            this.tbWu.ReadOnly = true;
            this.tbWu.Size = new System.Drawing.Size(80, 27);
            this.tbWu.TabIndex = 47;
            // 
            // tbNaive
            // 
            this.tbNaive.Location = new System.Drawing.Point(380, 359);
            this.tbNaive.Name = "tbNaive";
            this.tbNaive.ReadOnly = true;
            this.tbNaive.Size = new System.Drawing.Size(80, 27);
            this.tbNaive.TabIndex = 48;
            // 
            // tbCircle
            // 
            this.tbCircle.Location = new System.Drawing.Point(1320, 15);
            this.tbCircle.Name = "tbCircle";
            this.tbCircle.ReadOnly = true;
            this.tbCircle.Size = new System.Drawing.Size(80, 27);
            this.tbCircle.TabIndex = 49;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 808);
            this.splitter1.TabIndex = 50;
            this.splitter1.TabStop = false;
            // 
            // vsbCircle
            // 
            this.vsbCircle.Location = new System.Drawing.Point(1403, 48);
            this.vsbCircle.Maximum = 50;
            this.vsbCircle.Minimum = -50;
            this.vsbCircle.Name = "vsbCircle";
            this.vsbCircle.Size = new System.Drawing.Size(16, 623);
            this.vsbCircle.TabIndex = 51;
            this.vsbCircle.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollCircle_Scroll);
            // 
            // vsbBreseham
            // 
            this.vsbBreseham.Location = new System.Drawing.Point(463, 48);
            this.vsbBreseham.Maximum = 50;
            this.vsbBreseham.Minimum = -50;
            this.vsbBreseham.Name = "vsbBreseham";
            this.vsbBreseham.Size = new System.Drawing.Size(16, 278);
            this.vsbBreseham.TabIndex = 52;
            this.vsbBreseham.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbBreseham_Scroll);
            // 
            // vsbNaive
            // 
            this.vsbNaive.Location = new System.Drawing.Point(463, 393);
            this.vsbNaive.Maximum = 50;
            this.vsbNaive.Minimum = -50;
            this.vsbNaive.Name = "vsbNaive";
            this.vsbNaive.Size = new System.Drawing.Size(16, 278);
            this.vsbNaive.TabIndex = 53;
            this.vsbNaive.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbNaive_Scroll);
            // 
            // vsbWu
            // 
            this.vsbWu.Location = new System.Drawing.Point(931, 393);
            this.vsbWu.Maximum = 50;
            this.vsbWu.Minimum = -50;
            this.vsbWu.Name = "vsbWu";
            this.vsbWu.Size = new System.Drawing.Size(16, 278);
            this.vsbWu.TabIndex = 54;
            this.vsbWu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbWu_Scroll);
            // 
            // vsbDDA
            // 
            this.vsbDDA.Location = new System.Drawing.Point(931, 48);
            this.vsbDDA.Maximum = 50;
            this.vsbDDA.Minimum = -50;
            this.vsbDDA.Name = "vsbDDA";
            this.vsbDDA.Size = new System.Drawing.Size(16, 278);
            this.vsbDDA.TabIndex = 55;
            this.vsbDDA.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbDDA_Scroll);
            // 
            // hsbBresenham
            // 
            this.hsbBresenham.Location = new System.Drawing.Point(25, 329);
            this.hsbBresenham.Maximum = 50;
            this.hsbBresenham.Minimum = -50;
            this.hsbBresenham.Name = "hsbBresenham";
            this.hsbBresenham.Size = new System.Drawing.Size(436, 12);
            this.hsbBresenham.TabIndex = 56;
            this.hsbBresenham.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbBreseham_Scroll);
            // 
            // hsbDDA
            // 
            this.hsbDDA.Location = new System.Drawing.Point(491, 329);
            this.hsbDDA.Maximum = 50;
            this.hsbDDA.Minimum = -50;
            this.hsbDDA.Name = "hsbDDA";
            this.hsbDDA.Size = new System.Drawing.Size(436, 12);
            this.hsbDDA.TabIndex = 57;
            this.hsbDDA.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbDDA_Scroll);
            // 
            // hsbNaive
            // 
            this.hsbNaive.Location = new System.Drawing.Point(24, 674);
            this.hsbNaive.Maximum = 50;
            this.hsbNaive.Minimum = -50;
            this.hsbNaive.Name = "hsbNaive";
            this.hsbNaive.Size = new System.Drawing.Size(436, 12);
            this.hsbNaive.TabIndex = 58;
            this.hsbNaive.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbNaive_Scroll);
            // 
            // hsbWu
            // 
            this.hsbWu.Location = new System.Drawing.Point(492, 674);
            this.hsbWu.Maximum = 50;
            this.hsbWu.Minimum = -50;
            this.hsbWu.Name = "hsbWu";
            this.hsbWu.Size = new System.Drawing.Size(436, 12);
            this.hsbWu.TabIndex = 59;
            this.hsbWu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbWu_Scroll);
            // 
            // hsbCircle
            // 
            this.hsbCircle.Location = new System.Drawing.Point(964, 674);
            this.hsbCircle.Maximum = 50;
            this.hsbCircle.Minimum = -50;
            this.hsbCircle.Name = "hsbCircle";
            this.hsbCircle.Size = new System.Drawing.Size(436, 12);
            this.hsbCircle.TabIndex = 60;
            this.hsbCircle.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollCircle_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 808);
            this.Controls.Add(this.hsbCircle);
            this.Controls.Add(this.hsbWu);
            this.Controls.Add(this.hsbNaive);
            this.Controls.Add(this.hsbDDA);
            this.Controls.Add(this.hsbBresenham);
            this.Controls.Add(this.vsbDDA);
            this.Controls.Add(this.vsbWu);
            this.Controls.Add(this.vsbNaive);
            this.Controls.Add(this.vsbBreseham);
            this.Controls.Add(this.vsbCircle);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tbCircle);
            this.Controls.Add(this.tbNaive);
            this.Controls.Add(this.tbWu);
            this.Controls.Add(this.tbDDA);
            this.Controls.Add(this.tbBresenham);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.nCenterY);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.bScale);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nScale);
            this.Controls.Add(this.bCircle);
            this.Controls.Add(this.nCenterX);
            this.Controls.Add(this.nRadius);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bLine);
            this.Controls.Add(this.nYb);
            this.Controls.Add(this.nXb);
            this.Controls.Add(this.nXa);
            this.Controls.Add(this.nYa);
            this.Controls.Add(this.pNaive);
            this.Controls.Add(this.pCircle);
            this.Controls.Add(this.pWu);
            this.Controls.Add(this.pDDA);
            this.Controls.Add(this.pBresenham);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rasterizer Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.nYa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCenterX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCenterY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pBresenham;
        private System.Windows.Forms.Panel pDDA;
        private System.Windows.Forms.Panel pCircle;
        private System.Windows.Forms.Panel pWu;
        private System.Windows.Forms.Panel pNaive;
        private System.Windows.Forms.NumericUpDown nYa;
        private System.Windows.Forms.NumericUpDown nXa;
        private System.Windows.Forms.NumericUpDown nXb;
        private System.Windows.Forms.NumericUpDown nYb;
        private System.Windows.Forms.Button bLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bCircle;
        private System.Windows.Forms.NumericUpDown nCenterX;
        private System.Windows.Forms.NumericUpDown nRadius;
        private System.Windows.Forms.NumericUpDown nScale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bScale;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nCenterY;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbBresenham;
        private System.Windows.Forms.TextBox tbDDA;
        private System.Windows.Forms.TextBox tbWu;
        private System.Windows.Forms.TextBox tbNaive;
        private System.Windows.Forms.TextBox tbCircle;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.VScrollBar vsbCircle;
        private System.Windows.Forms.VScrollBar vsbBreseham;
        private System.Windows.Forms.VScrollBar vsbNaive;
        private System.Windows.Forms.VScrollBar vsbWu;
        private System.Windows.Forms.VScrollBar vsbDDA;
        private System.Windows.Forms.HScrollBar hsbBresenham;
        private System.Windows.Forms.HScrollBar hsbDDA;
        private System.Windows.Forms.HScrollBar hsbNaive;
        private System.Windows.Forms.HScrollBar hsbWu;
        private System.Windows.Forms.HScrollBar hsbCircle;
    }
}

