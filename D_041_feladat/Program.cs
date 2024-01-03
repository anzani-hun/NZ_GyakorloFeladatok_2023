using System;

namespace D_041_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* D-41. Számítsa ki a gép 10 véletlen szám összegét, szorzatát, átlagát és írjuk ki a képernyőre */

            Random rnd = new Random();
            int[] tomb = new int[10];

            Console.WriteLine("10 véletlen szám összege, szorzata és átlaga!\n");


            //for ciklussal a tömb feltöltése
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next();
                Console.WriteLine(tomb[i]);
            }


            //a vizsgálandó változók meghatározása, szorzat értékét 1-re a szorzás miatt:
            int szorzata = 1;
            int osszege = 0;
            double atlaga = 0;



            //for ciklus a sorzat meghatározásához
            for (int i = 0; i < tomb.Length; i++)
            {
                szorzata *= tomb[i];
            }



            //for ciklus az összes elem összegének a meghatárázásához
            for (int i = 0; i < tomb.Length; i++)
            {
                osszege += tomb[i];
            }



            //atlagot a tömbök bejárása utána számítunk
            atlaga = (osszege / tomb.Length);



            //EREDMÉNYEK kiíratása:
            Console.WriteLine($"\nA tömb összes elemének a sorzata: {szorzata}");
            Console.WriteLine($"A tömb összes elemének az összege: {osszege}");
            Console.WriteLine($"A tömb összes elemének az átlaga: {atlaga}");

            Console.ReadKey();
        }
    }
}
