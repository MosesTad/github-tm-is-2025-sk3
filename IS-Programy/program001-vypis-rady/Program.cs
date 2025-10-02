string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("********* Výpis řady ***********");
    Console.WriteLine("********************************");
    Console.WriteLine("******** Tadeáš Mojžíš *********");
    Console.WriteLine("********** 2.10.2025 ***********");
    Console.WriteLine("********************************");
    Console.WriteLine();

    // Vstup číselné hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

// Vstup číselné hodnoty do programu - lépe řešený
    Console.Write("Zadejte první číslo řady(celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znavu: ");
}





    Console.WriteLine();
    Console.WriteLine("Pro opakování stiskněte klávesu a");
    again = Console.ReadLine();



}