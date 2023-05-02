using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array de 1 dimensão
            int[] arrayNumbers1 = new int[3];
            arrayNumbers1[0] = 1;
            arrayNumbers1[1] = 2;
            arrayNumbers1[2] = 3;

            Console.WriteLine(arrayNumbers1[2]);

            int[] arrayNumbers2 = { 1, 2, 3 };
            Console.WriteLine(arrayNumbers2[1]);

            //array de 2 dimensões
            string[,] arrayString1 = new string[2, 3];
            arrayString1[0, 0] = "00";
            arrayString1[0, 1] = "01";
            arrayString1[0, 2] = "02";
            arrayString1[1, 0] = "10";
            arrayString1[1, 1] = "11";
            arrayString1[1, 2] = "12";

            Console.WriteLine(arrayString1[0,0]);
            Console.WriteLine(arrayString1[0,1]);
            Console.WriteLine(arrayString1[1,0]);

            string[,] arrayString2 = { { "a", "b", "c" }, { "1", "2", "3" } };
            Console.WriteLine(arrayString2[0,1]);
            Console.WriteLine(arrayString2[1,1]);

            //lendo o "Length"
            int lengthOfArrayOneDimension = arrayString2.GetLength(0);
            int lengthOfArrayTwoDimensions = arrayString2.GetLength(1);

            Console.WriteLine(lengthOfArrayOneDimension);
            Console.WriteLine(lengthOfArrayTwoDimensions);


            Console.ReadKey();
        }
    }
}
