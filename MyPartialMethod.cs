using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public partial class MyPartialMethod
    {
        partial void Definition();
    }
   public  partial class MyPartialMethod
    {
        partial void Definition()
        {
            Console.WriteLine("Implemented method");
        }
        static void Main()
        {
            MyPartialMethod obj = new MyPartialMethod();
            obj.Definition();
            Console.ReadLine();
        }
    }
}
