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
            this.Hide(); /* Disable form so the user cant open multiple instance */
            testerData myForm = new testerData();
            myForm.Show();          
        }
    }
}
