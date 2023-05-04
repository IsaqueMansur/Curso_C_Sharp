using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("--------FILA--------");

            Queue<string> queueOfNames = new Queue<string>();

            //Add elements
            queueOfNames.Enqueue("a");
            queueOfNames.Enqueue("b");
            queueOfNames.Enqueue("c");
            queueOfNames.Enqueue("d");

            //Removing elements
            string removedName = queueOfNames.Dequeue();
            Console.WriteLine("Removido: " + removedName);
            
            foreach(string name in queueOfNames) 
            { 
                Console.WriteLine(name);
            }

            Console.WriteLine("--------------------");

            //Watch element
            string nameWatched = queueOfNames.Peek();
            Console.WriteLine("Elemento assistido: " + nameWatched);

            //Stack
            Stack<string> stackOfNames = new Stack<string>();
            stackOfNames.Push("a2");
            stackOfNames.Push("b2");
            stackOfNames.Push("c2");
            stackOfNames.Push("d2");

            Console.WriteLine();
            Console.WriteLine("--------PILHA--------");
            //Removing Elements
            string removedName2 = stackOfNames.Pop();
            Console.WriteLine("Removido da pilha: " + removedName2);

            //Watch element
            string nameWatched2 = stackOfNames.Peek();
            Console.WriteLine("Elemento da pilha assistido: " + nameWatched2);

            //Possuem os mesmos métodos das LISTAS

            Console.ReadKey();

        }
    }
}
