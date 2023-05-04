using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static void Multiply(double a, double b, ref double resultOfOperation) 
        {
            resultOfOperation = a * b;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2));

            double initialResult = 0;
            Multiply(10, 10, ref initialResult);
            Console.WriteLine(initialResult);

            Console.ReadKey();
        }
    }
}
