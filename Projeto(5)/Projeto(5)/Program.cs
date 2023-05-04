using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_5_
{
    internal class Program
    {
        public struct CadasterDatasStruct
        {
            public string Name;
            public DateTime Birthday;
            public string NameOfWay;
            public UInt32 NumberOfHouse;
        }

        public enum Result_e
        {
            Success = 0,
            Exit,
            Excecao
        }

        public static void seeMessage(string msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public static Result_e PickString(ref string str, string msg) 
        {

            Result_e returned;
            Console.WriteLine(msg);
            string temp = Console.ReadLine();

            if (temp == "s" || temp == "S")
                returned = Result_e.Exit;
            else
            {
                str = temp;
                returned = Result_e.Success;
            }
            Console.Clear();
            return returned;
        }   

        public static Result_e pickDate(ref DateTime date, string msg)
        {
            Result_e returned;

            do
            {
                try
                {
                    Console.WriteLine(msg);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                        returned = Result_e.Exit;
                    else
                    {
                        date = Convert.ToDateTime(temp);
                        returned = Result_e.Success;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Excecão: " + e.Message);
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    returned = Result_e.Excecao;

                }
            }while(returned == Result_e.Excecao);
            Console.Clear();
            return returned;
        }

        public static Result_e pickUint32(ref UInt32 address, string msg)
        {
            Result_e returned;

            do
            {
                try
                {
                    Console.WriteLine(msg);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                        returned = Result_e.Exit;
                    else
                    {
                        address = Convert.ToUInt32(temp);
                        returned = Result_e.Success;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Excecão: " + e.Message);
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    returned = Result_e.Excecao;

                }
            } while (returned == Result_e.Excecao);
            Console.Clear();
            return returned;
        }

        public static void CadasterUser(ref List<CadasterDatasStruct> ListOfUsers) 
        {
            CadasterDatasStruct cadasterUser;
            cadasterUser.Name = "";
            cadasterUser.Birthday = new DateTime();
            cadasterUser.NameOfWay = "";
            cadasterUser.NumberOfHouse = 0;

            if (PickString(ref cadasterUser.Name, "Digite o nome completo ou S para sair") != Result_e.Success)
                return;

            if (pickDate(ref cadasterUser.Birthday, "Digite sua data de nascimento no formato 'DD/MM/YYYY' ou S para sair") != Result_e.Success)
                return;

            if (PickString(ref cadasterUser.NameOfWay, "Digite o nome da rua ou S para sair") != Result_e.Success)
                return;

            if (pickUint32(ref cadasterUser.NumberOfHouse, "Digite o número da sua casa") != Result_e.Success)
                return;

            ListOfUsers.Add(cadasterUser);
        }


        static void Main(string[] args)
        {
            List<CadasterDatasStruct> ListOfUsers = new List<CadasterDatasStruct>();
            string option = "";

            do
            {
                Console.WriteLine("Digite C para cadastrar novo usuário ou S para sair da aplicação");
                option = Console.ReadKey(true).KeyChar.ToString().ToLower();

                if (option == "c")
                {
                    CadasterUser(ref ListOfUsers);
                }
                else if (option == "s")
                {
                    seeMessage("Encerrando o software");
                } else
                {
                    seeMessage("Opção desconhecida");
                }
            } while (option != "s");
        }
    }
}
