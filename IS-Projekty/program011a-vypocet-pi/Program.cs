string again = "a";
while(again == "a") {

            Console.Clear();
            Console.WriteLine("********************");
            Console.WriteLine("**** Výpočet PI ****");
            Console.WriteLine("*** Filip Osička ***");
            Console.WriteLine("********************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte přesnost (reálné číslo - čím menší, tím přesnější výpočet bude): ");
            double presnost;
            while(!double.TryParse(Console.ReadLine(), out presnost)) {
                Console.Write("Nezadali jste přesnost správně. Zadejte znovu: ");
            }

            
            double i = 1;
            double piCtvrt = 1;
            double znamenko = 1;
            

            while((1/i)>= presnost){
                i=i+2;
                znamenko = -znamenko;
                piCtvrt = piCtvrt + znamenko *1/i;
                if(znamenko ==1){
                    Console.WriteLine("Zlomek +1/{0}; aktuální hodnota čísla PI = {1}", i, piCtvrt*4);
                    
                }else
                    Console.WriteLine("Zlomek -1/{0}; aktuální hodnota čísla PI = {1}", i, piCtvrt*4);

            }


            

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Hodnota čísla PI = {0}", piCtvrt*4);
            Console.WriteLine("Hodnota čísla PI = {0:f4}", piCtvrt*4);
            Console.WriteLine("========================================================");
          

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine(); 

}