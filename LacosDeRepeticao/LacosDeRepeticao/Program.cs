using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosDeRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For
            for (int i = 0; i <=
                10; i++)
            {
                Console.WriteLine(i);
            }

            //While
            int j = 0;
            while(j <= 100)
            {
                Console.WriteLine(j);
                j++;
            }

            //Do While
            do {
                Console.WriteLine("a" + j);
                j++;
            } while(j <= 200);

            //ForEach
            int[] arrayNumbers = { 10, 20, 30, };

            foreach(int i in arrayNumbers) {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
