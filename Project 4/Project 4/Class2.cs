using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    class Class2
    {
        
        private static string studentname;
        private static int courseno;
        private static DateTime dateTime;
        private static string type2;
        private static string t2;
        // returning the value of student name.
        public static string getsn()
        {
            return studentname;
        }
        // storing the student name in variable.
        public static void setsn(String stdname)
        {
            string nme;
            nme = studentname;
            studentname = stdname;
            if (nme != studentname)
            {
                System.Windows.Forms.MessageBox.Show("The values has been changed to" + studentname);
            }
            getsn();
        }
        // returning the value of number or course.
        public static int getcours()
        {
            return courseno;

        }
        // storing number or courses in variable.
        public static void setscours(int course)
        {
            int a;
            a = courseno;
            courseno = course;
            if (a != courseno)
            {
                System.Windows.Forms.MessageBox.Show("The values has been changed to" + courseno);
            }
            gettable1();
        }

        private static void gettable1()
        {
            throw new NotImplementedException();
        }

        // returning value of start date.
        public static DateTime getstartdate()
        {
            return dateTime;

        }
        // storing the start date in variable.
        public static void setstartdate(DateTime dtTime)
        {
            DateTime t1;
            t1 = dateTime;
            dateTime = dtTime;
            if (t1 != dateTime)
            {
                System.Windows.Forms.MessageBox.Show("The Value has been changed to" + dateTime);
            }
            getstartdate();
        }
        // returning the type of course
        public static string gettype()
        {
            return type2;

        }
        // storing the course type in variable
        public static void settype(string Type)
        {
            string type;
            type = type2;
            type2 = Type;
            if (type != type2)
            {
                System.Windows.Forms.MessageBox.Show("The calue has been changed to" + type2);
            }
            gettype();
        }
        // returning the course number
        public static string Gettable1()
        {
            return t2;

        }
        // storing the value of course number in variable.
        public static void setcours(string T1)
        {
            string t;
            t = t2;
            t2 = T1;
            if (t != t2)
            {
                System.Windows.Forms.MessageBox.Show("The value has been changed to" + t2);
            }
            Gettable1();
        }
    }
}
