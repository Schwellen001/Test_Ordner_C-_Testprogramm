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
            Titel("Dies ist kein RAM 1500");
            Console.ReadKey();
        }

        static void Titel(string Titel)
        {
            // was gemacht wird:


            int Breite = Console.WindowWidth;
            int textln = Titel.Length;

            Console.Clear();

            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }

            for (int i = 0; i < (Breite - textln)/2; i++)
            {
                Console.Write(" ");   
            }

            Console.WriteLine(Titel);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
        }//
    }
}
