using System;


namespace B_025_feladat
{
    internal class Program
    {
        static void Main()
        {
            // 25.	Kérjen be 2 számot és a nagyobbat ossza el a kisebbel! Az eredményt 2 tizedesjegy pontossággal írja ki! (Nullával nem lehet osztani!) //

            double szam1, szam2, szamCsere, vizsgal;

            Console.WriteLine("Kérjen be 2 számot és a nagyobbat ossza el a kisebbel.");
            Console.Write("Kérem az első számot: ");
            szam1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérem a második számot: ");
            szam2 = Convert.ToDouble(Console.ReadLine());


            //kiválasztja a két szám közül közül a nagyobbat és a kisebbet. Math.Max - Math.Min
            vizsgal = Math.Max(szam1, szam2) / Math.Min(szam1, szam2);


            // ha szam1 egyenlő nullával vagy szam2 egyenlő nullával, akkor kiírja, hogy nullával nem lehet osztani
            if (szam1 == 0 || szam2 == 0)
            {
                Console.Write("Nullával NEM lehet osztani!");
            }
            else
            {
                Console.Write($"Az osztás eredménye: { Math.Round(vizsgal, 2) }");
            }

            Console.ReadKey();



            /* ezzel nem működött megfelelően.
            különben vizsgálja meg, hogy szam2 nagyobb-e szam1-nél, ha igen akkor cserélje meg őket
            else if (szam1 < szam2)
            {
                szamCsere = szam2;
                szam2 = szam1;
                szam1 = szamCsere;

                Console.WriteLine($"Az osztás: { Math.Round(szam1 / szam2), 2 }");
            }

            //különben mehet az osztás egyből
            else
            {
                Console.WriteLine($"Az osztás: { Math.Round(szam1 / szam2), 2 }");
            }
            */

        }
    }
}
