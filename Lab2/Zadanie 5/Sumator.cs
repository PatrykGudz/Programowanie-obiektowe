using System;
using System.Linq;

public class Sumator
{
    private int[] liczby; 
    public Sumator(int[] liczbyWejsciowe)
    {
        liczby = liczbyWejsciowe ?? throw new ArgumentNullException(nameof(liczbyWejsciowe));
    }

    public int Suma()
    {
        return liczby.Sum();
    }
    public int SumaPodziel2()
    {
        return liczby.Where(x => x % 2 == 0).Sum();
    }
    public int IleElementow()
    {
        return liczby.Length;
    }
    public void WypiszElementy()
    {
        Console.WriteLine($"Elementy tablicy: {string.Join(", ", liczby)}");
    }
    public void WypiszElementyZakres(int lowIndex, int highIndex)
    {
        Console.WriteLine("Elementy w podanym zakresie:");
        for (int i = Math.Max(0, lowIndex); i <= Math.Min(liczby.Length - 1, highIndex); i++)
        {
            Console.WriteLine($"Index {i}: {liczby[i]}");
        }
    }
}

