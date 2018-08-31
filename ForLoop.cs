using System;

namespace ConsoleApp1
{
    class ForLoop
    {
        static void Main()
        {
            int[] numbers = new int[4];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;
            numbers[3] = 104;
            Console.WriteLine("enter the targetNumber");
            int UserTarget = int.Parse(Console.ReadLine());

            int a = 0;

            for(int i = 0; i < UserTarget; i++)
            {
                Console.WriteLine(a);
                a = a + 2;
            }
            Console.WriteLine("from foreach loop");

            foreach( int k in numbers)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();
        }

    }
}
