using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Kerek egy egesz szamot, melynek az ertekeit kiirom cimletezve: ");
            int osszeg = int.Parse(Console.ReadLine());

            List<int> bankjegyek = new List<int> { 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5 };

            foreach (int osszeg in bankjegyek)
            {
                if (osszeg >= bankjegyek)
                {
                    int darab = osszeg / banjegyek;
                    Console.WriteLine($"{darab} {osszeg]");
                }
            }

            Console.WriteLine("\nProgram vége");
            Console.ReadKey();
        }
    }
