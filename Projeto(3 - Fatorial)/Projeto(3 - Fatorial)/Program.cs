using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_3___Fatorial_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Digite s para sair ou um número para calcular o fatorial");
                string optionSelected = Console.ReadLine();
                if (optionSelected == "s" || optionSelected == "S")
                {
                    break;
                } else
                {
                    int value = Convert.ToInt32(optionSelected);
                    if (value == 0)
                    {
                        Console.WriteLine("0! = 1");
                        continue;
                    }
                    else if (value < 0)
                    {
                        Console.WriteLine("Impossível calcular o fatorial de números negativos");
                        continue;
                    }
                    else
                    {
                        int result = 1;
                        for (int i = value; i > 0; i--)
                        {
                            result *= i;
                        }
                        Console.WriteLine("O resultado de " + value + " fatorial é: " + result);
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                }
            }
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
