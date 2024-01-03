using System;


namespace C_023_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C-23. A gép véletlenszerűen találjon ki egy számot 1 és 100 között! A felhasználótól kérjen be
                      tippeket, és mondja meg, hogy a gondolt szám a tipptől nagyobb-e vagy kisebb! A tippelés
                      addig megy, amíg a felhasználó el nem találta a megadott számot.*/

            Random randomGenerator = new Random();
            int veletlenSzam = randomGenerator.Next(1, 101); 
            //Console.WriteLine($"Véletlenszám: {veletlenSzam}");//

            int tipp;

            Console.WriteLine("Ez egy számkitalálós játék, a gép 1 és 100 közötti számot választ, TALÁLD EL!\n");

            do
            {
                Console.Write("Tippeld meg a számot:");
                tipp = Convert.ToInt32(Console.ReadLine());

                if (tipp < veletlenSzam)
                {
                    Console.WriteLine("A szám NAGYOBB");
                }

                else if (tipp > veletlenSzam)
                {
                    Console.WriteLine("A szám KISEBB");
                }

                else
                {
                    Console.WriteLine($"\nSikerült kitaláltad a számot! A gépi szám: {veletlenSzam} volt!");
                }
            }
            while (tipp != veletlenSzam);

            Console.ReadKey();
        }
    }
}
