using System;

class Program
{
    static void Main()
    {
            Console.Write("Zadejte počet čísel: ");
            int pocetCisel = int.Parse(Console.ReadLine());

            Console.Write("Zadejte diferenci: ");
            int diference = int.Parse(Console.ReadLine());

            Console.Write("Zadejte první prvek posloupnosti: ");
            int prvniPrvek = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Počet čísel: {0}", pocetCisel);
            Console.WriteLine("Diference: {0}", diference);
            Console.WriteLine("První prvek: {0}", prvniPrvek);
            Console.WriteLine("========================================================");

            int soucet = 0;

            Console.Write("Aritmetická posloupnost: ");
            for (int i = 0; i < pocetCisel; i++)
            {
                int clenenPosloupnosti = prvniPrvek + i * diference;
                Console.Write(clenenPosloupnosti + "; ");
                soucet += clenenPosloupnosti; 
            }

            // Výstup součtu
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Součet zobrazených hodnot: " + soucet);
            Console.WriteLine("========================================================");
        // Zajištění, že konzole zůstane otevřená
        Console.WriteLine("Stiskněte libovolnou klávesu pro ukončení...");
        Console.ReadKey();
    }
}