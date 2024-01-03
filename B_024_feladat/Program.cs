using System;
using System.Diagnostics.Eventing.Reader;


namespace B_024_feladat
{
    internal class Program
    {
        static void Main()
        {
            // 24.	Olvassa be egy hónap számát, majd írja ki, hogy melyik évszakban van az adott hónap. //

            /*ÉVSZAKOK elosztása HÓNAPOK szerint:
                 Tavasz: március 21. - június 20.   || 3,4,5
                 Nyár: június 21. - szeptember 22.  || 6,7,8
                 Ősz: szeptember 23. - december 20. || 9,10,11
                 Tél: december 21. - március 20.    || 1,2,12
             */


            int bekertHonap;

            Console.WriteLine("Kérek egy hónap számot [1-12], majd kiírja melyik évszakban van az adott hónap: ");
            bekertHonap = Convert.ToInt32(Console.ReadLine());



            if (bekertHonap >= 1 && bekertHonap <= 12)
            {

                switch (bekertHonap)
                {
                    //TÉL: DECEMBER - JANUÁR - FEBRUÁR
                    case 1:
                        Console.WriteLine($"A kiválaszott hónap száma: {bekertHonap} --> TÉL");
                        break;
                    case 2:
                        Console.WriteLine($"A kiválaszott hónap száma: {bekertHonap} --> TÉL");
                        break;
                    case 12:
                        Console.WriteLine($"A kiválaszott hónap száma: {bekertHonap} --> TÉL");
                        break;


                    //TAVASZ: MÁRCIUS - ÁPRILIS - MÁJUS
                    case 3:
                        Console.WriteLine($"A kiválaszott hónap száma: {bekertHonap} --> TAVASZ");
                        break;
                    case 4:
                        Console.WriteLine($"A kiválaszott hónap száma: {bekertHonap} --> TAVASZ");
                        break;
                    case 5:
                        Console.WriteLine($"A kiválaszott hónap száma: {bekertHonap} --> TAVASZ");
                        break;


                    //NYÁR: JÚNIUS - JÚLIUS - AUGUSZTUS
                    case 6:
                        Console.WriteLine($"A kiválaszott hónap száma: {bekertHonap} --> NYÁR");
                        break;
                    case 7:
                        Console.WriteLine($"A kiválaszott hónap száma: {bekertHonap} --> NYÁR");
                        break;
                    case 8:
                        Console.WriteLine($"A kiválaszott hónap száma: {bekertHonap} --> NYÁR");
                        break;


                    // ŐSZ: SZEPTEMBER - OKTÓBER - NOVEMBER
                    case 9:
                        Console.WriteLine($"A kiválaszott hónap száma: {bekertHonap} --> ŐSZ");
                        break;
                    case 10:
                        Console.WriteLine($"A kiválaszott hónap száma: {bekertHonap} --> ŐSZ");
                        break;
                    case 11:
                        Console.WriteLine($"A kiválaszott hónap száma: {bekertHonap} --> ŐSZ");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ilyen hónap nem létezik. CSAK 1-12-ig lehet hónapot megadni.");
            }



            Console.ReadKey();
        }
    }
}
