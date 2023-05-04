using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ListOfNames = new List<string>();

            //Add Elements
            ListOfNames.Add("Isaque");
            ListOfNames.Add("José");
            ListOfNames.Add("Pedro");
            ListOfNames.Add("Aline");

            //Remove Elements
            ListOfNames.Remove("José");

            //Remove Elements per index
            ListOfNames.RemoveAt(2);


            foreach(string name in ListOfNames) 
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("----------------------------------");

            List<string> ListOfNames2 = new List<string>();

            ListOfNames2.Add("Isaque2");
            ListOfNames2.Add("José2");
            ListOfNames2.Add("Pedro2");
            ListOfNames2.Add("Aline2");


            //Remove a range of elements
            ListOfNames2.RemoveRange(0, 2);

            foreach (string name in ListOfNames2)
            {
                Console.WriteLine(name);
            }

            //Get a lenght of List
            Console.WriteLine("Tamanho da lista: " + ListOfNames2.Count);


            Console.WriteLine("----------------------------------");

            //Concat two Lists
            List<string> ConcatenedList = ListOfNames.Concat(ListOfNames2).ToList();

            foreach (string name in ConcatenedList)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("----------------------------------");

            //Verify if List Contains determined value
            bool containsName = ListOfNames2.Contains("Aline2");
            Console.WriteLine(containsName);

            List<string> FindedList = ListOfNames2.FindAll(name => name.Contains("Ped"));
            Console.WriteLine(FindedList[0]);

            //FindIndex using Contains
            int indexFindedInListNames2 = ListOfNames2.FindIndex(name => name.Contains("Pedr"));
            Console.WriteLine(indexFindedInListNames2);

            //Where operator
            List<string> whereList = ConcatenedList.Where(x => x.StartsWith("A")).ToList();
            foreach (string name in whereList)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
