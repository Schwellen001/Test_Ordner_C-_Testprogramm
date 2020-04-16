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
            Titel("Dies ist kein RAM 1500", ConsoleColor.Red);

            Console.WriteLine("hallo Welt");
            
            Console.ReadKey();
        }

        static void Titel(string Titel, ConsoleColor textfarbe)
        {
            // was gemacht wird:


            int Breite = Console.WindowWidth;
            int textln = Titel.Length;
            ConsoleColor akT = Console.ForegroundColor; // aktutelle Farbe speichern

            Console.Clear();

            Console.ForegroundColor = textfarbe;

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

            Console.ForegroundColor = akT; 
        }//
    }
}
