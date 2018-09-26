﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brandcolorrecog
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();

            //enable resolution warning - we dont know the screen resolution yet
            resoWarning.Show();
            resoWarningPic.Show();

            //Resolution check
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            int width = resolution.Width;            
            int height = resolution.Height;
            Console.WriteLine("Felbontás: {0} x {1}", width, height);
            if (width == 1366 && height == 768)
            {          
                resoWarning.Hide();
                resoWarningPic.Hide();
            }
            
            /* Initial Progress Bar reset */
            progress.Value = 0;

            /* Initial Form Size */
            this.Size = new System.Drawing.Size(0, 0);
            this.Height = 350;
            this.Width = 450;           

            reset.BackColor = Color.Red;
            //back.BackColor = Color.Yellow;
            back.BackColor = Color.DimGray;
            //next.BackColor = Color.Green;
            next.BackColor = Color.DimGray;

            /* Position of 'control' grpBox */
            control.Location = new Point(1200, 680);
            /* Position of progress bar */
            progress.Location = new Point(300, 705);
            /* Position of testFrame */
            testFrame.Location = new Point(25, 25);
            /* Size of testFrame */
            testFrame.Size = new System.Drawing.Size(1275, 625);

            /* Picture 1-2-3-4 & Radiobuttons 1-2-3-4 */
            pictureBox1.Size = new System.Drawing.Size(370, 270);
            pictureBox2.Size = new System.Drawing.Size(370, 270);
            pictureBox3.Size = new System.Drawing.Size(370, 270);
            pictureBox4.Size = new System.Drawing.Size(370, 270);                     

            picture1.Location = new Point(180, 150);
            picture2.Location = new Point(680, 150);
            picture3.Location = new Point(180, 450);
            picture4.Location = new Point(680, 450);

            pictureBox1.Location = new Point(200, 25);
            pictureBox2.Location = new Point(700, 25);
            pictureBox3.Location = new Point(200, 325);
            pictureBox4.Location = new Point(700, 325);
        
            /* Hide next, back, reset buttons */
            control.Hide();
            progress.Hide();
            testFrame.Hide();

            /* Disable back button, until TO DO some function */
            back.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); /*on click the program stop running */
        }

        private void aboutBtn_Click(object sender, EventArgs e) /* calling the about page */
        {
            AboutBox box = new AboutBox(); /*create a new AboutBox object */          
            box.ShowDialog(); /* open it */            
        }

        private void pannonLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mik.uni-pannon.hu/");
        }

        private void test1Btn_Click(object sender, EventArgs e)
        {
            startBox.Hide();
            control.Show();
            progress.Show();
            testFrame.Show();
            next.Enabled = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            startBox.Show();
            control.Hide();
            progress.Hide();
            testFrame.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (progress.Value != 100)
            {
                /* Change this to represent the number of the test cases -> 100 / <nr> = 20 */
                progress.Value += 20; // 5 test case
            }
            else
            {
                /* 
                 * TO DO - Jump into coloring text 
                 */
                progress.Value = 0; // Until TO DO is done
                System.Windows.Forms.MessageBox.Show("You finished the test! Thanks for your participation.");
                reset_Click(sender, e);
            }

            //Resetting the radiobuttons after choosing an image
            picture1.Checked = true;
            picture1.Checked = false;

            next.Enabled = false;
            next.BackColor = Color.DimGray;
        }

        private void picture1_CheckedChanged(object sender, EventArgs e)
        {
            next.Enabled = true;
            next.BackColor = Color.Green;
        }

        private void picture2_CheckedChanged(object sender, EventArgs e)
        {
            next.Enabled = true;
            next.BackColor = Color.Green;
        }

        private void picture3_CheckedChanged(object sender, EventArgs e)
        {
            next.Enabled = true;
            next.BackColor = Color.Green;
        }

        private void picture4_CheckedChanged(object sender, EventArgs e)
        {
            next.Enabled = true;
            next.BackColor = Color.Green;
        }

        private void back_Click(object sender, EventArgs e)
        {
            /*
             * TO DO
             */ 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picture1.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            picture2.Checked = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            picture3.Checked = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            picture4.Checked = true;
        }
    }
}