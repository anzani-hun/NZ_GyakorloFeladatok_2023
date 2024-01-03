using System;

namespace B_022_feladat
{
    internal class Program
    {
        static void Main()
        {
            //22.	egy tetszőleges számról mondjuk meg, hogy osztható-e maradék nélkül 3-mal!

            int szam;

            Console.Write("Kérek egy számot: ");
            szam = Convert.ToInt32(Console.ReadLine());

            if (szam % 3 == 0)
            {
                Console.WriteLine("A megadott szám osztható hárommal, mert nincs maradék");
            }
            else
            {
                Console.WriteLine("A megadott szám nem osztható hárommal, mert van maradék.");
            }

            Console.ReadKey();
        }
    }
}
