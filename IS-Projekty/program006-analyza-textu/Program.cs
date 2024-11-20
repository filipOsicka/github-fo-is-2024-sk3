﻿string again = "a";
        while(again == "a") {

            Console.Clear();
            Console.WriteLine("************************");
            Console.WriteLine("**** Analýza textu *****");
            Console.WriteLine("***** Filip Osička *****");
            Console.WriteLine("************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("\n\nZadejte text pro analýzu: ");
            string mujText = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(mujText);
            Console.WriteLine(mujText[0]);
            Console.WriteLine(mujText.Length);
            Console.WriteLine(mujText[mujText.Length-1]);

            string samohlasky = "aáeéěiíoóuůúyý";
            string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzž";
            string cislice = "0123456789";

            int pocetSouhlasek = 0;
            int pocetSamohlasek = 0;
            int pocetCislic = 0;
            int pocetOstatnich = 0;

            foreach(char znak in mujText) {
                if(souhlasky.Contains(znak)) {
                    pocetSouhlasek++;
                }
                else if(samohlasky.Contains(znak)) {
                    pocetSamohlasek++;
                }
                else if(cislice.Contains(znak)) {
                    pocetCislic++;
                }
                else
                    pocetOstatnich++; 
            }


            Console.WriteLine("\n\nPočet samohlásek: {0}", pocetSamohlasek);
            Console.WriteLine("Počet souhlásek: {0}", pocetSouhlasek);
            Console.WriteLine("Počet číslic: {0}", pocetCislic);
            Console.WriteLine("Počet ostatních znaků: {0}", pocetOstatnich);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }