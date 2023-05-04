using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManipulandoArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathFile = "c:\\teste\\teste.txt";
            string pathFile2 = "c:\\teste\\pasta\\novo.txt";

            //VerifyIfExists
            bool verifyIfFileExists = File.Exists(pathFile);
            if (verifyIfFileExists)
                Console.WriteLine("O arquivo existe");
            else
                Console.WriteLine("O arquivo não existe");

            //Create
            FileStream myFile = File.Create(pathFile);
            myFile.Close();

            //Write
            File.WriteAllText(pathFile, "sahdfaghfdsgsah\r\nBolo");

            //Delete
            File.Delete(pathFile);

            //Move with rename (its possible using separate) 
            FileStream myFile2 = File.Create(pathFile);
            myFile2.Close();
            File.Move(pathFile, pathFile2);
            File.WriteAllText(pathFile2, "Seilá\r\nBolo");

            //Write from array
            string[] contentArray = { "A", "B", "C", "D" };
            File.WriteAllLines(pathFile2, contentArray);

            //Read all content of file
            string contentRead = File.ReadAllText(pathFile2);
            Console.Write("Content: " + contentRead);

            //Read the content of a file and saving datas on array of strings
            Console.WriteLine("-----------------------------------");
            string[] contentArrayString = File.ReadAllLines(pathFile2);
            foreach (string content in contentArrayString)
            {
                Console.WriteLine(content);
            }

            //Add text in file
            File.AppendAllText(pathFile2, "JOSÉ");


            File.Delete(pathFile2);
            Console.ReadKey();

        }
    }
}
