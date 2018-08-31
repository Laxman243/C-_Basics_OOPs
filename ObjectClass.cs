using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ObjectClass
    {
        static void Main()
        {
            /*AbstractionExample obj = new AbstractionExample();
            Console.WriteLine("write details");
            Console.WriteLine("enter employee ID");
            obj.PEmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee Name");
            obj.PEName = Console.ReadLine();
            Console.WriteLine("enter employee Address");
            obj.PEAddress = Console.ReadLine();
            Console.WriteLine("enter employee Age");
            obj.PEAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("write the details are ");
            Console.WriteLine("EmpID :" + obj.PEmpId);
            Console.WriteLine("EmpName : " + obj.PEName);
            Console.WriteLine("EmpAddress : " + obj.PEAddress);
            Console.WriteLine("EmpAge :" + obj.PEAge);*/

            ClsArithmatic obj = new ClsArithmatic();
            Console.WriteLine("enter the number1");
            obj.PNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number2");
            obj.PNum2 = Convert.ToInt32(Console.ReadLine());

            obj.Add();
            Console.WriteLine("addition of two numbers :" + obj.PResult);

            obj.Sub();
            Console.WriteLine("Subtraction of two number :" + obj.PResult);
            Console.ReadLine();
        }
    }
}
