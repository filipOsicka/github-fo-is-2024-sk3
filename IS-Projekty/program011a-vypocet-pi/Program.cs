string again = "a";
while(again == "a") {

            Console.Clear();
            Console.WriteLine("********************");
            Console.WriteLine("**** Výpočet PI ****");
            Console.WriteLine("*** Filip Osička ***");
            Console.WriteLine("********************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte číslo (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
                Console.Write("Nezadali jste celé číslo. Zadejte první číslo znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("číslo: {0}", first);
            Console.WriteLine("========================================================");
          

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine(); 

}