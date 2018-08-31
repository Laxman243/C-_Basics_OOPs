using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MultiDimensionalArray
    {
        static void Main()
        {

            //creating two dimensional array of 2 row and 3 columns.
           // int[,] arr = new int[2,3];
            // 0 0 0
            // 0 0 0

            //Console.WriteLine(arr[0, 0] + " " + arr[0, 1] + " " + arr[0, 2]);
            //Console.WriteLine(arr[1, 0] + " " + arr[1, 1] + " " + arr[1, 2]);
            //Console.ReadLine();

            // string array to stores names
            string[] Names = new string[3];
            Names[0] = "laxman";
            Names[1] = "harsh";
            Names[2] = "sagar";

            //jagged array to store qualification
            string[][] jaggedArray = new string[3][];
            jaggedArray[0] = new string[3];
            jaggedArray[1] = new string[1];
            jaggedArray[2] = new string[2];

            jaggedArray[0][0] = "html";
            jaggedArray[0][1] = "java";
            jaggedArray[0][2] = "css";

            jaggedArray[1][0] = "html";

            jaggedArray[2][0] = "html";
            jaggedArray[2][1] = "java";
            
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine("Element [" + i + "] Array: ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                    Console.Write(jaggedArray[i][j] + " ");
                Console.ReadLine();
            }
        }
    }
}
