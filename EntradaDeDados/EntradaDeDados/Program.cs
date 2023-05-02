using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string name = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            string age = Console.ReadLine();

            Console.WriteLine("Olá, " + name + " Você tem " + age + " anos de idade");

            Console.WriteLine("Pressione qualquer tecla...");
            char teclaPressionada = Console.ReadKey(true).KeyChar;
            Console.WriteLine("A tecla pressionada foi: " + teclaPressionada);

            Console.ReadKey();
        }
    }
}
