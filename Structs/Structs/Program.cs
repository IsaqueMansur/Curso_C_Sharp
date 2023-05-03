using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        struct DatasOfCadaster
        {
            public string name;
            public string nameOfWay;
            public UInt32 NumberOfHome;
            public DateTime dateOfBirth;
        }
        static void Main(string[] args)
        {
            DatasOfCadaster myCadaster;
            myCadaster.name = "Isaque Mansur";
            myCadaster.nameOfWay = "Pç Guanabara";
            myCadaster.NumberOfHome = 54;
            myCadaster.dateOfBirth = Convert.ToDateTime("31/10/2000");
            Console.WriteLine(myCadaster.name);
            Console.ReadKey();
        }
    }
}
