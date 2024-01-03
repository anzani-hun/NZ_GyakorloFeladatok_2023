using System;


namespace C_022_feladat
{
    internal class Program
    {
        static void Main()
        {
            /* C-22. Készítsen programot, ami számokat kér be addig, míg az utolsó két szám meg nem egyezik! */

            Console.WriteLine("Számbekérés, amíg az utolsó két szám meg nem egyezik!");

            int szam1, szam2;
            
            szam2 = 0;  //szam2-őt ki kell nullázni

            Console.Write("Kérek egy egész számot: ");
            szam1 = Convert.ToInt32(Console.ReadLine());


            // a do ciklus törzsében lévő kód legalább egyszer lefut mindig.
            do
            {
                szam1 = szam2;

                Console.Write("Kérek egy újabb egész számot: ");
                szam2 = Convert.ToInt32(Console.ReadLine());

            }

            //a ciklus feltétele a while szó után áll, és ez a ciklus addig újra lefut míg nem teljesül
            //tehát szam1 nem egyenlő szam2-vel addig újra kéri be a következő számot.
            while ( szam1 != szam2 );

                Console.WriteLine($"\nA két utoljára bevitt szám megegyezik, ezért a program kilépett!");
            

            Console.ReadKey();
        }
    }
}
