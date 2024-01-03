using System;

namespace C_019_feladat
{
    internal class Program
    {
        static void Main()
        {
            // C-19. Bekér két számot és kiírja a legnagyobb közös osztót. //

            /*Euklideszi algoritmus.
             * elsőnek a két szám osztásával kezdeni: a / b
                Az eredményként kapott maradék lesz az új a, és az eredeti b lesz az új b.
                Ismételd meg az első két lépést addig, amíg a maradék nem lesz 0.
                A legutolsó nem 0 maradék lesz a két szám legnagyobb közös osztója.
                
                pl: 28 és 21  LKO-ja 7
                    60 és 48  LKO-ja 12

             */


            Console.WriteLine("Két számnak a legnagyobb közös osztója!");

            int szam1, szam2, LKO;

            Console.Write("Kérem az első számot: ");
            szam1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kérem a második számot: ");
            szam2 = Convert.ToInt32(Console.ReadLine());

            //meghívjuk a lenti függvényt
            LegnagyobbKozosOszto(szam1, szam2);

            Console.WriteLine($"{szam1} és {szam2} legnagyobb közös osztója: {LegnagyobbKozosOszto(szam1, szam2)}");

            Console.ReadKey();
        }



        //új függvény a legnagyobb közös osztóra:
        static int LegnagyobbKozosOszto(int egyik, int masik)
        {
            int maradek;

            while (masik != 0)
            {
                maradek = egyik % masik;
                egyik = masik;
                masik = maradek;
            }
            return egyik;
        }
    }
}
