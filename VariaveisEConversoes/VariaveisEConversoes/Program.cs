using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariaveisEConversoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 10;
            byte b = 255; //byte (0 - 255)
            var salario = 10000; //auto atribuição
            DateTime dataDeNascimento = new DateTime(1988, 7, 10, 7, 15, 10);
            string numerodaCasa = "65";
            int numeroDaCasaInt = Convert.ToInt32(numerodaCasa);
            Console.WriteLine(numeroDaCasaInt + 5);
            Console.WriteLine(dataDeNascimento.ToString());
            Console.ReadKey();
        }
    }
}
