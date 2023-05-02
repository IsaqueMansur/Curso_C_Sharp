using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione A para alugar um filme ou S para sair da locadora.");
            char option = Console.ReadKey(true).KeyChar;
            if (option == 'A' || option == 'a')
            {
                Console.WriteLine("Pressione 1 para alugar The");
                Console.WriteLine("Pressione 2 para alugar Dark");
                Console.WriteLine("Pressione 3 para alugar Side of the moon");
                int selectedMovie = Convert.ToInt16(Console.ReadKey(true).KeyChar.ToString());

                switch(selectedMovie)
                {
                    case 1:
                        Console.WriteLine("Você alugou The");
                        break;
                    case 2:
                        Console.WriteLine("Você alugou Dark");
                        break;

                    case 3:
                        Console.WriteLine("Você alugou Side of the moon");
                        break;
                }
            } else if (option == 's' || option == 'S') {
                Console.WriteLine("Você escolheu sair !");
            } else
            {
                Console.WriteLine("Opção desconhecida !");
            }
            Console.WriteLine("Pressione qualquer tecla para sair !");
            Console.ReadKey();
        }
    }
}
