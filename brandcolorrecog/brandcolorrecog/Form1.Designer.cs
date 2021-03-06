﻿namespace brandcolorrecog
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.test1Btn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pannonLogo = new System.Windows.Forms.PictureBox();
            this.startBox = new System.Windows.Forms.GroupBox();
            this.resoWarningPic = new System.Windows.Forms.PictureBox();
            this.resoWarning = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.control = new System.Windows.Forms.GroupBox();
            this.testFrame = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.picture6 = new System.Windows.Forms.RadioButton();
            this.picture5 = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picture4 = new System.Windows.Forms.RadioButton();
            this.picture1 = new System.Windows.Forms.RadioButton();
            this.picture3 = new System.Windows.Forms.RadioButton();
            this.picture2 = new System.Windows.Forms.RadioButton();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.coloringBox = new System.Windows.Forms.GroupBox();
            this.colorBtn = new System.Windows.Forms.Button();
            this.colors = new System.Windows.Forms.ColorDialog();
            this.registerBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.occup_textBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.ageTrackBar = new System.Windows.Forms.TrackBar();
            this.isFilled = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.schoolBox = new System.Windows.Forms.ComboBox();
            this.nat_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pannonLogo)).BeginInit();
            this.startBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resoWarningPic)).BeginInit();
            this.control.SuspendLayout();
            this.testFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.coloringBox.SuspendLayout();
            this.registerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // test1Btn
            // 
            this.test1Btn.Location = new System.Drawing.Point(7, 26);
            this.test1Btn.Name = "test1Btn";
            this.test1Btn.Size = new System.Drawing.Size(120, 48);
            this.test1Btn.TabIndex = 0;
            this.test1Btn.Text = "TEST";
            this.test1Btn.UseVisualStyleBackColor = true;
            this.test1Btn.Click += new System.EventHandler(this.test1Btn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(7, 142);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(120, 48);
            this.aboutBtn.TabIndex = 2;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(7, 215);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(120, 48);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pannonLogo
            // 
            this.pannonLogo.Image = ((System.Drawing.Image)(resources.GetObject("pannonLogo.Image")));
            this.pannonLogo.Location = new System.Drawing.Point(156, 26);
            this.pannonLogo.Name = "pannonLogo";
            this.pannonLogo.Size = new System.Drawing.Size(242, 237);
            this.pannonLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pannonLogo.TabIndex = 4;
            this.pannonLogo.TabStop = false;
            this.pannonLogo.Click += new System.EventHandler(this.pannonLogo_Click);
            // 
            // startBox
            // 
            this.startBox.Controls.Add(this.resoWarningPic);
            this.startBox.Controls.Add(this.resoWarning);
            this.startBox.Controls.Add(this.pannonLogo);
            this.startBox.Controls.Add(this.exitBtn);
            this.startBox.Controls.Add(this.aboutBtn);
            this.startBox.Controls.Add(this.test1Btn);
            this.startBox.Location = new System.Drawing.Point(12, 12);
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(407, 282);
            this.startBox.TabIndex = 5;
            this.startBox.TabStop = false;
            // 
            // resoWarningPic
            // 
            this.resoWarningPic.Image = ((System.Drawing.Image)(resources.GetObject("resoWarningPic.Image")));
            this.resoWarningPic.Location = new System.Drawing.Point(6, 80);
            this.resoWarningPic.Name = "resoWarningPic";
            this.resoWarningPic.Size = new System.Drawing.Size(20, 19);
            this.resoWarningPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resoWarningPic.TabIndex = 6;
            this.resoWarningPic.TabStop = false;
            // 
            // resoWarning
            // 
            this.resoWarning.AutoSize = true;
            this.resoWarning.ForeColor = System.Drawing.Color.Red;
            this.resoWarning.Location = new System.Drawing.Point(26, 84);
            this.resoWarning.Name = "resoWarning";
            this.resoWarning.Size = new System.Drawing.Size(115, 13);
            this.resoWarning.TabIndex = 5;
            this.resoWarning.Text = "Please use 1920x1080";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(125, 22);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(50, 50);
            this.reset.TabIndex = 6;
            this.reset.Text = "X";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(69, 22);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(50, 50);
            this.next.TabIndex = 7;
            this.next.Text = ">";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.Location = new System.Drawing.Point(13, 22);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(50, 50);
            this.help.TabIndex = 8;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // control
            // 
            this.control.Controls.Add(this.help);
            this.control.Controls.Add(this.next);
            this.control.Controls.Add(this.reset);
            this.control.Location = new System.Drawing.Point(537, 185);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(191, 89);
            this.control.TabIndex = 9;
            this.control.TabStop = false;
            this.control.Text = "Help / Next / Reset";
            // 
            // testFrame
            // 
            this.testFrame.Controls.Add(this.pictureBox5);
            this.testFrame.Controls.Add(this.pictureBox6);
            this.testFrame.Controls.Add(this.picture6);
            this.testFrame.Controls.Add(this.picture5);
            this.testFrame.Controls.Add(this.pictureBox4);
            this.testFrame.Controls.Add(this.pictureBox3);
            this.testFrame.Controls.Add(this.pictureBox2);
            this.testFrame.Controls.Add(this.pictureBox1);
            this.testFrame.Controls.Add(this.picture4);
            this.testFrame.Controls.Add(this.picture1);
            this.testFrame.Controls.Add(this.picture3);
            this.testFrame.Controls.Add(this.picture2);
            this.testFrame.Location = new System.Drawing.Point(14, 303);
            this.testFrame.Name = "testFrame";
            this.testFrame.Size = new System.Drawing.Size(984, 427);
            this.testFrame.TabIndex = 10;
            this.testFrame.TabStop = false;
            this.testFrame.Text = "id: testFrame";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(708, 224);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(270, 170);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(708, 19);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(270, 170);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // picture6
            // 
            this.picture6.AutoSize = true;
            this.picture6.Location = new System.Drawing.Point(842, 398);
            this.picture6.Name = "picture6";
            this.picture6.Size = new System.Drawing.Size(14, 13);
            this.picture6.TabIndex = 9;
            this.picture6.TabStop = true;
            this.picture6.UseVisualStyleBackColor = true;
            this.picture6.CheckedChanged += new System.EventHandler(this.picture6_CheckedChanged);
            // 
            // picture5
            // 
            this.picture5.AutoSize = true;
            this.picture5.Location = new System.Drawing.Point(842, 195);
            this.picture5.Name = "picture5";
            this.picture5.Size = new System.Drawing.Size(14, 13);
            this.picture5.TabIndex = 8;
            this.picture5.TabStop = true;
            this.picture5.UseVisualStyleBackColor = true;
            this.picture5.CheckedChanged += new System.EventHandler(this.picture5_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(374, 222);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(270, 170);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(45, 224);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(270, 170);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(374, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 170);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 170);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picture4
            // 
            this.picture4.AutoSize = true;
            this.picture4.Location = new System.Drawing.Point(545, 398);
            this.picture4.Name = "picture4";
            this.picture4.Size = new System.Drawing.Size(14, 13);
            this.picture4.TabIndex = 3;
            this.picture4.TabStop = true;
            this.picture4.UseVisualStyleBackColor = true;
            this.picture4.CheckedChanged += new System.EventHandler(this.picture4_CheckedChanged);
            // 
            // picture1
            // 
            this.picture1.AutoSize = true;
            this.picture1.Location = new System.Drawing.Point(171, 195);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(14, 13);
            this.picture1.TabIndex = 0;
            this.picture1.TabStop = true;
            this.picture1.UseVisualStyleBackColor = true;
            this.picture1.CheckedChanged += new System.EventHandler(this.picture1_CheckedChanged);
            // 
            // picture3
            // 
            this.picture3.AutoSize = true;
            this.picture3.Location = new System.Drawing.Point(171, 398);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(14, 13);
            this.picture3.TabIndex = 2;
            this.picture3.TabStop = true;
            this.picture3.UseVisualStyleBackColor = true;
            this.picture3.CheckedChanged += new System.EventHandler(this.picture3_CheckedChanged);
            // 
            // picture2
            // 
            this.picture2.AutoSize = true;
            this.picture2.Location = new System.Drawing.Point(545, 195);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(14, 13);
            this.picture2.TabIndex = 1;
            this.picture2.TabStop = true;
            this.picture2.UseVisualStyleBackColor = true;
            this.picture2.CheckedChanged += new System.EventHandler(this.picture2_CheckedChanged);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(437, 12);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(1500, 25);
            this.progress.TabIndex = 0;
            // 
            // coloringBox
            // 
            this.coloringBox.Controls.Add(this.colorBtn);
            this.coloringBox.Location = new System.Drawing.Point(734, 55);
            this.coloringBox.Name = "coloringBox";
            this.coloringBox.Size = new System.Drawing.Size(475, 202);
            this.coloringBox.TabIndex = 11;
            this.coloringBox.TabStop = false;
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(15, 23);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(41, 32);
            this.colorBtn.TabIndex = 0;
            this.colorBtn.Text = "Color";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // colors
            // 
            this.colors.AnyColor = true;
            this.colors.ShowHelp = true;
            // 
            // registerBox
            // 
            this.registerBox.Controls.Add(this.label5);
            this.registerBox.Controls.Add(this.occup_textBox);
            this.registerBox.Controls.Add(this.ageBox);
            this.registerBox.Controls.Add(this.ageTrackBar);
            this.registerBox.Controls.Add(this.isFilled);
            this.registerBox.Controls.Add(this.label4);
            this.registerBox.Controls.Add(this.label3);
            this.registerBox.Controls.Add(this.label2);
            this.registerBox.Controls.Add(this.label1);
            this.registerBox.Controls.Add(this.registerBtn);
            this.registerBox.Controls.Add(this.schoolBox);
            this.registerBox.Controls.Add(this.nat_textBox);
            this.registerBox.Controls.Add(this.name_textBox);
            this.registerBox.Location = new System.Drawing.Point(1018, 292);
            this.registerBox.Name = "registerBox";
            this.registerBox.Size = new System.Drawing.Size(314, 438);
            this.registerBox.TabIndex = 12;
            this.registerBox.TabStop = false;
            this.registerBox.Text = "New Test User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Occupation";
            // 
            // occup_textBox
            // 
            this.occup_textBox.Location = new System.Drawing.Point(28, 337);
            this.occup_textBox.Name = "occup_textBox";
            this.occup_textBox.Size = new System.Drawing.Size(168, 20);
            this.occup_textBox.TabIndex = 12;
            // 
            // ageBox
            // 
            this.ageBox.Enabled = false;
            this.ageBox.Location = new System.Drawing.Point(93, 232);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(49, 20);
            this.ageBox.TabIndex = 11;
            this.ageBox.TextChanged += new System.EventHandler(this.ageBox_TextChanged);
            // 
            // ageTrackBar
            // 
            this.ageTrackBar.Location = new System.Drawing.Point(28, 265);
            this.ageTrackBar.Maximum = 38;
            this.ageTrackBar.Minimum = 18;
            this.ageTrackBar.Name = "ageTrackBar";
            this.ageTrackBar.Size = new System.Drawing.Size(239, 45);
            this.ageTrackBar.TabIndex = 10;
            this.ageTrackBar.Value = 20;
            this.ageTrackBar.ValueChanged += new System.EventHandler(this.ageTrackBar_ValueChanged);
            // 
            // isFilled
            // 
            this.isFilled.AutoSize = true;
            this.isFilled.Location = new System.Drawing.Point(38, 400);
            this.isFilled.Name = "isFilled";
            this.isFilled.Size = new System.Drawing.Size(67, 17);
            this.isFilled.TabIndex = 9;
            this.isFilled.Text = "All filled?";
            this.isFilled.UseVisualStyleBackColor = true;
            this.isFilled.CheckedChanged += new System.EventHandler(this.isFilled_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age (18-38)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Faculty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nationality";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(143, 393);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(135, 29);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "OK";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // schoolBox
            // 
            this.schoolBox.FormattingEnabled = true;
            this.schoolBox.Items.AddRange(new object[] {
            "PE MIK",
            "PE MK",
            "PE GTK",
            "PE MFTK",
            "ERASMUS (foreign student)",
            "non-university student"});
            this.schoolBox.Location = new System.Drawing.Point(28, 118);
            this.schoolBox.Name = "schoolBox";
            this.schoolBox.Size = new System.Drawing.Size(168, 21);
            this.schoolBox.TabIndex = 3;
            this.schoolBox.SelectedIndexChanged += new System.EventHandler(this.schoolBox_SelectedIndexChanged);
            // 
            // nat_textBox
            // 
            this.nat_textBox.Location = new System.Drawing.Point(28, 180);
            this.nat_textBox.Name = "nat_textBox";
            this.nat_textBox.Size = new System.Drawing.Size(168, 20);
            this.nat_textBox.TabIndex = 2;
            this.nat_textBox.TextChanged += new System.EventHandler(this.nat_textBox_TextChanged);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(28, 58);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(168, 20);
            this.name_textBox.TabIndex = 1;
            this.name_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 976);
            this.Controls.Add(this.registerBox);
            this.Controls.Add(this.coloringBox);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.testFrame);
            this.Controls.Add(this.control);
            this.Controls.Add(this.startBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainMenu";
            this.ShowIcon = false;
            this.Text = "Color Memory Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pannonLogo)).EndInit();
            this.startBox.ResumeLayout(false);
            this.startBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resoWarningPic)).EndInit();
            this.control.ResumeLayout(false);
            this.testFrame.ResumeLayout(false);
            this.testFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.coloringBox.ResumeLayout(false);
            this.registerBox.ResumeLayout(false);
            this.registerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button test1Btn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pannonLogo;
        private System.Windows.Forms.GroupBox startBox;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.GroupBox control;
        private System.Windows.Forms.GroupBox testFrame;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton picture4;
        private System.Windows.Forms.RadioButton picture3;
        private System.Windows.Forms.RadioButton picture2;
        private System.Windows.Forms.RadioButton picture1;
        private System.Windows.Forms.PictureBox resoWarningPic;
        private System.Windows.Forms.Label resoWarning;
        private System.Windows.Forms.GroupBox coloringBox;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.ColorDialog colors;
        private System.Windows.Forms.GroupBox registerBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.ComboBox schoolBox;
        private System.Windows.Forms.TextBox nat_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox isFilled;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.RadioButton picture6;
        private System.Windows.Forms.RadioButton picture5;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TrackBar ageTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox occup_textBox;
    }
}

