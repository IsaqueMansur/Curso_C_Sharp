using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNumerica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1 = 0b11001100;
            int resultadoNegacao = ~var1;
            Console.WriteLine("O resultado da negação é: " + Convert.ToString(resultadoNegacao, 2));

            Console.ReadKey();
        }
    }
}
