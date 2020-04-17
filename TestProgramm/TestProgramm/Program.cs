﻿using System;
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
            Titel("Dies ist ein Test", ConsoleColor.Red);

            string binZahl = BinaerZahleinlesen(); 
            
            Console.ReadKey();
        }

        /// <summary>
        /// Gibt einen Text formatiert aus
        /// </summary>
        /// <param name="Titel">Text der ausgegeben werden soll</param>
        /// <param name="textfarbe">Farbe des Textes</param
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

        static string BinaerZahleinlesen()
        {
            Console.WriteLine("Bitte Zahl eingeben (0/1):");
            string Input = Console.ReadLine();
            return Input; 
        }//
    }
}
