using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class MathsThirdParty
    {

        static void Add(int i , int j)
        {
            int sum = i + j;
            Console.WriteLine("addition of two number :"+  sum);
            Console.ReadLine();
        }
        static void Main()
        {
            Console.WriteLine("enter first number");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter secone number");
            int j = Convert.ToInt32(Console.ReadLine());

            Add(i, j);
        }
    }
}
