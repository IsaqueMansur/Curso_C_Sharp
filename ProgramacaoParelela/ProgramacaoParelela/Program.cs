using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramacaoParelela
{
    internal class Program
    {
        static Thread t1;
        static Thread t2;
        static bool finishLooping;
        static UInt16 numberOfThread;
        static object objLock;
        static Mutex mutex;

        static void MyThread1()
        {
            while(!finishLooping)
            {
                mutex.WaitOne();
                numberOfThread = 1;
                Console.WriteLine("THREAD1: Passou 1 segundo, número da THREAD1:" + numberOfThread);
                Thread.Sleep(1000);      
                mutex.ReleaseMutex();
            }
        }

        static void MyThread2()
        {
            while (!finishLooping)
            {
                mutex.WaitOne();
                numberOfThread = 2;
                Console.WriteLine("THREAD2: Passou 1 segundo, número da THREAD2:" + numberOfThread);
                Thread.Sleep(1000);
                mutex.ReleaseMutex();                
            }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i ++)
            {
                Thread.Sleep(10);
                Console.WriteLine("Passou um segundo ("+(i + 1)+").");
            }

            finishLooping = false;
            objLock = new object();
            mutex = new Mutex();

            t1 = new Thread(new ThreadStart(MyThread1));
            t2 = new Thread(new ThreadStart(MyThread2));
            t1.Priority = ThreadPriority.BelowNormal;
            t2.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            Console.ReadKey();
            finishLooping = true;
            Console.ReadKey();

        }
    }
}
