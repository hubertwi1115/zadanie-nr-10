class Program
{
    static void Main()
    {
        int wiekInt;
        double wiekDouble;
        float wiekFloat;

        Console.Write("Podaj dowolną liczbę nieparzystą jako wiek: ");
        int wiek = int.Parse(Console.ReadLine());

        if (wiek % 2 == 0)
        {
            Console.WriteLine("Wprowadzony wiek nie jest liczbą nieparzystą.");
            return;
        }

        wiekInt = wiek;
        wiekDouble = (double)wiek;
        wiekFloat = (float)wiek;

        Console.WriteLine($"Wiek jako int: {wiekInt}");
        Console.WriteLine($"Wiek jako double: {wiekDouble}");
        Console.WriteLine($"Wiek jako float: {wiekFloat}");
    }
}