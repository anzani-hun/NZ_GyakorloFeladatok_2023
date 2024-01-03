using System;

namespace D_027_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* TÖMBÖK */
              
             /* D-27. Bekér 5 db számot és kiírja, ezek közül a legnagyobbat. */

            int legnagyobbSzamKeres;

            Console.WriteLine("Kérek 5 darab számot, és megmondom melyik a legnagyobb!");

            //5 elememű tömb létrehozása [0-4 indexig]
            int [] tomb = new int[5];

            //for ciklus a tömb feltöltéséhez 0-val kezdjük
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a/z/ {i + 1}. számot: ");  //mivel 0.inex-el kezdi a feltöltést, ezért hozzáadunk egyet a kiiratás miatt
                tomb[i] = int.Parse(Console.ReadLine());
                //Console.WriteLine(tomb[i]);
            }


            // a legelső elemmel kezdjük a bejárást.
            legnagyobbSzamKeres = tomb[0];      
            for ( int i = 1; i < tomb.Length; i++ )
            {
                if (tomb[i] > legnagyobbSzamKeres)
                {
                    legnagyobbSzamKeres = tomb[i];
                }
            }

            Console.WriteLine($"\nA bevitt értékek közül a legnagyobb számunk --> {legnagyobbSzamKeres}");
            Console.WriteLine($"\nA tömb elemeinek a száma: {tomb.Length}");
            Console.ReadKey();
        }
    }
}
