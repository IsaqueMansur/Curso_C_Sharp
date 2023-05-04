using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Digire um número: ");
            int key = Convert.ToInt32(Console.ReadLine());
            int result = 10 / key;
            Console.WriteLine(result);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Final do tratamento da exceção.");
            }

            Console.ReadKey();
        }
    }
}
