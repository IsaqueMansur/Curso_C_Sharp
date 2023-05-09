using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MutexESemaphore
{
    internal class Program
    {
        static Mutex mutex = new Mutex();
        static Semaphore semaphore = new Semaphore(2, 2);

        static void PrintMessage(int numberOfTask)
        {
            //mutex.WaitOne();
            semaphore.WaitOne();
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Número da task: " + numberOfTask + ". Número do contador: " + i);
                Thread.Sleep(200);
            }
            semaphore.Release();
            //mutex.ReleaseMutex();
        }
        static void Main(string[] args)
        {
            Task t1 = Task.Run(() => PrintMessage(1));
            Task t2 = Task.Run(() => PrintMessage(2));
            Task t3 = Task.Run(() => PrintMessage(3));
            Task t4 = Task.Run(() => PrintMessage(4));

            Console.ReadKey();

        }
    }
}
