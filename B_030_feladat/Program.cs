using System;


namespace B_030_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* 30. Készítsünk programot, amely bekéri a víz hőmérsékletét, majd eldönti, hogy az milyen halmazállapotú.
             * A halmazállapot lehet folyékony, gőz, vagy jég. */

            // jég: 0° fok alatt, folyékony 0°-100° között, gőz 100° felett

            double homerseklet;
            string halmazallapot;

            Console.WriteLine("Add meg a víz hőmérsékletét, és kiirjuk a halmazállapotát: ");
            homerseklet = Convert.ToDouble(Console.ReadLine());

            if ( homerseklet >= 0 && homerseklet <= 100 )
            {
                Console.WriteLine("VÍZ");
            }
            else if ( homerseklet < 0 )
            {
                Console.WriteLine("JÉG");
            }
            else
            {
                Console.WriteLine("GŐZ");
            }

            Console.ReadKey();
        }
    }
}
