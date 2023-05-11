using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Timers
{
    internal class Program
    {
        static void TimerTick(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
        }

        static void TimerTick2(object state)
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss")); 
        }
        static void Main(string[] args)
        {
            //Timer com System.Timers
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.AutoReset = true;
            timer.Elapsed += TimerTick;
            timer.Start();
            Console.ReadKey();
            timer.Stop();

            //Timer com System.Threading
            TimerCallback tcb = new TimerCallback(TimerTick2);
            System.Threading.Timer myTimer = new System.Threading.Timer(tcb, null, 0, 1000);
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
            myTimer.Dispose();
        }
    }
}
