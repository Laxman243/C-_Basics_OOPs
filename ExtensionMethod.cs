using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class SampleExtension
    {
        static void Main()
        {
            MathsThirdParty obj = new MathsThirdParty();
            obj.Mul(40, 10);
            Console.ReadLine();
        }
    }
    public static class ExtensionMethod
    {
        public static void Mul(this MathsThirdParty obj, int num1 , int num2)
        {
            Console.WriteLine(num1*num2);
        }
    }
}
