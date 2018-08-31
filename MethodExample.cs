using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MethodExample
    {
          static void Main()
        {
            Add();
            Sum(10);
            MethodExample obj = new MethodExample();
             obj.Div();
             string Result = Name("laxman");
            Console.WriteLine(Result);
            Console.ReadKey();
        }
        //static method
        static void Add()
        {
            Console.WriteLine("static non-parameterized method");
        }
        static int Sum(int i )
        {
            Console.WriteLine("value of i is : " + i);
            return 10;
        }
        public void Div()
        {
            int j = 3;
            for (int i = 0; i <= j; i++)
            {
                Console.WriteLine("hello");
            }
        }
         static string Name(string str)
        {
            return str;

        }
       
    }  

}
