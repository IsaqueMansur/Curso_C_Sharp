using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaBooleana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool itsTrue = true;
            bool itsFalse = false;

            Console.WriteLine(!itsTrue);

            bool resultE = itsTrue & itsFalse;
            Console.WriteLine("O resultado dos booleanos é: " + resultE);

            bool resultOr = itsTrue | itsFalse;
            Console.WriteLine("O resultado dos booleanos é: " + resultOr);


            Console.ReadKey();
        }
    }
}
