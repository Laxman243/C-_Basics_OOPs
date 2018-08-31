using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Aa
    {
        void Add();
    }
    interface Bb
    {
        void Add();
    }
    class InheritanceToInterface : Aa, Bb
    {
        // simple multiple Inheritance concept implemented
        /*public void Add()
        {
            Console.WriteLine("Multiple Inheritance Through Interfaces");
        }
        static void Main()
        {
            InheritanceToInterface obj = new InheritanceToInterface();
            obj.Add();
            Console.Read();
        }*/
        //implementing multiple inheritance with different interface outputs

        void Aa.Add()
        {
            Console.WriteLine("welcome to Aa");
        }
        void Bb.Add()
        {
            Console.WriteLine("Welcome to Bb");
        }
        static void Main()
        {
            InheritanceToInterface obj = new InheritanceToInterface();
            Aa obj2 = (Aa)obj;
            Bb obj3 = (Bb)obj;
            obj2.Add();
            obj3.Add();
            Console.Read();
        }

    }
}
