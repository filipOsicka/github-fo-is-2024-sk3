using System.Text.Json.Serialization;

string again = "a";
while (again == "a")
{

    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("**** Generátor Random číšel ****");
    Console.WriteLine("********* Filip Osička *********");
    Console.WriteLine("********************************");
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

    int kladna = 0;
    int zaporna = 0;
    int nula = 0;

    int suda = 0;
    int licha = 0;

    for (int i = 0; i < n; i++)
    {
        myArray[i] = randomNumber.Next(dm, hm+1);
        Console.Write("{0}; ", myArray[i]);
       
        // if (myArray[i] > 0)
        //     kladna++;
        
        // if (myArray[i] < 0)
        //     zaporna++;
        
        // if (myArray[i] == 0)
        //     nula++;

        if(myArray[i] > 0)
            kladna++;
        else if(myArray[i] < 0)
            zaporna++;
        else
            nula++;

        if(myArray[i]  % 2 == 0)
            suda++;
        else
            licha++;
    }

    Console.WriteLine("\n\nPočet kladných čísel: {0}", kladna);
    Console.WriteLine("Počet Záporných čísel: {0}", zaporna);
    Console.WriteLine("Počet nul: {0}", nula);

    Console.WriteLine("\n\nPočet sudých čísel: {0}", suda);
    Console.WriteLine("Počet lichých čísel: {0}", licha);
    


    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
    again = Console.ReadLine();

}