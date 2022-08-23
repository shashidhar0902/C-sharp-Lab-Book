using System;

namespace App
{
    public class SchoolDemo
    {
        int rollno;
        string sName;
        byte age;
        char gender;
        DateTime DOB;
        string address;
        float perc;

        public SchoolDemo(int rollno, string sName, byte age, char gender, DateTime dOB, string address, float perc)
        {
            this.rollno = rollno;
            this.sName = sName;
            this.age = age;
            this.gender = gender;
            DOB = dOB;
            this.address = address;
            this.perc = perc;
        }

        public override string ToString()
        {
            return this.sName +" "+ this.rollno + " " + this.age + " " + this.gender + " " + this.address + " " + this.perc + " " + DOB.ToString();
            //return base.ToString();
        }
    }

    class main {
        public static void Main(){

            SchoolDemo schoolDemo = new SchoolDemo(21, "name",21,'g',DateTime.Now,"34-434-43",23.3f);
            Console.WriteLine(schoolDemo);
            Console.ReadLine();

        }

    }
    
}
