using System.Security.Cryptography;

string again = "a";
while(again == "a") {

    Console.Clear();
    Console.WriteLine("*****************************************");
    Console.WriteLine("**** Generátor pseudonáhodných čísel ****");
    Console.WriteLine("************** Filip Osička *************");
    Console.WriteLine("*****************************************");
    Console.WriteLine();
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n)) {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int dm;
    while(!int.TryParse(Console.ReadLine(), out dm)) {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu (celé číslo): ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int hm;
    while(!int.TryParse(Console.ReadLine(), out hm)) {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu (celé číslo): ");
    }

    Console.WriteLine();
    Console.WriteLine("========================================================");
    Console.WriteLine("Zadané hodnoty: ");
    Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
    Console.WriteLine("========================================================\n\n");
    
    
    int[] myArray = new int[n];

    
    Random randomNumber = new Random();

    for(int i=0; i<n; i++) {
        myArray[i] = randomNumber.Next(dm, hm+1);
        Console.Write("{0}; ", myArray[i]);
    }

    int max = myArray[0];
    int min = myArray[0];
    int posMax = 0;
    int posMin = 0;
    int countMax = 1; 
    int countMin = 1; 
    List<int> maxPositions = new List<int>(); 
    List<int> minPositions = new List<int>(); 

    maxPositions.Add(0);
    minPositions.Add(0);

    for(int i = 1; i < n; i++) {
        if(myArray[i] > max) {
           max = myArray[i];
           posMax = i + 1;
           countMax = 1;
           maxPositions.Clear();
           maxPositions.Add(i + 1);
        } else if (myArray[i] == max) {
            countMax++;
            maxPositions.Add(i + 1);
        }

        if(myArray[i] < min) {
            min = myArray[i];
            posMin = i + 1;
            countMin = 1; 
            minPositions.Clear();
            minPositions.Add(i + 1);
        } else if (myArray[i] == min) {
            countMin++;
            minPositions.Add(i + 1);
        }
    }

    Console.WriteLine("\n\nPozice prvního maxima v poli = {1}", max, posMax);
    Console.WriteLine("Počet maximálních hodnot: {0}", countMax);
    Console.WriteLine("Pozice všech maximálních hodnot: {0}", string.Join(", ", maxPositions));

    Console.WriteLine("Pozice prvního minima v poli = {1}", min, posMin);
    Console.WriteLine("Počet minimálních hodnot: {0}", countMin);
    Console.WriteLine("Pozice všech minimálních hodnot: {0}", string.Join(", ", minPositions));

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
    again = Console.ReadLine();    
}