using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAuthenticateUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite o nome do seu usuário");
                string userName = Console.ReadLine();
                Console.WriteLine("Digite sua senha");
                string userPassword = "";
                while(true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter) {
                        break;
                    } else
                    {
                        userPassword += key.KeyChar;
                    }

                }
                if (userName == "isaque" && userPassword == "1234")
                {
                    Console.WriteLine("Logado com sucesso !");
                    Console.WriteLine("Pressione qualquer tecla para sair");
                    Console.ReadKey();
                    break;
                } else
                {
                    Console.Clear();
                    Console.WriteLine("Usuário ou senha incorreto");
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
