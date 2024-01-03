using System;

namespace E_045_feladat
{
    internal class Program
    {
        static void Main()
        {
            // Többdimenziós tömbök (mátrixok) //

            /* D-45. Töltsön fel egy A és B nevű tömböt 1 és 100 közötti értékekkel.
             * Írja ki a két tömb értékeit növekvő sorrendben, anélkül, hogy új tömböt hozna létre! */

            Random rnd = new Random();
            int elemszam;

            Console.WriteLine("Két külön tömb [A és B] létrehozása 1 és 100 közötti véletlen számokkal!");
            Console.Write("A tömbök hány elemet tartalmazzanak?: ");
            elemszam = Convert.ToInt32(Console.ReadLine());

            // A és B nevű tömb létrehozása 6 elemszámmal:
            int[] A = new int[elemszam];
            int[] B = new int[elemszam];


            for (int i = 0; i < elemszam; i++)
            {
                A[i] = rnd.Next(1, 101);
                B[i] = rnd.Next(1, 101);

                Console.WriteLine($"{A[i]} {B[i]}");
            }

            // az A tömb elemeinek növekvő sorrendbe állítása
            Console.WriteLine("\nAz A tömb növekő sorrendbe állítva: ");
            Array.Sort( A );

            for (int i = 0; i < elemszam; i++)
            {
                Console.Write($"{A[i] + " "}");
            }


            // a B tömb elemeinek növekvő sorrendbe állítása
            Console.WriteLine("\n\nA B tömb növekő sorrendbe állítva: ");
            Array.Sort(B);

            for (int i = 0; i < elemszam; i++)
            {
                Console.Write($"{B[i] + " "}");
            }

            Console.ReadKey();
        }
    }
}
