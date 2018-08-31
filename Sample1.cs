using System;

    class Sample1
    {
        static void Main()
        {
        Console.WriteLine("enter first name");
        string FirstName = Console.ReadLine();
        Console.WriteLine("enter last name");
        string LastName = Console.ReadLine();
        Console.WriteLine("hello {0},{1}", FirstName, LastName);
        Console.Read();
        }
    }

