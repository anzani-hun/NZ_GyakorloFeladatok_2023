using System;


namespace A_004_feladat
{
    class Program
    {
        static void Main()
        {

            /*4.    mm-ben megadott értéket bontsunk méterre, deciméterre, centiméterre, milliméterre!  */

            /*INFÓK: 
             1 méter = 10 deciméter (dm).
             1 méter = 100 centiméter (cm).
             1 méter = 1000 milliméter (mm).*/

            double bekert_millimeter, decimeter, centimeter, millimeter, meter;

            Console.Write("Kérek egy milliméterben megadott értéket [amiket majd átváltunk]: ");
            bekert_millimeter = Convert.ToDouble(Console.ReadLine());

            meter = bekert_millimeter / 1000;
            decimeter = bekert_millimeter / 100;
            centimeter = bekert_millimeter / 10;

            Console.WriteLine($"{bekert_millimeter} milliméter ---> {meter}" + " méter");
            Console.WriteLine($"{bekert_millimeter} milliméter ---> {decimeter}" + " deciméter");
            Console.WriteLine($"{bekert_millimeter} milliméter --->  {centimeter}" + " centiméter");


            Console.ReadKey(true);
        }
    }
}
