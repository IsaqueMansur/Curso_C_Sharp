using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_Avancado_
{
    internal class ParametersThread
    {
        public int StartCounter
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public ParametersThread(int startCounter, string name)
        {
            StartCounter = startCounter;
            Name = name;
        }
    }
    internal class Program
    {
        public static Mutex mutex = new Mutex();
        public static void Thread1()
        {
            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                mutex.WaitOne();
                counter++;
                Thread.Sleep(100);
                mutex.ReleaseMutex();

            } while (counter <= 100);
        }

        public static void Thread2(object initialCounter)
        {
            int counter = (int)initialCounter;
            do
            {
                Console.WriteLine(counter);
                mutex.WaitOne();
                counter++;
                Thread.Sleep(100);
                mutex.ReleaseMutex();

            } while (counter <= ((int)initialCounter + 100));
        }

        public static void Thread3(int counter, string name)
        {
            do
            {
                Console.WriteLine("Nome: " + name + ". TimerInformado: " + counter);
                mutex.WaitOne();
                counter++;
                Thread.Sleep(100);
                mutex.ReleaseMutex();

            } while (counter <= (counter + 100));
        }
        static void Main(string[] args)
        {   
            Thread thread1 = new Thread(new ThreadStart(Thread1));
            Thread thread2 = new Thread(new ParameterizedThreadStart(Thread2));
            Thread thread3 = new Thread(() => Thread3(100, "Isaque"));

            thread1.Start();
            thread2.Start(100);
            thread3.Start();

            Console.ReadKey();
            Console.Clear();
            
        }
    }
}
