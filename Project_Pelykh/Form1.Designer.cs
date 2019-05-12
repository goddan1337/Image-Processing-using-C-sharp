namespace Project_Pelykh
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnSave = new System.Windows.Forms.Button();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.sourcePictureBox = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabCt = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnInvert = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.labelTh = new System.Windows.Forms.Label();
            this.BinScroll = new System.Windows.Forms.HScrollBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelCntrst = new System.Windows.Forms.Label();
            this.ContrastScroll = new System.Windows.Forms.HScrollBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.OK = new System.Windows.Forms.Button();
            this.BilinearBox = new System.Windows.Forms.CheckBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tbrB = new System.Windows.Forms.HScrollBar();
            this.tbrR = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tbrG = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnBoth = new System.Windows.Forms.Button();
            this.btnVertical = new System.Windows.Forms.Button();
            this.btnHorizontal = new System.Windows.Forms.Button();
            this.MainHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.labelBright = new System.Windows.Forms.Label();
            this.BrightnessScroll = new System.Windows.Forms.HScrollBar();
            this.SelectedColor = new System.Windows.Forms.PictureBox();
            this.BlueSelection = new System.Windows.Forms.HScrollBar();
            this.GreenSelection = new System.Windows.Forms.HScrollBar();
            this.RedSelection = new System.Windows.Forms.HScrollBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabCt.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainHistogram)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedColor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(94, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Location = new System.Drawing.Point(298, 47);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(266, 266);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultPictureBox.TabIndex = 11;
            this.resultPictureBox.TabStop = false;
            // 
            // sourcePictureBox
            // 
            this.sourcePictureBox.Location = new System.Drawing.Point(13, 47);
            this.sourcePictureBox.Name = "sourcePictureBox";
            this.sourcePictureBox.Size = new System.Drawing.Size(266, 266);
            this.sourcePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourcePictureBox.TabIndex = 10;
            this.sourcePictureBox.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(13, 10);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.Text = "Select file";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 321);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1025, 218);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabCt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1017, 192);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabCt
            // 
            this.tabCt.Controls.Add(this.tabPage6);
            this.tabCt.Controls.Add(this.tabPage7);
            this.tabCt.Controls.Add(this.tabPage8);
            this.tabCt.Controls.Add(this.tabPage2);
            this.tabCt.Controls.Add(this.tabPage9);
            this.tabCt.Location = new System.Drawing.Point(3, 3);
            this.tabCt.Name = "tabCt";
            this.tabCt.SelectedIndex = 0;
            this.tabCt.Size = new System.Drawing.Size(449, 189);
            this.tabCt.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnGrayscale);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(441, 163);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Grayscale";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.Location = new System.Drawing.Point(15, 17);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(131, 23);
            this.btnGrayscale.TabIndex = 1;
            this.btnGrayscale.Text = "Simple Grayscale";
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnInvert);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(252, 163);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Invert";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnInvert
            // 
            this.btnInvert.Location = new System.Drawing.Point(15, 17);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(75, 23);
            this.btnInvert.TabIndex = 2;
            this.btnInvert.Text = "Invert";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.labelTh);
            this.tabPage8.Controls.Add(this.BinScroll);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(441, 163);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "Binarization";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // labelTh
            // 
            this.labelTh.AutoSize = true;
            this.labelTh.Location = new System.Drawing.Point(80, 9);
            this.labelTh.Name = "labelTh";
            this.labelTh.Size = new System.Drawing.Size(83, 13);
            this.labelTh.TabIndex = 28;
            this.labelTh.Text = "Color threshold: ";
            // 
            // BinScroll
            // 
            this.BinScroll.Location = new System.Drawing.Point(27, 35);
            this.BinScroll.Maximum = 256;
            this.BinScroll.Name = "BinScroll";
            this.BinScroll.Size = new System.Drawing.Size(200, 18);
            this.BinScroll.TabIndex = 1;
            this.BinScroll.Value = 100;
            this.BinScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BinScroll_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelCntrst);
            this.tabPage2.Controls.Add(this.ContrastScroll);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(441, 163);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Contrast";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelCntrst
            // 
            this.labelCntrst.AutoSize = true;
            this.labelCntrst.Location = new System.Drawing.Point(80, 9);
            this.labelCntrst.Name = "labelCntrst";
            this.labelCntrst.Size = new System.Drawing.Size(49, 13);
            this.labelCntrst.TabIndex = 29;
            this.labelCntrst.Text = "Contrast:";
            // 
            // ContrastScroll
            // 
            this.ContrastScroll.Location = new System.Drawing.Point(27, 35);
            this.ContrastScroll.Maximum = 256;
            this.ContrastScroll.Name = "ContrastScroll";
            this.ContrastScroll.Size = new System.Drawing.Size(200, 18);
            this.ContrastScroll.TabIndex = 2;
            this.ContrastScroll.Value = 100;
            this.ContrastScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ContrastScroll_Scroll);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.OK);
            this.tabPage3.Controls.Add(this.BilinearBox);
            this.tabPage3.Controls.Add(this.HeightBox);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.WidthBox);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1017, 192);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Resize";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(63, 118);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(48, 23);
            this.OK.TabIndex = 12;
            this.OK.Text = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // BilinearBox
            // 
            this.BilinearBox.Location = new System.Drawing.Point(38, 88);
            this.BilinearBox.Name = "BilinearBox";
            this.BilinearBox.Size = new System.Drawing.Size(96, 24);
            this.BilinearBox.TabIndex = 11;
            this.BilinearBox.Text = "Bilinear Filter";
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(78, 56);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(56, 20);
            this.HeightBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(30, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Height";
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(78, 24);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(56, 20);
            this.WidthBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(30, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Width";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1017, 192);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Color";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "B:";
            // 
            // tbrB
            // 
            this.tbrB.Location = new System.Drawing.Point(92, 105);
            this.tbrB.Maximum = 128;
            this.tbrB.Name = "tbrB";
            this.tbrB.Size = new System.Drawing.Size(319, 18);
            this.tbrB.TabIndex = 2;
            this.tbrB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColorToGrayscale_Scroll);
            // 
            // tbrR
            // 
            this.tbrR.Location = new System.Drawing.Point(92, 51);
            this.tbrR.Maximum = 128;
            this.tbrR.Name = "tbrR";
            this.tbrR.Size = new System.Drawing.Size(319, 18);
            this.tbrR.TabIndex = 0;
            this.tbrR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColorToGrayscale_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "G:";
            // 
            // tbrG
            // 
            this.tbrG.Location = new System.Drawing.Point(92, 78);
            this.tbrG.Maximum = 128;
            this.tbrG.Name = "tbrG";
            this.tbrG.Size = new System.Drawing.Size(319, 18);
            this.tbrG.TabIndex = 1;
            this.tbrG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColorToGrayscale_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "R:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnBoth);
            this.tabPage5.Controls.Add(this.btnVertical);
            this.tabPage5.Controls.Add(this.btnHorizontal);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1017, 192);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Flip";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnBoth
            // 
            this.btnBoth.Location = new System.Drawing.Point(176, 23);
            this.btnBoth.Name = "btnBoth";
            this.btnBoth.Size = new System.Drawing.Size(75, 23);
            this.btnBoth.TabIndex = 2;
            this.btnBoth.Text = "Hor+Vert";
            this.btnBoth.UseVisualStyleBackColor = true;
            this.btnBoth.Click += new System.EventHandler(this.btnBoth_Click);
            // 
            // btnVertical
            // 
            this.btnVertical.Location = new System.Drawing.Point(95, 23);
            this.btnVertical.Name = "btnVertical";
            this.btnVertical.Size = new System.Drawing.Size(75, 23);
            this.btnVertical.TabIndex = 1;
            this.btnVertical.Text = "Vertical";
            this.btnVertical.UseVisualStyleBackColor = true;
            this.btnVertical.Click += new System.EventHandler(this.btnVertical_Click);
            // 
            // btnHorizontal
            // 
            this.btnHorizontal.Location = new System.Drawing.Point(14, 23);
            this.btnHorizontal.Name = "btnHorizontal";
            this.btnHorizontal.Size = new System.Drawing.Size(75, 23);
            this.btnHorizontal.TabIndex = 0;
            this.btnHorizontal.Text = "Horizontal";
            this.btnHorizontal.UseVisualStyleBackColor = true;
            this.btnHorizontal.Click += new System.EventHandler(this.btnHorizontal_Click);
            // 
            // MainHistogram
            // 
            chartArea4.Name = "ChartArea1";
            this.MainHistogram.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.MainHistogram.Legends.Add(legend4);
            this.MainHistogram.Location = new System.Drawing.Point(601, 47);
            this.MainHistogram.Name = "MainHistogram";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Histogram";
            this.MainHistogram.Series.Add(series4);
            this.MainHistogram.Size = new System.Drawing.Size(432, 268);
            this.MainHistogram.TabIndex = 14;
            this.MainHistogram.Text = "chart1";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(175, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.labelBright);
            this.tabPage9.Controls.Add(this.BrightnessScroll);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(441, 163);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "Brightness";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // labelBright
            // 
            this.labelBright.AutoSize = true;
            this.labelBright.Location = new System.Drawing.Point(80, 9);
            this.labelBright.Name = "labelBright";
            this.labelBright.Size = new System.Drawing.Size(59, 13);
            this.labelBright.TabIndex = 31;
            this.labelBright.Text = "Brightness:";
            // 
            // BrightnessScroll
            // 
            this.BrightnessScroll.Location = new System.Drawing.Point(27, 35);
            this.BrightnessScroll.Maximum = 256;
            this.BrightnessScroll.Minimum = -256;
            this.BrightnessScroll.Name = "BrightnessScroll";
            this.BrightnessScroll.Size = new System.Drawing.Size(200, 18);
            this.BrightnessScroll.TabIndex = 30;
            this.BrightnessScroll.Value = 100;
            this.BrightnessScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BrightnessScroll_Scroll);
            // 
            // SelectedColor
            // 
            this.SelectedColor.Location = new System.Drawing.Point(390, 51);
            this.SelectedColor.Name = "SelectedColor";
            this.SelectedColor.Size = new System.Drawing.Size(72, 72);
            this.SelectedColor.TabIndex = 31;
            this.SelectedColor.TabStop = false;
            // 
            // BlueSelection
            // 
            this.BlueSelection.Location = new System.Drawing.Point(39, 105);
            this.BlueSelection.Maximum = 256;
            this.BlueSelection.Name = "BlueSelection";
            this.BlueSelection.Size = new System.Drawing.Size(324, 18);
            this.BlueSelection.TabIndex = 30;
            this.BlueSelection.Value = 128;
            this.BlueSelection.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColorToColor_Scroll);
            // 
            // GreenSelection
            // 
            this.GreenSelection.Location = new System.Drawing.Point(39, 78);
            this.GreenSelection.Maximum = 256;
            this.GreenSelection.Name = "GreenSelection";
            this.GreenSelection.Size = new System.Drawing.Size(324, 18);
            this.GreenSelection.TabIndex = 29;
            this.GreenSelection.Value = 128;
            this.GreenSelection.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColorToColor_Scroll);
            // 
            // RedSelection
            // 
            this.RedSelection.Location = new System.Drawing.Point(39, 51);
            this.RedSelection.Maximum = 256;
            this.RedSelection.Name = "RedSelection";
            this.RedSelection.Size = new System.Drawing.Size(324, 18);
            this.RedSelection.TabIndex = 28;
            this.RedSelection.Value = 128;
            this.RedSelection.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColorToColor_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "B:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "G:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "R:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RedSelection);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.GreenSelection);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.BlueSelection);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.SelectedColor);
            this.groupBox1.Location = new System.Drawing.Point(524, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 162);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customize Colors";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbrR);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbrG);
            this.groupBox2.Controls.Add(this.tbrB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 162);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customize Grayscale:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 551);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.MainHistogram);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.sourcePictureBox);
            this.Controls.Add(this.btnOpen);
            this.MaximumSize = new System.Drawing.Size(1065, 590);
            this.MinimumSize = new System.Drawing.Size(1065, 590);
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabCt.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainHistogram)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedColor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.PictureBox sourcePictureBox;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainHistogram;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabControl tabCt;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.HScrollBar tbrB;
        private System.Windows.Forms.HScrollBar tbrG;
        private System.Windows.Forms.HScrollBar tbrR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.CheckBox BilinearBox;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBoth;
        private System.Windows.Forms.Button btnVertical;
        private System.Windows.Forms.Button btnHorizontal;
        private System.Windows.Forms.HScrollBar BinScroll;
        private System.Windows.Forms.Label labelTh;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelCntrst;
        private System.Windows.Forms.HScrollBar ContrastScroll;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Label labelBright;
        private System.Windows.Forms.HScrollBar BrightnessScroll;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox SelectedColor;
        private System.Windows.Forms.HScrollBar BlueSelection;
        private System.Windows.Forms.HScrollBar GreenSelection;
        private System.Windows.Forms.HScrollBar RedSelection;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

