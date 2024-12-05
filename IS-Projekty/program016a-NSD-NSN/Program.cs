string again = "a";
while (again == "a")
{
    Console.Clear();
    razitko();

    ulong a = ziskatCislo("zadejte přirozené číslo a: ");
    ulong b = ziskatCislo("zadejte přirozené číslo b: ");
    
    ulong nsd = vypocitatNsd(a, b);

    ulong nsn = ziskatNSN(a,b,nsd);

    zobrazitVysledky(a,b,nsn,nsd);

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
    again = Console.ReadLine();

}

static void razitko(){
    Console.WriteLine("****************************");
    Console.WriteLine("******** NSD a NSN *********");
    Console.WriteLine("******* Filip Osička *******");
    Console.WriteLine("****************************\n\n");
    Console.WriteLine();
    Console.WriteLine();
}

static ulong ziskatCislo(string zprava){
    Console.Write(zprava);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte znovu: ");
    }
    return cislo;
}

static ulong vypocitatNsd(ulong a, ulong b){
    while (a != b){
        if (a > b)
        a = a - b;
        else b = b - a;
    }

    return a;
}

static ulong ziskatNSN(ulong a, ulong b, ulong nsd){
    
    return a*b/nsd;
}

static void zobrazitVysledky(ulong a, ulong b, ulong nsn, ulong nsd){
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("\n\nNSD čísel {0} a {1} je {2}", a, b, nsd);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"NSN čísel {a} a {b} je {nsn}");
    Console.ForegroundColor = ConsoleColor.White;
}
