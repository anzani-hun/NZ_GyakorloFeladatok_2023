using System;
using System.Text;


namespace A_006_feladat
{
    class Program
    {
        static void Main()
        {

            /*  Celsiusban megadott értéket (°𝐶) átvált Fahrenheitre 2 tizedes pontossággal.  */

            /*INFÓ:
             KÉPLET: F = C * 9/5 + 32;
             */

            double bekert_celsius, fahrenheitra_atvalt, kerekitve;

            Console.WriteLine("Celsiusban (°C) megadott hőmérséklet értéket átváltunk Fahrenheitre (°F) 2 tizedes pontossággal.");
            Console.Write("Kérek egy hőmérsékletet: ");
            bekert_celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheitra_atvalt = (bekert_celsius * 9 / 5 + 32);
            kerekitve = Math.Round(fahrenheitra_atvalt, 2);

            Console.WriteLine($"A bevitt hőmérséklet: {bekert_celsius} °C, átváltva: --> {kerekitve} °F");

            Console.ReadKey(true);
        }
    }
}
