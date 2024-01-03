using System;

namespace B_032_feladat
{
    internal class Program
    {
        static void Main()
        {
            /*32. Írjon egy programot, ami leosztályoz (betűvel és számmal) egy maximálisan 100 pontos dolgozatot az 50, 65, 80, 90 ponthatárok szerint!
             * A határérték a jobb jegyhez tartozik. Ha a pontszám negatív vagy száznál nagyobb, akkor a program írja ki, hogy hibás az adat!  */

            int adatbekeres;
            string erdemjegy, erdemjegySzoveggel;

            Console.Write("Hány pontos lett a dolgozat? ");
            adatbekeres = Convert.ToInt32(Console.ReadLine());


            erdemjegy = Kiszamol(adatbekeres);
            erdemjegySzoveggel = KiszamolJegy(adatbekeres);

            if ( adatbekeres < 0 || adatbekeres > 100 )
            {
                Console.WriteLine("Az elért pontszámot csak 0 és 100 között lehet megadni!");
            }
            else
            {
                Console.WriteLine($"A dolgozatra kapott összes pontszám: { adatbekeres } --> ÉRDEMJEGYE: { erdemjegySzoveggel } azaz { erdemjegy }");
            }

            Console.ReadKey();

        }

        static public string Kiszamol(int konvertal)
        {
            if ( konvertal >= 0 && konvertal < 50 )
            {
                return "ELÉGTELEN";
            }
            else if ( konvertal >= 50 && konvertal < 65)
            {
                return "ELÉGSÉGES";
            }
            else if ( konvertal >= 65 && konvertal < 80 )
            {
                return "KÖZEPES";
            }
            else if ( konvertal >= 80 && konvertal < 90 )
            {
                return "JÓ";
            }
            else
            {
                return "JELES";
            }
        }


        static public string KiszamolJegy(int konvertal)
        {
            if (konvertal >= 0 && konvertal < 50)
            {
                return "1";
            }
            else if (konvertal >= 50 && konvertal < 65)
            {
                return "2";
            }
            else if (konvertal >= 65 && konvertal < 80)
            {
                return "3";
            }
            else if (konvertal >= 80 && konvertal < 90)
            {
                return "4";
            }
            else
            {
                return "5";
            }
        }
    }
}
