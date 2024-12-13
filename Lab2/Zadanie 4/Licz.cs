using System;

public class Licz
{
    private int value;
    public Licz(int initialValue)
    {
        value = initialValue;
    }
    public void Dodaj(int amount)
    {
        value += amount;
    }
    public void Odejmij(int amount)
    {
        value -= amount;
    }
    public void Wypisz()
    {
        Console.WriteLine($"Aktualna wartość: {value}");
    }
}

