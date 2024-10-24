string again = "a";
while(again == "a") {

            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("**** Generátor Random číšel ****");
            Console.WriteLine("********* Filip Osička *********");
            Console.WriteLine("********************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu: ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, dm, hm);
            Console.WriteLine("========================================================\n\n");
          

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine(); 

}