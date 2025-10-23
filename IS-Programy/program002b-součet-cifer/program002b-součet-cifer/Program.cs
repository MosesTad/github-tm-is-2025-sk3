string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("********** Součet a součin cifer ***********");
    Console.WriteLine("********************************************");
    Console.WriteLine("************** Tadeáš Mojžíš ***************");
    Console.WriteLine("*************** 22.10.2025 *****************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup čísla
    Console.Write("Zadejte celé číslo: ");
    string input = Console.ReadLine();

    // Kontrola, zda uživatel zadal číslo
    while (!int.TryParse(input, out _))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte ho znovu: ");
        input = Console.ReadLine();
    }

    string numberStr = input;

    // Pokud je číslo záporné, odstraníme "-"
    if (numberStr.StartsWith("-"))
    {
        numberStr = numberStr.Substring(1);
    }

    int suma = 0;

    // Procházíme každý znak a převádíme na číslo
    foreach (char c in numberStr)
    {
        suma += c - '0';
    }

    Console.WriteLine($"Součet cifer čísla {input} je {suma}");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}