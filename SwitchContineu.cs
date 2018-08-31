using System;


    class SwitchContineu
    {
        static void Main()
        {
        Console.WriteLine("please enter your targetNumber");
        int UserNumber = int.Parse(Console.ReadLine());

        switch(UserNumber)
         {
            case 10:
            case 20:
            case 30:
                Console.WriteLine("your number is {0},", UserNumber);
                Console.ReadLine();
                break;
           }
        }
    }

