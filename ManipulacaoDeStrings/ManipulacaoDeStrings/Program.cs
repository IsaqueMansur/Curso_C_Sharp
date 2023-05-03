using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoDeStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indexação
            string name = "Isaque";
            char letter = name[2];
            Console.WriteLine(letter);

            //Concatenação
            string lastName = "Mansur";
            string completeName = name + " " + lastName;
            Console.WriteLine(completeName);
            string completeName2 = String.Concat(name, " ", lastName);
            Console.WriteLine(completeName2);

            //Substituição (replace)
            string adress = "Rua das rosas verdes";
            adress = adress.Replace("verdes", "vermelhas");
            Console.WriteLine(adress);

            //Remoção
            string adress2 = "Rua das laranjas";
            adress2 = adress2.Replace("laranjas", "");
            Console.WriteLine(adress2);

            string adress3 = "Rua das borboletas";
            adress3 = adress3.Remove(0, 4);
            Console.WriteLine(adress3);

            //Capitalização (Upper case and Lower case)
            string name2 = "João da silva";

            name2 = name2.ToUpper();
            Console.WriteLine(name2);

            name2 = name2.ToLower();
            Console.WriteLine(name2);

            //Contém
            string name3 = "José da silva";
            bool contains = name3.Contains("José");
            Console.WriteLine(contains);

            //Localização
            string name4 = "Pedro alves";
            int index = name4.IndexOf("alves");
            Console.WriteLine(index);

            //Divisão de strings
            string name5 = "Josefino Alberto";
            string[] divisorOfString = { " " };
            string[] resultOfSplit = name5.Split(divisorOfString, StringSplitOptions.None);
            foreach(string text in resultOfSplit)
            {
                Console.WriteLine(text);
            }

            //Quantidade de caracteres da string
            string name6 = "José da silva pereira";
            int lenghtOfName6 = name6.Length;
            Console.WriteLine(lenghtOfName6);

            //Substring
            string name7 = "José da silva dnovo";
            string rangeName7 = name7.Substring(5, 5);
            Console.WriteLine(rangeName7);


            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
