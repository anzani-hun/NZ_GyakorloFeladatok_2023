using System;

namespace C_011_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C-11 - Állítsunk elő véletlenszerűen 40 egész számot a [-100,100]-ból, és írjuk ki a képernyőre egymás
            mellé 6 karakternyi helyet lefoglalva, de egy sorban csak 8 szám legyen!
            A kiírás végén adjuk meg hány darab pozitív szám van!*/

            int veletlenEgeszSzam;

            Console.WriteLine("40 darab random szám kiválasztása -100 és 100 között");

            Random randomGenerator = new Random();
            

            for (int i = 1; i <= 40; i++)
            {
                veletlenEgeszSzam = randomGenerator.Next(-100, 101);
                Console.WriteLine(i+". számunk: " + veletlenEgeszSzam,6);
            }

            Console.ReadKey();
        }
    }
}
