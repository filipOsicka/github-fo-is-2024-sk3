string again = "a";
while (again == "a")
{

    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("**** Generátor - Intervaly ****");
    Console.WriteLine("******** Filip Osička *********");
    Console.WriteLine("*******************************");
    Console.WriteLine();
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int dm;
    while (!int.TryParse(Console.ReadLine(), out dm))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int hm;
    while (!int.TryParse(Console.ReadLine(), out hm))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("========================================================");
    Console.WriteLine("Zadané hodnoty: ");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, dm, hm);
    Console.WriteLine("========================================================\n\n");

    //deklarace pole o velikosti n prvků
    int[] myArray = new int[n];

    //Příprava pro generátor náhodných čísel
    Random randomNumber = new Random();

    Console.WriteLine("Náhodná čísla: ");
    int interval01 = 0;
    int interval02 = 0;
    int interval03 = 0;
    int interval04 = 0;


    for (int i = 0; i < n; i++)
    {
        myArray[i] = randomNumber.Next(dm, hm+1);
        Console.Write("{0}; ", myArray[i]);

        if(myArray[i] <= (0.25 * hm)){
            interval01++;
        }
        else if(myArray[i] <= (0.5 * hm)){
            interval02++;
        }
        else if(myArray[i] <= (0.75 * hm)){
            interval03++;
        }
        else
            interval04++;
    }


    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n\nInterval <{0}; {1}>: {2}", dm, 0.25* hm, interval01);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Interval <{0}; {1}>: {2}", 0.25 * hm + 1, 0.50* hm, interval02);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Interval <{0}; {1}>: {2}", 0.50 * hm + 1, 0.75* hm, interval03);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Interval <{0}; {1}>: {2}", 0.75 * hm + 1, hm, interval04);
    Console.ResetColor();


    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
    again = Console.ReadLine();

}