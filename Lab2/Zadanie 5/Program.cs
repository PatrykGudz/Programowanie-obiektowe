using System;

public class Program
{
    public static void Main(string[] args)
    {
        var sumator = new Sumator(new int[] { 4, 2, 5, 7, 5, 2, 1, 9 });

        Console.WriteLine($"Suma liczb: {sumator.Suma()}");
        Console.WriteLine($"Suma liczb podzielnych przez 2: {sumator.SumaPodziel2()}");
        Console.WriteLine($"Liczba elementów w tablicy: {sumator.IleElementow()}");

        sumator.WypiszElementy();
        sumator.WypiszElementyZakres(2, 6);
        sumator.WypiszElementyZakres(-1, 10);
    }
}
