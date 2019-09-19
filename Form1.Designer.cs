namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.SelectDialog = new System.Windows.Forms.Button();
            this.selectImages = new System.Windows.Forms.OpenFileDialog();
            this.rows = new System.Windows.Forms.NumericUpDown();
            this.Generate = new System.Windows.Forms.Button();
            this.saveList = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.vmir = new System.Windows.Forms.CheckBox();
            this.hmir = new System.Windows.Forms.CheckBox();
            this.offset = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.center = new System.Windows.Forms.RadioButton();
            this.leftbot = new System.Windows.Forms.RadioButton();
            this.righttop = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBottom = new System.Windows.Forms.NumericUpDown();
            this.TRight = new System.Windows.Forms.NumericUpDown();
            this.TTop = new System.Windows.Forms.NumericUpDown();
            this.TLeft = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.splitButton = new System.Windows.Forms.Button();
            this.splitH = new System.Windows.Forms.NumericUpDown();
            this.splitW = new System.Windows.Forms.NumericUpDown();
            this.ListSelect = new System.Windows.Forms.Button();
            this.selectListToSplit = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sheetgen = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.genY = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.genX = new System.Windows.Forms.NumericUpDown();
            this.genH = new System.Windows.Forms.NumericUpDown();
            this.genW = new System.Windows.Forms.NumericUpDown();
            this.reverseorder = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveGen = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grCol = new System.Windows.Forms.CheckBox();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLeft)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitW)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectDialog
            // 
            this.SelectDialog.AllowDrop = true;
            this.SelectDialog.Location = new System.Drawing.Point(11, 12);
            this.SelectDialog.Name = "SelectDialog";
            this.SelectDialog.Size = new System.Drawing.Size(172, 43);
            this.SelectDialog.TabIndex = 0;
            this.SelectDialog.Text = "Select images";
            this.SelectDialog.UseVisualStyleBackColor = true;
            this.SelectDialog.Click += new System.EventHandler(this.SelectDialog_Click);
            // 
            // selectImages
            // 
            this.selectImages.Filter = "Sprites(*.png;*.bmp;*.gif)|*.png;*.bmp;*.gif";
            this.selectImages.Multiselect = true;
            // 
            // rows
            // 
            this.rows.Location = new System.Drawing.Point(189, 30);
            this.rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(88, 20);
            this.rows.TabIndex = 1;
            this.rows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(11, 65);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(266, 31);
            this.Generate.TabIndex = 2;
            this.Generate.Text = "Create Sprite Sheet";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // saveList
            // 
            this.saveList.FileName = "List";
            this.saveList.Filter = "png(*.png)|*.png|bmp(*.bmp)|*.bmp|gif(*.gif)|*.gif";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rows:";
            // 
            // vmir
            // 
            this.vmir.AutoSize = true;
            this.vmir.Location = new System.Drawing.Point(12, 102);
            this.vmir.Name = "vmir";
            this.vmir.Size = new System.Drawing.Size(89, 17);
            this.vmir.TabIndex = 4;
            this.vmir.Text = "Vertical mirror";
            this.vmir.UseVisualStyleBackColor = true;
            // 
            // hmir
            // 
            this.hmir.AutoSize = true;
            this.hmir.Location = new System.Drawing.Point(12, 121);
            this.hmir.Name = "hmir";
            this.hmir.Size = new System.Drawing.Size(101, 17);
            this.hmir.TabIndex = 5;
            this.hmir.Text = "Horizontal mirror";
            this.hmir.UseVisualStyleBackColor = true;
            // 
            // offset
            // 
            this.offset.Location = new System.Drawing.Point(189, 102);
            this.offset.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.offset.Name = "offset";
            this.offset.Size = new System.Drawing.Size(88, 20);
            this.offset.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Offset:";
            // 
            // center
            // 
            this.center.AutoSize = true;
            this.center.Location = new System.Drawing.Point(106, 166);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(56, 17);
            this.center.TabIndex = 8;
            this.center.TabStop = true;
            this.center.Text = "Center";
            this.center.UseVisualStyleBackColor = true;
            // 
            // leftbot
            // 
            this.leftbot.AutoSize = true;
            this.leftbot.Checked = true;
            this.leftbot.Location = new System.Drawing.Point(19, 166);
            this.leftbot.Name = "leftbot";
            this.leftbot.Size = new System.Drawing.Size(79, 17);
            this.leftbot.TabIndex = 9;
            this.leftbot.TabStop = true;
            this.leftbot.Text = "Left Bottom";
            this.leftbot.UseVisualStyleBackColor = true;
            // 
            // righttop
            // 
            this.righttop.AutoSize = true;
            this.righttop.Location = new System.Drawing.Point(171, 166);
            this.righttop.Name = "righttop";
            this.righttop.Size = new System.Drawing.Size(72, 17);
            this.righttop.TabIndex = 10;
            this.righttop.TabStop = true;
            this.righttop.Text = "Right Top";
            this.righttop.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TBottom);
            this.groupBox1.Controls.Add(this.TRight);
            this.groupBox1.Controls.Add(this.TTop);
            this.groupBox1.Controls.Add(this.TLeft);
            this.groupBox1.Location = new System.Drawing.Point(288, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 182);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trimming";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bottom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Right";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Top";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Left";
            // 
            // TBottom
            // 
            this.TBottom.Location = new System.Drawing.Point(9, 151);
            this.TBottom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TBottom.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.TBottom.Name = "TBottom";
            this.TBottom.Size = new System.Drawing.Size(91, 20);
            this.TBottom.TabIndex = 10;
            // 
            // TRight
            // 
            this.TRight.Location = new System.Drawing.Point(9, 113);
            this.TRight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TRight.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.TRight.Name = "TRight";
            this.TRight.Size = new System.Drawing.Size(91, 20);
            this.TRight.TabIndex = 9;
            // 
            // TTop
            // 
            this.TTop.Location = new System.Drawing.Point(9, 70);
            this.TTop.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TTop.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.TTop.Name = "TTop";
            this.TTop.Size = new System.Drawing.Size(91, 20);
            this.TTop.TabIndex = 8;
            // 
            // TLeft
            // 
            this.TLeft.Location = new System.Drawing.Point(9, 29);
            this.TLeft.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TLeft.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.TLeft.Name = "TLeft";
            this.TLeft.Size = new System.Drawing.Size(91, 20);
            this.TLeft.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.splitButton);
            this.groupBox2.Controls.Add(this.splitH);
            this.groupBox2.Controls.Add(this.splitW);
            this.groupBox2.Controls.Add(this.ListSelect);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 52);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sprite List Spliter";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "x:";
            // 
            // splitButton
            // 
            this.splitButton.Location = new System.Drawing.Point(277, 19);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(100, 23);
            this.splitButton.TabIndex = 3;
            this.splitButton.Text = "Split";
            this.splitButton.UseVisualStyleBackColor = true;
            this.splitButton.Click += new System.EventHandler(this.splitButton_Click);
            // 
            // splitH
            // 
            this.splitH.Location = new System.Drawing.Point(216, 21);
            this.splitH.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.splitH.Name = "splitH";
            this.splitH.Size = new System.Drawing.Size(54, 20);
            this.splitH.TabIndex = 2;
            // 
            // splitW
            // 
            this.splitW.Location = new System.Drawing.Point(126, 21);
            this.splitW.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.splitW.Name = "splitW";
            this.splitW.Size = new System.Drawing.Size(63, 20);
            this.splitW.TabIndex = 1;
            // 
            // ListSelect
            // 
            this.ListSelect.AllowDrop = true;
            this.ListSelect.Location = new System.Drawing.Point(6, 19);
            this.ListSelect.Name = "ListSelect";
            this.ListSelect.Size = new System.Drawing.Size(95, 23);
            this.ListSelect.TabIndex = 0;
            this.ListSelect.Text = "Select Image";
            this.ListSelect.UseVisualStyleBackColor = true;
            this.ListSelect.Click += new System.EventHandler(this.ListSelect_Click);
            // 
            // selectListToSplit
            // 
            this.selectListToSplit.FileName = "openList";
            this.selectListToSplit.Filter = "spritelist|*.png;*.bmp";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.sheetgen);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.genY);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.genX);
            this.groupBox3.Controls.Add(this.genH);
            this.groupBox3.Controls.Add(this.genW);
            this.groupBox3.Location = new System.Drawing.Point(403, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 240);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sheet Creator";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Greed color:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(78, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(90, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(90, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "x";
            // 
            // sheetgen
            // 
            this.sheetgen.Location = new System.Drawing.Point(6, 207);
            this.sheetgen.Name = "sheetgen";
            this.sheetgen.Size = new System.Drawing.Size(98, 22);
            this.sheetgen.TabIndex = 4;
            this.sheetgen.Text = "Generate";
            this.sheetgen.UseVisualStyleBackColor = true;
            this.sheetgen.Click += new System.EventHandler(this.sheetgen_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "h";
            // 
            // genY
            // 
            this.genY.Location = new System.Drawing.Point(6, 151);
            this.genY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.genY.Name = "genY";
            this.genY.Size = new System.Drawing.Size(98, 20);
            this.genY.TabIndex = 3;
            this.genY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "w";
            // 
            // genX
            // 
            this.genX.Location = new System.Drawing.Point(6, 114);
            this.genX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.genX.Name = "genX";
            this.genX.Size = new System.Drawing.Size(98, 20);
            this.genX.TabIndex = 2;
            this.genX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // genH
            // 
            this.genH.Location = new System.Drawing.Point(6, 70);
            this.genH.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.genH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.genH.Name = "genH";
            this.genH.Size = new System.Drawing.Size(98, 20);
            this.genH.TabIndex = 1;
            this.genH.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // genW
            // 
            this.genW.Location = new System.Drawing.Point(6, 29);
            this.genW.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.genW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.genW.Name = "genW";
            this.genW.Size = new System.Drawing.Size(98, 20);
            this.genW.TabIndex = 0;
            this.genW.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // reverseorder
            // 
            this.reverseorder.AutoSize = true;
            this.reverseorder.Location = new System.Drawing.Point(12, 140);
            this.reverseorder.Name = "reverseorder";
            this.reverseorder.Size = new System.Drawing.Size(100, 17);
            this.reverseorder.TabIndex = 14;
            this.reverseorder.Text = "In reverse order";
            this.reverseorder.UseVisualStyleBackColor = true;
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Green;
            // 
            // saveGen
            // 
            this.saveGen.FileName = "SpriteSheet";
            this.saveGen.Filter = "Sprite(*.png;)|*.png;";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(231, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 20);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // grCol
            // 
            this.grCol.AutoSize = true;
            this.grCol.Location = new System.Drawing.Point(150, 128);
            this.grCol.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.grCol.Name = "grCol";
            this.grCol.Size = new System.Drawing.Size(84, 17);
            this.grCol.TabIndex = 19;
            this.grCol.Text = "Greed color:";
            this.grCol.UseVisualStyleBackColor = true;
            // 
            // colorDialog2
            // 
            this.colorDialog2.Color = System.Drawing.Color.Green;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 256);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grCol);
            this.Controls.Add(this.reverseorder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.righttop);
            this.Controls.Add(this.leftbot);
            this.Controls.Add(this.center);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.offset);
            this.Controls.Add(this.hmir);
            this.Controls.Add(this.vmir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.SelectDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sprite Sheet Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLeft)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitW)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectDialog;
        private System.Windows.Forms.OpenFileDialog selectImages;
        private System.Windows.Forms.NumericUpDown rows;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.SaveFileDialog saveList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox vmir;
        private System.Windows.Forms.CheckBox hmir;
        private System.Windows.Forms.NumericUpDown offset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton center;
        private System.Windows.Forms.RadioButton leftbot;
        private System.Windows.Forms.RadioButton righttop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown TBottom;
        private System.Windows.Forms.NumericUpDown TRight;
        private System.Windows.Forms.NumericUpDown TTop;
        private System.Windows.Forms.NumericUpDown TLeft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.NumericUpDown splitH;
        private System.Windows.Forms.NumericUpDown splitW;
        private System.Windows.Forms.Button ListSelect;
        private System.Windows.Forms.OpenFileDialog selectListToSplit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox reverseorder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button sheetgen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown genY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown genX;
        private System.Windows.Forms.NumericUpDown genH;
        private System.Windows.Forms.NumericUpDown genW;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.SaveFileDialog saveGen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox grCol;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

