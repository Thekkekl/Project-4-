using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    public static class Class1
    {
        private static string txtstdname1;
        private static int nocourse;
        private static DateTime datTime;
        private static string type;
        private static string t;


        // Passing the value to class 2.
        public static void getsn()
        {
            Class2.setsn(txtstdname1);

        }
        // Getting the value from the variables in main form.
        public static void setsn(String sname)
        {
            txtstdname1 = sname;
            getsn();
        }
        // Passing the value to class 2.
        public static void getnocours()
        {
            Class2.setscours(nocourse);

        }
        
        public static void setscours(int course)
        {
            nocourse = course;
            getnocours();
        }
        // Passing the value to class 2.
        public static void getdate()
        {
            Class2.setstartdate(datTime);

        }
     
        public static void setstdate(DateTime dtTime)
        {
            datTime = dtTime;
            getdate();
        }
        // Passing the value to class 2.
        public static void gettype()
        {
            Class2.settype(type);

        }
        
        public static void settype(string Type)
        {
            type = Type;
            gettype();
        }
        // Passing the value to class 2.
        public static void getcoursno()
        {
            Class2.setcours(t);

        }
      
        public static void setcoursno(string T)
        {
            t = T;
            getcoursno();
        }
    }
}
