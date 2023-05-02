using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAvancado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2022, 09, 06);
            DateTime dateWithHour = new DateTime(2022, 09, 06, 14, 10, 0);

            //Acessando informações das datas declaradas
            Console.WriteLine("Ano: " + dateWithHour.Year);
            Console.WriteLine("Mês: " + dateWithHour.Month);
            Console.WriteLine("Dia: " + dateWithHour.Day);
            Console.WriteLine("Hora: " + dateWithHour.Hour);
            Console.WriteLine("Minutos: " + dateWithHour.Minute);
            Console.WriteLine("Segundos: " + dateWithHour.Second);
            Console.WriteLine("Dia da semana: " + dateWithHour.DayOfWeek);
            Console.WriteLine("Formatado: " + dateWithHour.ToString());

            //Convertendo string em DateTime
            DateTime convertedDate = Convert.ToDateTime("22/11/2030 14:10:00");
            Console.WriteLine("Conversão da string para data: " + convertedDate);

            //Pegando a hora atual
            DateTime dateNow = DateTime.Now;
            Console.WriteLine("Data atual: " + dateNow.ToString());

            //Formatando a data e a hora impressa
            Console.WriteLine("Convertida para o jeito que quero: " + convertedDate.ToString("dd/MM/yyyy HH:mm"));

            //Operações com DateTime
            DateTime dateHourTwo = new DateTime(2022, 09, 27, 14, 5, 20);
            dateHourTwo = dateHourTwo.AddDays(4).AddMonths(1);
            Console.Write("Data usando o metodo 'AddDays': " + dateHourTwo + "\n");

            DateTime dateHourThree = dateHourTwo.Add(new TimeSpan(4, 10, 0, 0, 0)); //Suporta o método SUBTRACT
            Console.WriteLine("Usando o método ADD com TimeSpan: " + dateHourThree);

            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
