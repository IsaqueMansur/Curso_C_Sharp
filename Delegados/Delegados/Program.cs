using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    internal class Program
    {

        public delegate double MyDelegateOperations(double a, double b);
        public static double Sum(double a, double b)
        {
            Console.WriteLine("A soma de " + a + " e " + b + " é igual a " + (a + b));
            return a + b;
        }
        public static double Multiply(double a, double b)
        {
            Console.WriteLine("A multiplicação de " + a + " e " + b + " é igual a " + (a * b));
            return a + b;
        }
        static void Main(string[] args)
        {
            MyDelegateOperations myOperations;
            myOperations = Sum;
            myOperations += Multiply;
            double result = myOperations(10, 20);
            Console.WriteLine("Resultado: " + result);
            Console.ReadKey();
        }
    }
}
