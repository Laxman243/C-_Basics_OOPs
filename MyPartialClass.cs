using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Sample
    {
        private int x;
        private int y;
        public void DoWork( int x , int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public partial class Sample
    {
        public void GoToLunch()
        {
            Console.WriteLine("Sample: {0},{1}", x, y);
        }
    }
     class MyPartialClass
    {
        static void Main()
        {
            Sample obj = new Sample();
            obj.DoWork(10, 20);
            obj.GoToLunch();
            Console.ReadLine();

        }
    }
}


  
