using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesMatematicasAvancadas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Potenciação
            double potenciacao = Math.Pow(4, 2);
            Console.WriteLine(potenciacao);

            //Radiação
            double raiz = 3;
            double radiacao = Math.Pow(27, 1 / raiz);
            Console.WriteLine(radiacao);

            //Máximo e o mínimo
            double maximo = Math.Max(4, 8);
            Console.WriteLine(maximo);

            double minimo = Math.Min(4, 8);
            Console.WriteLine(minimo);

            //Módulo
            double modulo = Math.Abs(-15000);
            Console.WriteLine(modulo);

            //Operações trigonométricas
            double angulo = 30 * (2 * Math.PI) / 360;
            double seno = Math.Sin(angulo);
            Console.WriteLine(seno);

            //Arcseno
            double arseno = Math.Asin(seno);
            double arcSenoGraus = arseno * 360 / (2 * Math.PI);
            Console.WriteLine(arcSenoGraus);

            //Arrendondar
            double numero = 3.33;
            double arroundParaCima = Math.Ceiling(numero);
            Console.WriteLine(arroundParaCima);
            double arroundParaBaixo = Math.Ceiling(numero);
            Console.WriteLine(arroundParaBaixo);

            //Logaritmo
            double base10 = Math.Log10(100);
            Console.WriteLine(base10);

            double baseE = Math.Log(Math.E * Math.E * Math.E);
            Console.WriteLine(baseE);


            Console.ReadKey();
        }
    }
}
