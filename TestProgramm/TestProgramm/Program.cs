using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//*** Konvertierung in Zahlensystemen

namespace TestProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Titel("das ist ein Text");
            Console.ReadKey();
        }

        static void Titel(string Titel)
        {
            // was gemacht wird:

            Console.Clear();

            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine(Titel);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
        }//
    }
}
