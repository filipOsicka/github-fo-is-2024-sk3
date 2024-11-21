using System.Security.Authentication.ExtendedProtection;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

string again = "a";
while(again == "a") {
    //Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("****** Shaker sort *********");
    Console.WriteLine("****************************");
    Console.WriteLine("****** Filip Osička ********");
    Console.WriteLine("****************************\n\n");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n)) {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int dm;
    while(!int.TryParse(Console.ReadLine(), out dm)) {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int hm;
    while(!int.TryParse(Console.ReadLine(), out hm)) {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
    }

    Console.WriteLine("\n\n====================");
    Console.WriteLine("Uživatelský vstup: ");
    Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
    Console.WriteLine("====================\n\n");

    int[] myArray = new int[n];
    
    Random randomNumber = new Random();

    Console.WriteLine("Náhodná čísla: ");

    for(int i=0; i<n; i++) {
        myArray[i] = randomNumber.Next(dm, hm+1);
        Console.Write("{0}; ", myArray[i]);
    }
    
    Stopwatch myStopwatch = new Stopwatch(); 
    myStopwatch.Start();

    int numberCompare = 0;
    int numberChange = 0;

    ShakerSort(myArray, ref numberCompare, ref numberChange); // Zavolejte metodu ShakerSort

    myStopwatch.Stop();

    Console.WriteLine("\n\nSeřazené pole: ");
    for (int k = 0; k < n; k++) {
        Console.Write("{0}; ", myArray[k]);
    }
    
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem Shaker Sort: {0}", myStopwatch.Elapsed);
    
    Console.WriteLine("\n\nPočet porovnání: {0}", numberCompare);
    Console.WriteLine("Počet výměn: {0}", numberChange);
    
    Console.ResetColor();
    
    Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}

void ShakerSort(int[] array, ref int numberCompare, ref int numberChange) {
    bool swapped = true;

    while (swapped) {
        swapped = false;

        // Procházení zleva doprava
        for (int i = 0; i < array.Length - 1; i++) {
            numberCompare++;
            if (array[i] > array[i + 1]) {
                // Výměna
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
                numberChange++;
                swapped = true;
            }
        }

        // Procházení zprava doleva
        for (int i = array.Length - 1; i > 0; i--) {
            numberCompare++;
            if (array[i] < array[i - 1]) {
                // Výměna
                int temp = array[i];
                array[i] = array[i - 1];
                array[i - 1] = temp;
                numberChange++;
                swapped = true;
            }
        }
    }
}