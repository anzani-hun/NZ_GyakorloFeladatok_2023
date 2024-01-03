using System;

namespace G_059_feladat
{
    internal class Program
    {
        static void Main()
        {
            // Dátummal és idővel kapcsolatos feladatok //
            /* G-59. Bekér egy dátumot és magyarul írja ki, hogy a hét melyik napjára esik. */

            //dátum bekérése, majd tryparse a formátum tartásához, ha nem jó: írja ki hogy rossz a dátum 
            //switch case függvény az angolról magyarra fordításra.


            string datumBekeres;
            Console.Write("Kérek egy dátumot [pl: 2000-01-28]: ");
            datumBekeres = Console.ReadLine();



            //TRYPARSE alkalmazása
            if (DateTime.TryParse(datumBekeres, out DateTime sikeresAdat))
            {
                //azonosítja a napot magyarul
                NapMagyarul(sikeresAdat.DayOfWeek);

                Console.WriteLine($"{datumBekeres} a válaszott dátum! Erre a napra esik --> {NapMagyarul(sikeresAdat.DayOfWeek)}");
            }
            else
            {
                Console.WriteLine("Rossz formátumban adtad meg a dátumot! [2000-01-28] vagy [2000.01.28]");
            }

            Console.ReadKey();
        }


        //SWITCH case függvény az adott nap magyarra fordítására!
        static string NapMagyarul(DayOfWeek nap)
        {
            switch (nap)
            {
                case DayOfWeek.Monday:
                    return "HÉTFŐ";
                case DayOfWeek.Tuesday:
                    return "KEDD";
                case DayOfWeek.Wednesday:
                    return "SZERDA";
                case DayOfWeek.Thursday:
                    return "CSÜTÖRTÖK";
                case DayOfWeek.Friday:
                    return "PÉNTEK";
                case DayOfWeek.Saturday:
                    return "SZOMBAT";
                case DayOfWeek.Sunday:
                    return "VASÁRNAP";
                default:
                    return "Nincs ilyen nap";
            }
        }
    }
}
