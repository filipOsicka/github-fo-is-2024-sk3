using System;

class Program {
    
    static void Main() {
        Console.Clear();
        Console.WriteLine("***********************************");
        Console.WriteLine("*********Výpis číselné řady********");
        Console.WriteLine("***********Filip Osička************");
        Console.WriteLine("***********************************");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        // Vstup od uživatele
        //Console.WriteLine("Zadejte prvni číslo: ");
        //int first = int.Parse(Console.ReadLine());

        // Vstup od uživatele   -   lépe řešený

        Console.WriteLine("Zadejte prvni číslo: ");
        int first;
        while(!int.TryParse(Console.ReadLine(), out first)){
            Console.WriteLine("Nezadali jste celé číslo. Zadejte první číslo znovu: ");
        }

        Console.ReadKey();


    }
}
