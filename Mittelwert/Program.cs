using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Nico Bauer
/// IS218
/// AWE
/// Arithmetischer Mittelwert berechnen
/// </summary>

namespace Mittelwert
{
    class Program
    {
        static void Main(string[] args)
        {
            double anzahl = 0;
            double mittel = 0;
            double sum = 0;
            int temp = 0;
            int zähler = 0;
            string weitermachen = "";

            do
            {
                Console.WriteLine("\nWie viele Zahlen möchten Sie eingeben?");
                anzahl = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nBitte geben Sie Ihre Zahlen ein!");

                /*for (int i = 0; i < anzahl; i++)
                {
                    sum += Convert.ToDouble(Console.ReadLine());
                }

                while(zähler < anzahl)
                {
                    sum += Convert.ToDouble(Console.ReadLine());
                    zähler++;
                }
                */
                do
                {
                    sum += Convert.ToDouble(Console.ReadLine());
                    zähler++;
                }
                while (zähler < anzahl);
                
                mittel = sum / anzahl;

                Console.WriteLine("\nDer arithmetische Mittelwert lautet: {0}", mittel);

                Console.WriteLine("\nGeben Sie bitte (j) ein, um einen weiteren arithmetischen Mittelwert zu berechnen!");
                weitermachen = Console.ReadLine();
            }
            while (weitermachen == "j");
        }
    }
}