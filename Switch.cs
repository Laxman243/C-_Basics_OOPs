using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the targetNumber");
            
            int UserNumber = int.Parse(Console.ReadLine());

            switch (UserNumber)
            {
                case 10:
                    Console.WriteLine("your number is 10");
                    Console.ReadLine();
                    break;
                case 20:
                    Console.WriteLine("your number is 20");
                    Console.ReadLine();
                    break;

                case 30:
                    Console.WriteLine("your number is 30");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("your number is not 10, 20 , 30");
                    Console.ReadLine();
                    break;

                    
            }
        }
    }

}
