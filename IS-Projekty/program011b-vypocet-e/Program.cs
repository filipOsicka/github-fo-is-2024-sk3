using System;

class Program
{
    static void Main()
    {
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("***********************");
            Console.WriteLine("**** Výpočet e ****");
            Console.WriteLine("*** Filip Osička ***");
            Console.WriteLine("***********************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte přesnost (reálné číslo - čím menší, tím přesnější výpočet bude): ");
            double presnost;
            while (!double.TryParse(Console.ReadLine(), out presnost))
            {
                Console.Write("Nezadali jste přesnost správně. Zadejte znovu: ");
            }

            double e = 1; // Začínáme s 1 (0! = 1)
            double faktorial = 1; // 0! = 1
            int n = 1;

            while (1.0 / faktorial >= presnost)
            {
                faktorial *= n; // Vypočítáme n!
                e += 1.0 / faktorial; // Přidáme 1/n!
                Console.WriteLine("Přidáno 1/{0}!; aktuální hodnota e = {1}", n, e);
                n++;
            }

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Hodnota čísla e = {0}", e);
            Console.WriteLine("Hodnota čísla e = {0:f4}", e);
            Console.WriteLine("========================================================");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();
        }
    }
}