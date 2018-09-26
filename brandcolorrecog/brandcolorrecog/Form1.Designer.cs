namespace brandcolorrecog
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
            this.reset = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.control = new System.Windows.Forms.GroupBox();
            this.testFrame = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picture4 = new System.Windows.Forms.RadioButton();
            this.picture1 = new System.Windows.Forms.RadioButton();
            this.picture3 = new System.Windows.Forms.RadioButton();
            this.picture2 = new System.Windows.Forms.RadioButton();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.resoWarning = new System.Windows.Forms.Label();
            this.resoWarningPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pannonLogo)).BeginInit();
            this.startBox.SuspendLayout();
            this.control.SuspendLayout();
            this.testFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resoWarningPic)).BeginInit();
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
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.reset.Location = new System.Drawing.Point(100, 16);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(42, 37);
            this.reset.TabIndex = 6;
            this.reset.Text = "X";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.next.Location = new System.Drawing.Point(52, 16);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(42, 37);
            this.next.TabIndex = 7;
            this.next.Text = ">";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.back.Location = new System.Drawing.Point(4, 16);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(42, 37);
            this.back.TabIndex = 8;
            this.back.Text = "<";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // control
            // 
            this.control.Controls.Add(this.back);
            this.control.Controls.Add(this.next);
            this.control.Controls.Add(this.reset);
            this.control.Location = new System.Drawing.Point(564, 204);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(154, 70);
            this.control.TabIndex = 9;
            this.control.TabStop = false;
            this.control.Text = "Back / Next / Reset";
            // 
            // testFrame
            // 
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
            this.testFrame.Size = new System.Drawing.Size(728, 427);
            this.testFrame.TabIndex = 10;
            this.testFrame.TabStop = false;
            this.testFrame.Text = "id: testFrame";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(411, 224);
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
            this.pictureBox2.Location = new System.Drawing.Point(411, 19);
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
            this.progress.Size = new System.Drawing.Size(681, 23);
            this.progress.TabIndex = 0;
            // 
            // resoWarning
            // 
            this.resoWarning.AutoSize = true;
            this.resoWarning.ForeColor = System.Drawing.Color.Red;
            this.resoWarning.Location = new System.Drawing.Point(26, 84);
            this.resoWarning.Name = "resoWarning";
            this.resoWarning.Size = new System.Drawing.Size(109, 13);
            this.resoWarning.TabIndex = 5;
            this.resoWarning.Text = "Please use 1366x768";
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
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(854, 745);
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
            this.control.ResumeLayout(false);
            this.testFrame.ResumeLayout(false);
            this.testFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resoWarningPic)).EndInit();
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
        private System.Windows.Forms.Button back;
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
    }
}

