using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        int StudentId;
        string StudentName;

        public void GetData()
        {
            Console.WriteLine("Enter StudentId");
            this.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter StudentName");
            this.StudentName = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("Student Details");
            Console.WriteLine("Student Id :" + StudentId);
            Console.WriteLine("Student Name:" + StudentName);
        }

    }
    interface A
    {
        void GetData();
        void DisplayData();
    }
    class MultipleInheritance : Student,A
    {
        string StudentAddress;
        int StudentPhoneNumber;

        public void GetData1()
        {
            Console.WriteLine("enter studentAddress :");
            this.StudentAddress = Console.ReadLine();
            Console.WriteLine("enter studentPhonenNumber :");
            this.StudentPhoneNumber = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayData1()
        {
            Console.WriteLine("studentAddress :" + StudentAddress);
            Console.WriteLine("studentPhoneNumber :" + StudentPhoneNumber);
        }
        static void Main()
        {
            MultipleInheritance obj = new MultipleInheritance();
            obj.GetData();
            obj.GetData1();
            obj.DisplayData();
            obj.DisplayData1();
            Console.ReadLine();

        }
    }
}
