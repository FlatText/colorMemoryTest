using System;
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
            test1Btn.Enabled = false;
            resoWarning.Show();
            resoWarningPic.Show();

            //Resolution check
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            int width = resolution.Width;            
            int height = resolution.Height;
            Console.WriteLine("Felbontás: {0} x {1}", width, height); /* FOR DEBUG */ 
            if (width == 1920 && height == 1080)
            {          
                resoWarning.Hide();
                resoWarningPic.Hide();
                test1Btn.Enabled = true;
            }
            
            /* Initial Progress Bar reset */
            progress.Value = 0;

            /* Initial Form Size */
            this.Size = new System.Drawing.Size(0, 0);
            this.Height = 350;
            this.Width = 450;           

            /* Setting the colors of the buttons */
            reset.BackColor = Color.Red;
            back.BackColor = Color.DimGray;
            next.BackColor = Color.DimGray;

            /* Position of 'control' grpBox */
            control.Location = new Point(1760, 980);
            /* Position of progress bar */
            progress.Location = new Point(100, 1000);
            /* Position of testFrame */
            testFrame.Location = new Point(25, 25);
            /* Position of colorBox */
            coloringBox.Location = new Point(25, 25);
            /* Position of registerForm */
            registerBox.Location = new Point(25, 25);
            /* Size of coloringBox */
            coloringBox.Size = new System.Drawing.Size(1275, 625);
            /* Size of testFrame */
            testFrame.Size = new System.Drawing.Size(1800, 925);

            /* Picture 1-6 & Radiobuttons 1-6 */
            pictureBox1.Size = new System.Drawing.Size(370, 270);
            pictureBox2.Size = new System.Drawing.Size(370, 270);
            pictureBox3.Size = new System.Drawing.Size(370, 270);
            pictureBox4.Size = new System.Drawing.Size(370, 270);
            pictureBox5.Size = new System.Drawing.Size(370, 270);
            pictureBox6.Size = new System.Drawing.Size(370, 270);

            pictureBox1.Location = new Point(200, 200);
            pictureBox2.Location = new Point(700, 200);
            pictureBox3.Location = new Point(1200, 200);
            pictureBox4.Location = new Point(200, 600);
            pictureBox5.Location = new Point(700, 600);
            pictureBox6.Location = new Point(1200, 600);

            picture1.Location = new Point(180, 335);
            picture2.Location = new Point(680, 335);
            picture3.Location = new Point(1180, 335);
            picture4.Location = new Point(180, 735);
            picture5.Location = new Point(680, 735);
            picture6.Location = new Point(1180, 735);

            /* Hide next, back, reset buttons and interfaces */
            control.Hide();
            progress.Hide();
            testFrame.Hide();
            coloringBox.Hide();
            registerBox.Hide();

            /* Disable back button, until TO DO some function */
            back.Enabled = false;
            //back.Hide();
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
            registerBox.Show();
            registerBtn.Enabled = false;
            this.Size = new System.Drawing.Size(385, 515);
        }

        /* flags to determine that the form is filled */
        bool isFilled_flag_1 = false;
        bool isFilled_flag_2 = false;
        bool isFilled_flag_3 = false;
        private void name_textBox_TextChanged(object sender, EventArgs e)
        {
            isFilled_flag_1 = true;
        }
        private void nat_textBox_TextChanged(object sender, EventArgs e)
        {
            isFilled_flag_2 = true;
        }
        private void schoolBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            isFilled_flag_3 = true;
        }
        private void isFilled_CheckedChanged(object sender, EventArgs e)
        {
            if (isFilled_flag_1 == true && isFilled_flag_2 == true && isFilled_flag_3 == true)
            {
                registerBtn.Enabled = true;
            }
            else
            {
                if (isFilled.Checked != false)
                {
                    System.Windows.Forms.MessageBox.Show("Please fill the boxes!");
                    isFilled.Checked = false;
                }
            }
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            /* Store the data */

            TestUser Tester1 = new TestUser(
                name_textBox.Text,
                nat_textBox.Text,
                schoolBox.Text,
                monthCalendar1.SelectionRange.Start.ToString()
                );

            /* Debug Class object creating */
            Console.WriteLine("Name: {0}", Tester1.getName());
            Console.WriteLine("Nationality: {0}", Tester1.getNat());
            Console.WriteLine("Faculty: {0}", Tester1.getFaculty());
            Console.WriteLine("Birth: {0}", Tester1.getBirthdate());

            /* Reset form for the next instance */
            registerBtn.Enabled = false;
            isFilled.Checked = false;
            next.Enabled = false;
            isFilled_flag_1 = false;
            isFilled_flag_2 = false;
            isFilled_flag_3 = false;

            /* Open up the next part */
            registerBox.Hide();
            control.Show();
            progress.Show();
            testFrame.Show();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;         
        }

        private void reset_Click(object sender, EventArgs e)
        {
            /* Resetting the interface */
            startBox.Show();
            control.Hide();
            progress.Hide();
            testFrame.Hide();
            coloringBox.Hide();
            /* Resetting the progressbar */
            progress.Value = 0;
            /* Resetting the radiobuttons after choosing an image */
            picture1.Checked = true;
            picture1.Checked = false;
            /* because no radiobuttons selected, therefore next button is not available
             * so its color is Grey */
            next.BackColor = Color.DimGray;
        }

        private void next_Click(object sender, EventArgs e)
        {
            /* test flags */
            bool test_1_flag = false;
            bool test_2_flag = false;

            /* Let's decide which test is active */
            if (
                (picture1.Checked = true) || 
                (picture2.Checked = true) || 
                (picture3.Checked = true) || 
                (picture4.Checked = true)
                )
            {
                test_1_flag = true;
            }
            else
            {
                test_2_flag = true;
            }

            if (progress.Value != 100 && test_1_flag == true)
            {
                /* Change this to represent the number of the test cases -> 100 / <nr> = 20 */
                progress.Value += 20; // 5 test case
                test_1_flag = true;
            }
            else
            {
                test_1_flag = false;
                startBox.Hide();
                control.Show();
                progress.Show();
                testFrame.Hide();
                coloringBox.Show();
                progress.Value = 0; // Until TO DO is done
                //System.Windows.Forms.MessageBox.Show("You finished the test! Thanks for your participation.");
                //reset_Click(sender, e);
            }

            if (test_1_flag == true)
            {
                //Resetting the radiobuttons after choosing an image
                picture1.Checked = true;
                picture1.Checked = false;
                /* Hide stuff for 10 seconds to let the tester's eye to recover */
                testFrame.Hide();
                progress.Hide();
                control.Hide();

                betweenTestDelay(10); //delay 

                testFrame.Show();
                progress.Show();
                control.Show();
            }
            else if (test_2_flag == true)
            {
                /* TO DO */
            }
            else
            {
                /* ops */
            }

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
             * Currently disabled. May TO DO in the future... ~
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
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            picture5.Checked = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            picture6.Checked = true;
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            colors.ShowDialog();
        }
        void betweenTestDelay(int _sec)
        {
            System.Threading.Thread.Sleep(_sec*1000);
        }

    }
}