using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Zadejte počet čísel: ");
            int pocetCisel = int.Parse(Console.ReadLine());

            Console.Write("Zadejte diferenci: ");
            int diference = int.Parse(Console.ReadLine());

            Console.Write("Zadejte první prvek posloupnosti: ");
            int prvniPrvek = int.Parse(Console.ReadLine());

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
            Console.WriteLine("Součet zobrazených hodnot: " + soucet);
        }
        catch (FormatException)
        {
            Console.WriteLine("Chyba: Zadejte platná čísla.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Nastala chyba: " + ex.Message);
        }

        // Zajištění, že konzole zůstane otevřená
        Console.WriteLine("Stiskněte libovolnou klávesu pro ukončení...");
        Console.ReadKey();
    }
}