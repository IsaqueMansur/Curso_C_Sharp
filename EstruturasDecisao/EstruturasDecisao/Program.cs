using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDecisao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //if else
            string a = "a";
            if(a == "a")
            {
                Console.WriteLine("É 'A'");

            } else
            {
                Console.WriteLine("Não é 'A'");

            }


            //if else if else
            string b = "c";

            if(b == "b")
            {
                Console.WriteLine("É 'B'");
            } else if (b == "c")
            {
                Console.WriteLine("É 'C'");
            } else
            {
                Console.WriteLine("Não é 'B' nem 'C'");
            }


            //switch
            string c = "d";

            switch (a)
            {
                case "a":
                    Console.WriteLine("É 'A'");
                    break;

                default:
                    Console.WriteLine("Default");
                    break;
            }


            Console.ReadKey();
        }

    }
}
