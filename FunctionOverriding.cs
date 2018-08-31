using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FunctionOverriding
    {
        protected int EmpId;
        protected String EmpName;
        string EAddress;
        int Age;

        public virtual void GetData()
        {
            Console.WriteLine("enter the details");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.EmpName = Console.ReadLine();
            this.EAddress = Console.ReadLine();
            this.Age = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void DisplayData()
        {
            Console.WriteLine("EmpId :" + EmpId);
            Console.WriteLine("EmpName :" + EmpName);
            Console.WriteLine("EmpAddress :" + EAddress);
            Console.WriteLine("EmpAge :" + Age);
        }
    }
    class DerivedClass : FunctionOverriding
    {
        double CA, Bonus;

        public override void GetData()
        {
            Console.WriteLine("details of Employee");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.EmpName = Console.ReadLine();
            this.CA = Convert.ToDouble(Console.ReadLine());
            this.Bonus = Convert.ToInt32(Console.ReadLine());
        }
        public override void DisplayData()
        {
            Console.WriteLine("employee details");
            Console.WriteLine("empId: " + this.EmpId);
            Console.WriteLine("empName :" + this.EmpName);
            Console.WriteLine("CA : " + this.CA);
            Console.WriteLine("Bonus :" + this.Bonus);
        }

    }
    class ObjectIsHere
    {
        static void Main()
        {
            DerivedClass obj = new DerivedClass();
            obj.GetData();
            obj.DisplayData();
            Console.Read();
        }
    }
}
