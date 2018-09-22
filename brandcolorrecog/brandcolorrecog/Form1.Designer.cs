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
            this.test2Btn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pannonLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pannonLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // test1Btn
            // 
            this.test1Btn.Location = new System.Drawing.Point(27, 20);
            this.test1Btn.Name = "test1Btn";
            this.test1Btn.Size = new System.Drawing.Size(120, 48);
            this.test1Btn.TabIndex = 0;
            this.test1Btn.Text = "Test Part 1";
            this.test1Btn.UseVisualStyleBackColor = true;
            this.test1Btn.Click += new System.EventHandler(this.test1Btn_Click);
            // 
            // test2Btn
            // 
            this.test2Btn.Location = new System.Drawing.Point(27, 91);
            this.test2Btn.Name = "test2Btn";
            this.test2Btn.Size = new System.Drawing.Size(120, 48);
            this.test2Btn.TabIndex = 1;
            this.test2Btn.Text = "Test Part 2";
            this.test2Btn.UseVisualStyleBackColor = true;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(27, 161);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(120, 48);
            this.aboutBtn.TabIndex = 2;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(27, 235);
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
            this.pannonLogo.Location = new System.Drawing.Point(176, 35);
            this.pannonLogo.Name = "pannonLogo";
            this.pannonLogo.Size = new System.Drawing.Size(242, 237);
            this.pannonLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pannonLogo.TabIndex = 4;
            this.pannonLogo.TabStop = false;
            this.pannonLogo.Click += new System.EventHandler(this.pannonLogo_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(441, 301);
            this.Controls.Add(this.pannonLogo);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.test2Btn);
            this.Controls.Add(this.test1Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainMenu";
            this.ShowIcon = false;
            this.Text = "Color Memory Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pannonLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button test1Btn;
        private System.Windows.Forms.Button test2Btn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pannonLogo;
    }
}

