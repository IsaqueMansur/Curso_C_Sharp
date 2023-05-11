using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{

    internal class Program
    {
        public static async Task<string> BuyCar(string nameClient)
        {
            Console.WriteLine(nameClient + " Foi comprar um carro");
            await Task.Delay(1000);
            Console.WriteLine(nameClient + " Está comprando um carro");
            await Task.Delay(1000);
            Console.WriteLine(nameClient + " Comprou um carro");
            await Task.Delay(1000);
            return "Carro comprado";

        }
        public static async void Party()
        {
            string car = await BuyCar("Isaque");
            Console.WriteLine(car);
        }
        static void Main(string[] args)
        {
            Party();
            Console.ReadKey();
        }
    }
}
