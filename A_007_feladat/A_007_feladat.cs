using System;
using System.Text;


namespace A_007_feladat
{
    class Program
    {
        static void Main()
        {
            /*  Fahrenheitben megadott értéket (°𝐹) átvált Celsiusra 2 tizedes pontossággal   */

            /*INFÓ:
             [°C] = ([°F] − 32) ×   5 ⁄ 9
             [°F] = [°C] ×   9 ⁄ 5  + 32
             */

            double bekert_fahrenheit, celsiusra_atvaltas, kerekit;

            Console.WriteLine("Fahrenheitben (°F) megadott hőmérsékletet átváltunk Celsiusra (°C) 2 tizedes pontossággal");
            Console.Write("Kérem a hőmérsékletet: ");
            bekert_fahrenheit = Convert.ToDouble(Console.ReadLine());

            celsiusra_atvaltas = (bekert_fahrenheit - 32) * 5 / 9;
            kerekit = Math.Round(celsiusra_atvaltas, 2);

            Console.WriteLine($"Az általunk megadott érték: {bekert_fahrenheit} °F, átváltva --> {kerekit} °C");
            Console.ReadKey(true);
        }
    }
}
