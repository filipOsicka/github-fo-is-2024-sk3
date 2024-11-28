using System;

class Program
{
    static void Main()
    {
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("*********** 10to2 ***********");
            Console.WriteLine("******* Filip Osička ********");
            Console.WriteLine("*****************************\n\n");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte číslo v desítkové soustavě (přirozené číslo): ");
            uint cislo;
            while (!uint.TryParse(Console.ReadLine(), out cislo))
            {
                Console.Write("Nezadali jste přirozené číslo v desítkové soustavě. Zadejte první číslo znovu: ");
            }

            uint[] myArray = new uint[32];
            uint zaloha = cislo;
            uint zbytek;

            int i = 0;
            while (cislo > 0)
            {
                zbytek = cislo % 2;
                cislo = (cislo - zbytek) / 2;
                myArray[i] = zbytek;

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Celá část: {0}; zbytek = {1}", cislo, zbytek);
                Console.ResetColor();
                i++;
            }

            Console.WriteLine("Poslední použitý index pole : {0}", i - 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nVýsledek : ");

            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write("{0}", myArray[j]);
            }

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a' nebo stiskem jiného klávesy program ukončíte.");
            again = Console.ReadLine();
        }
    }
}