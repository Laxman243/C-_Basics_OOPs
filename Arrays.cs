using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Arrays
    {
        static void Main()
        {
            int[] Num = new int[4];
            Num[0] = 102;
            Num[1] = 104;
            Num[2] = 106;
            Num[3] = 108;

            // to print specific number 
            //Console.WriteLine("Num[2] :" + Num[2]);

             for (int i = 0; i < Num.Length; i++)
             {
                 Console.WriteLine(Num[i]);
             }

            Console.WriteLine("from foreach loop");
           /* foreach (int i in Num)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("from while loop");
            int j = 0;
            while( j < Num.Length)
            {
                Console.WriteLine(Num[j]);
                j++;
            }

            // using do-while loop
            Console.WriteLine("from do-while loop");
            int k = 0;
            do
            {
                Console.Write(" " + Num[k]);
                k++;
            } while (k < Num.Length);
            */
            Console.ReadKey();
        }
    }
}
