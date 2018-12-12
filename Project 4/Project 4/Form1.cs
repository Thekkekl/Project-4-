using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4
{
    public partial class CourseDetails : Form
    {
        public CourseDetails()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // the following code 
            string ct = Class2.getsn();
            txtStudentNme.Text = ct;

            int cno = Class2.getcours();
            txtCourseTkn.Text = Convert.ToString(cno);

            DateTime dttime = Class2.getstartdate();
            txtStartDate.Text = Convert.ToString(dttime);

            string type1 = Class2.gettype();
            txtClassType.Text = type1;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime DateTime = Convert.ToDateTime(dateTimeStartDate.Text);
            Class1.setstdate(DateTime);// passing the value of datetime variable to another variable dtTime of the setdate method in class1.
            string courseno = tableCBCourseNo.Text;
            // the following code tests the first textbox No. of Course Taken
            // it checks if the value entered is integer if not it shows an error.
            try
            {
                int NoCourse = int.Parse(txtCourseTaken.Text, System.Globalization.NumberStyles.None); // parses the string in CrsTaken text box.
                Class1.setscours(NoCourse); // passing the value of NoOfCourse variable to another variable course of the setsnocours method in class1.
            }

            catch (Exception)
            {
                MessageBox.Show("Enter the Number of Courses Taken. Enter the values in form of Numbers only.");
                txtCourseTaken.Clear();// Clears the TextBox CrsTaken

            }

            // the following code tests the Second textbox Student Name
            // it checks if the value entered ends with or starts with a space if it does it shows an error.
            string SName = txtStudentName.Text; // storeing of value to variable
            if (SName.EndsWith(" ") || SName.StartsWith(" ")) // the code checks if the string starts with or ends with a Blank
            {
                MessageBox.Show("Student Name Cannot Start or End with a Space");
                txtStudentName.Clear();

            }
            else
            { }
            //the following code tests the Second textbox Student Name
            // it checks if the value entered consist of a space if it doesn't it shows an error.
            if (SName.Contains(" ")) // the code that checks if there is space between first name and last name.
            {
                Class1.setsn(SName); // passing the value of StudentName variable to another variable sname of the sets1 method in class1.
            }
            else
            {
                MessageBox.Show("There should be a space between First name and Last name");
                txtStudentName.Clear();
            }

            if (rbInClass.Checked == true)
            {
                string t = "in class";
                Class1.settype(t);

            }

            else
            {
                rbHybrid.Checked = true;
                string type = "Hybrid";
                Class1.settype(type);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
    }
}
