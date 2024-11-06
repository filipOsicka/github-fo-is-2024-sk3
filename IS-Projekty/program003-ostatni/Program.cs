string nextFlag = "y";
int exit = 0;
// Fill the name of the project and name of the author
//zapůjčeno z internetu
string name = "Vykreslení obrazců";
string author = "Filip Osička";
string borders = "", nameLine = "", authorLine = "", authorSpacer = "", whiteSpace = "";
string cornerLT = "╔",
       cornerRT = "╗",
       cornerLB = "╚",
       cornerRB = "╝",
       baseSymbol = "═",
       sideSymbol = "║";
int lengthOfSymbols = 48, nameLineSymbols = 0, authorLineSymbols = 0;

if (name.Length % 2 != 0)
    lengthOfSymbols++;

if (author.Length % 2 != 0)
    authorSpacer = " ";

nameLineSymbols = (lengthOfSymbols - (name.Length + 6)) / 2;
authorLineSymbols = (lengthOfSymbols - (author.Length + 6)) / 2;
borders = string.Concat(Enumerable.Repeat(baseSymbol, lengthOfSymbols));
nameLine = string.Concat(Enumerable.Repeat(" ", nameLineSymbols));
authorLine = string.Concat(Enumerable.Repeat(" ", authorLineSymbols));
whiteSpace = string.Concat(Enumerable.Repeat(" ", lengthOfSymbols));

while(exit < 1) {
    Console.Clear();
    Console.WriteLine("{1}{0}{2}", borders, cornerLT, cornerRT);
    Console.WriteLine("{1}{0}{1}", whiteSpace, sideSymbol);
    Console.WriteLine("{2}{0}   {1}   {0}{2}", nameLine, name, sideSymbol);
    Console.WriteLine("{3}{0}   {2}{1}   {0}{3}", authorLine, author, authorSpacer, sideSymbol);
    Console.WriteLine("{1}{0}{1}", whiteSpace, sideSymbol);
    Console.WriteLine("{1}{0}{2}\n\n", borders, cornerLB, cornerRB);

    int option;
    Console.WriteLine("Vyberte si možnost pro pokračování:");
    Console.WriteLine("1. Obrazec 1");
    Console.WriteLine("2. Obrazec 2");
    Console.WriteLine("3. Obrazec 3");
    Console.WriteLine("4. Ukončit");
    Console.Write("\nVyberte jednu z možností: ");
    while (!int.TryParse(Console.ReadLine(), out option) || option > 4)
        Console.Write("\nNebyla zadána žádná možnost, zkuste znovu: ");

    Console.Clear();
    switch (option) {
        case 1:
            form1();
            break;
        case 2:
            form2();
            break;
        case 3:
            form3();
            break;
        case 4:
            exit = 1;
            break;
        default:
            break;
    }

    if (exit < 1) {
        Console.Write("\n\nPřejete si pokračovat [y/n]: ");
        nextFlag = Console.ReadLine();
    }
    if (nextFlag == "n") {
        exit = 1;
    }
}

int getNumber(string message) {
    Console.Write(message);
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("\nNebylo zadáno číslo nebo celé číslo, zkuste znovu: ");
    return number;
}

void form1() {
    int size = getNumber("Zadejte velikost obrazce: ");
    for (int i = 0; i < size; i++) {
        for (int j = 0; j < size; j++) {
            if (i % 2 == 0) {
                Console.Write("* ");
            } else {
                if (j % 2 == 0) {
                    Console.Write("* ");
                } else {
                    Console.Write("  ");
                }
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void form2() {
    int size = getNumber("Zadejte velikost obrazce: ");
    for (int i = 0; i < size; i++) {
        bool up = false;
        for (int j = 0; j < size; j++) {
            if (j % 2 == 0) {
                Console.Write("* ");
            } else {
                if ((up && i == 0) || (!up && i == size-1)) {
                    Console.Write("* ");
                } else {
                    Console.Write("  ");
                }
            }
            if (j % 2 == 1) {
                up = !up;
            }
        }
        Console.WriteLine();
    }
}

void form3() {
    int size = getNumber("Zadejte velikost obrazce: ");
    bool inverted = false;
    for (int i = 0; i < size; i++) {
        bool space = inverted;
        for (int j = 0; j < size; j++) {
            if (!space) {
                Console.Write("* ");
            } else {
                Console.Write("  ");
            }
            if (j % 2 == 1) {
                space = !space;
            }
        }
        if (i % 2 == 1) {
            inverted = !inverted;
        }
        Console.WriteLine();
    }
}