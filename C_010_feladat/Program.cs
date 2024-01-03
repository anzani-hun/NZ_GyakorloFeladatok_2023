using System;

namespace C_010_feladat
{
    internal class Program
    {
        static void Main()
        {
            // C-10. Bekér két számot és kiírja az első szám második számnak megfelelő hatványát!

            // INFÓ: 5 a 6hatodikon   ||| 5 --> hatvanyAlap    6 --> hatvanyKitevo     eredmény --> hatvány

            double szam1, szam2, eredmeny;
         
            Console.Write("Kérem az első számot [ami a hatványalap lesz]: ");
            szam1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kérem a második számot [ami a hatványkitevő lesz]: ");
            szam2 = Convert.ToInt32(Console.ReadLine());


            eredmeny = Math.Pow(szam1, szam2);

            // függvény eredmenye= Math.Pow(hatvanyAlap, hatvanyKitevo //

            Console.WriteLine($"Az alapSzám: {szam1} és a kitevője: {szam2} --> és az elvégzett hatványozás eredménye: {eredmeny} ");

            Console.ReadKey();
        }
    }
}
