using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FunctionOverloading
    {
            public int Add(int x, int y)
        {
            return x + y;
        }
        public int Add(int x, int y , int z,int k)
        {
            return x + y + z;
        }
        public float Add(int x, int second = 10, int third = 20)
        {
            return x + second + third;
        }
    }
    class ClsOverload
    {
        static void Main()
        {
            FunctionOverloading obj = new FunctionOverloading();
            Console.WriteLine("Sum is : " + obj.Add(10, 20, 30));
            Console.WriteLine("Sum is : " + obj.Add(10));
            Console.WriteLine("sum is : " + obj.Add(second : 40, x : 10));
            Console.ReadLine();

        }
    }
}
