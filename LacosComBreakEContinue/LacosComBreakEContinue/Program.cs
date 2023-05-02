using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosComBreakEContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pressione 'c' para continuar e 's' para sair");
                string pressionedKey = Console.ReadKey(true).KeyChar.ToString();
                if (pressionedKey == "c")
                {
                    continue;
                }
                else if (pressionedKey == "s")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tecla desconhecida");
                }
                Console.Clear();
            }
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
