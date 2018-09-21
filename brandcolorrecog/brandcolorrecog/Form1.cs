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

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            /* declaration of some variables for MessageBox */
            string caption; //title
            string message; //text
            caption = "Creating a software to test color memory";

            /*Színmemóri teszteléséhez szoftver készítése.
            A szoftverben egyrészt fel kell ismerni a valós színezetű képet, márkajelzést, 
            másrészt pedig egy kiszínező részben a felhasználónak kell egy palettáról kiszíneznie a 
            márkajelzést egy fehér alapon fekete körvonalakkal megrajzolt képen. A felhasználók választásait 
            adatbázisba kell menteni, majd ezeket elemezni, meghatározni, hogy a felhasználók színmemóriája
            mennyire tér el az eredeti kép színétől. A tesztszoftvert az egyetemen tanuló különböző nemzetiségű
            hallgatókkal is célszerű kitöltetni.
            */

            message = "In the software, the participant should recognise the original colors of a brand, while " +
                      "in the other part, the tester should color a black-white brand logo with the use of a " +
                      "color palette. The user's choice should be saved in a database. This database will be " +
                      "used for further research about color memory of the users of the software." +
                      "\n\n" /* <br> */ +
                      "Created by:" +
                      "\n" /* <br> */ +
                      "Szilárd Váthy, Computer Scientest Bsc" +
                      "\n" /* <br> */ +
                      "szilardvathy@gmail.com" +
                      "\n\n" /* <br> */ +
                      "Cecília Sík Lányi" +
                      "\n" /* <br> */ +
                      "lanyi@almos.uni-pannon.hu";
            MessageBox.Show(message, caption);
        }

        private void pannonLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mik.uni-pannon.hu/");
        }
    }
}
