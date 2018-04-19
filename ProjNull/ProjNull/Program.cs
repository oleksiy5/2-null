using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ProjNull
{
    class Program
    {
        const string path = @"c:\moj_folder\plik_test.txt";

        static void Main(string[] args)
        {
            string txt = null;

            if (File.Exists(path))
            {
                txt = File.ReadAllText(path);
            }

            if (txt == null)
                Console.WriteLine("Nie udało się przeczytać pliku");
            else
                Console.WriteLine(txt);

            Console.ReadKey();
        }
    }
}
