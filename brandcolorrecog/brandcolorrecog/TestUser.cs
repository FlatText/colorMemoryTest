using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brandcolorrecog
{
    class TestUser
    {
        private string name;
        private string nat;
        private string faculty;
        private int age;
        private string occup;

        /*
         * TO DO: variables for different test results
         */

        public TestUser(string _name, string _nat, string _faculty, int _age, string _occup)
        {
            this.name = _name;
            this.nat = _nat;
            this.faculty = _faculty;
            this.age = _age;
            this.occup = _occup;
        }


        public void saveUserData()
        {
            /*
             * TO DO after creating database
             */ 
        }

        public void saveTestData()
        {
            /*
             * TO DO creating a method to save the test data after test
             */
        }

        /*
         * Get functions for debug below ~
         */ 
        public string getName()
        {
            return this.name;
        }
        public string getNat()
        {
            return this.nat;
        }
        public string getFaculty()
        {
            return this.faculty;
        }
        public int getAge()
        {
            return this.age;
        }
        public string getOccup()
        {
            return this.occup;
        }
    }
}
