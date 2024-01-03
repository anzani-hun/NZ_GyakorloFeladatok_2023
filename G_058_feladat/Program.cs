using System;

namespace G_058_feladat
{
    internal class Program
    {
        static void Main()
        {
            // Dátummal és idővel kapcsolatos feladatok //
            /* G-58. Bekér egy dátumot és kiírja, a hét melyik napjára esik. */
            
            //dátum bekérése, majd tryparse a formátum tartásához, ha nem jó írja ki hogy rossz a dátum 

            string datumBekeres;
            Console.Write("Kérek egy dátumot [pl: 2000-01-28]: ");
            datumBekeres = Console.ReadLine();


            //TRYPARSE alkalmazása
            if (DateTime.TryParse(datumBekeres, out DateTime sikeresAdat))
            {
                //azonosítja a napot
                DayOfWeek dayOfWeek = sikeresAdat.DayOfWeek;

                Console.WriteLine($"{datumBekeres} a válaszott dátum! Erre a napra esik --> {dayOfWeek}");
            }
            else
            {
                Console.WriteLine("Rossz formátumban adtad meg a dátumot! 2000-01-28 vagy 2000.01.28");
            }

            Console.ReadKey();
        }
       
        
    }
}
