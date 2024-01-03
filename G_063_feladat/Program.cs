using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_063_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* G-63. Ön hány napos? */

            //születési dátum megadása, Jelenlegi időpont meghatározása, különbség kiszámolása (mostani dátum - szül dátum)
            //ezt napokban kiírni.
            //ha a napokat osztom /365-el akkor megkapjuk az évek számát!

            string szuletesiDatum;
            Console.WriteLine("Kérem a születési dátumod, és megmondom hány napos és éves vagy!");
            szuletesiDatum = Console.ReadLine();

            if (DateTime.TryParse(szuletesiDatum, out DateTime szuletesiDatumMegfelelo))
            {
                //a mostani időpont lekérése
                DateTime mostaniDatum = DateTime.Now;
                //Console.WriteLine(mostaniDatum);

                //a két dátum különbsége
                TimeSpan datumKulonbseg = (mostaniDatum - szuletesiDatumMegfelelo);

                //a különbség napokban
                int evNapokban = (int)datumKulonbseg.TotalDays;
                Console.WriteLine($"\nEnnyi napos vagy: {evNapokban} --> Ez évben meghatározva: {evNapokban / 365}");

            }
            else
            {
                Console.WriteLine("Rossz dátumformátumot adtál meg! A helyes formátum: [2000.01.01] vagy [2000-01-01]");
            }

            Console.ReadKey();
        }
    }
}
