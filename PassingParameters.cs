using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PassingParameters
    {
        static void Main()
        {
            int i = 0;
           // SimpleMethod(i);
            Console.WriteLine("value of i :" + i); // 0 

            //pass by ref 
            int j = 10;
            Console.WriteLine("before method call value of j :" + j);
            SimpleMethodExample(ref j);
            Console.WriteLine("after method call value of j :" + j);
            Console.ReadLine();
        }
        // pass by value parameter
        static void SimpleMethod(int i)
        {
            i = 100;
            Console.WriteLine("value of i :" + i); // 100
        }

        //pass by refer 
        static void SimpleMethodExample(ref int k )
        {
            k = 100;
            Console.WriteLine("value of k :" + k);
        }
    }
    class OutParameterClass
    {
        /*u need to keep out not only in Method parameter but also in the place where method is gets called with two newly variable '
         * and you have to declare those variable also.
         */
        static void Main()
        {
            int Total = 0;
            int Product = 0;
            Calculate(10, 20, out Total, out Product);
            Console.WriteLine("sum = {0} && Product={1}", Total, Product);
            Console.ReadLine();
        }
        public static void Calculate(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }
    }
    class ParameterArrays
    {
        static void Main()
        {
            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;

            ParameterMethod();
            ParameterMethod(Numbers);
            ParameterMethod(1, 2, 3, 4, 5);
            Console.ReadLine();
        }
        public static void ParameterMethod(params int[] Numbers)
        {
            Console.WriteLine("there are {0} elements", Numbers.Length);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
                
            }
        }
    }
    public class Options
    {
         static void ExampleMethod(int required, int optionalInt = default(int),
                                  string description = "Optional Description")
        {
            Console.WriteLine(description, required);
        }
        static void Main()
        {
            ExampleMethod(1, 2, "shukla");
            ExampleMethod(1, description : "laxman", optionalInt : 3);
            Console.ReadLine();
        }
    }

}
