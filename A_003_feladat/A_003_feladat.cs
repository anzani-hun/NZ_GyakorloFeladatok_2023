using System;


namespace A_003_feladat
{
    class Program
    {
        static void Main()
        {

            /*  3.	Deciliterben megadott térfogatot bontsunk hektoliter, liter, deciliter egységekre!  */


            /* INFÓK:
            1 hektoliter = 1000 deciliter
            1 liter = 10 deciliter
             */

            double deciliter_bekert, hektoliter, liter;

            Console.Write("Kérem adja meg a térfogatot dl-ben, majd ezeket átváltjuk hl és l egységekre: ");
            deciliter_bekert = Convert.ToDouble(Console.ReadLine());

            hektoliter = deciliter_bekert / 1000;
            liter = deciliter_bekert / 10;


            Console.WriteLine($"{deciliter_bekert} deciliter -> {hektoliter}" + " hektoliter");
            Console.WriteLine($"{deciliter_bekert} deciliter -> {liter}" + " liter");
            Console.ReadKey(true);

        }
    }
}
