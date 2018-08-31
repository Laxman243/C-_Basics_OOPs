using System;


namespace ConsoleApp1
{
    class WhileLoop
    {
        static void Main()
        {
            Console.WriteLine("enter the target");
            int UserTarget = int.Parse(Console.ReadLine());

            int Start = 0;

            while( Start <= UserTarget)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
            Console.ReadKey();
        }
    }
}
