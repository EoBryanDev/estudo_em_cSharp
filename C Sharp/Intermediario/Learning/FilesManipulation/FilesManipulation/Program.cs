using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sourcepath = @"C:\Users\Bryan\OneDrive\Área de Trabalho\file.txt";

            FileStream fs = null;
            StreamReader sr = null;

            try
            {

                fs = new FileStream(sourcepath, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
                
            }catch (IOException e)
            {
                Console.WriteLine($"An error occured: \n {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
