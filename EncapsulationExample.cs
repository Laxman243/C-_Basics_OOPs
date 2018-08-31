using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EncapsulationExample
    {
        
            int EmpId;
            string EmpName;
            string EmpAddress;
            int Age;
      
        public void GetData()
        {
            Console.WriteLine("enter details");
            Console.WriteLine("enter EmpId");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter EmpName");
            this.EmpName = Console.ReadLine();
            Console.WriteLine("enter EmpAddress");
            this.EmpAddress = Console.ReadLine();
            Console.WriteLine("enter EmpAge");
            this.Age = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayData()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("this is empid" + EmpId);
            Console.WriteLine("this is empname" + EmpName);
            Console.WriteLine("this is empAddress" + EmpAddress);
            Console.WriteLine("this is Age" + Age);
        }
        static void Main()
        {
            EncapsulationExample obj = new EncapsulationExample();
            //obj.GetData();
            Console.WriteLine(" ");
            //obj.DisplayData();
            Laxman obj2 = new Laxman();
            obj2.Get();
            obj2.Display();

        }
    }
}
