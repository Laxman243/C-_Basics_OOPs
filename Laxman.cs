using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Laxman
    {
        int IdNumber;
        
        public void Get()
        {
            Console.WriteLine("enter IdNumber");
            this.IdNumber = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("this is IdNumber:" + IdNumber);
            Console.ReadLine();
        }
    }
}
