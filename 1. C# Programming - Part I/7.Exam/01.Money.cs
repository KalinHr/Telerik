using System;

class Program
{
    static void Main()
    {
        int students = int.Parse(Console.ReadLine());
        int sheets = int.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        long totalSheets = students * sheets;
        double reams = totalSheets / 400.0;
        double amount = reams * price;

        Console.WriteLine("{0:F3}", amount);
    }
}
