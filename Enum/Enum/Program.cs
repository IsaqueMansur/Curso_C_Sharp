using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        enum DaysOfWeek_e
        {
            Domingo = 1,
            Segunda,
            Terça,
            Quarta,
            Quinta,
            Sexta,
            Sábado,
        }

        static void Main(string[] args)
        {
            DaysOfWeek_e day = DaysOfWeek_e.Segunda;
            Console.WriteLine(day + " é o dia " + Convert.ToUInt32(day) + " da semana.");
            Console.ReadKey();
        }
    }
}
