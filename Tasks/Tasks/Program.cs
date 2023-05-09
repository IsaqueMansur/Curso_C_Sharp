using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        static int PrintMessage(int counter)
        {
            for (int i = counter; i < (counter + 10); i++)
            {
                Console.WriteLine("Task: " + i.ToString());
                Thread.Sleep(500);
            }
            return 10;
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray; 
            Console.ForegroundColor = ConsoleColor.Blue;

            int resultOfTask = 0;
            Task taskPrintMessage = Task.Run(() => resultOfTask = PrintMessage(100));
            if(!taskPrintMessage.Wait(10000)) 
            {
                Console.WriteLine("A task não foi finalizada ainda");
            }
            else
            {
                Console.WriteLine(resultOfTask);
            }
            Console.ReadKey();
        }
    }
}
