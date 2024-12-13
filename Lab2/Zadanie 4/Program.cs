using System;

public class Program
{
    public static void Main(string[] args)
    {
        var licz1 = new Licz(14);
        var licz2 = new Licz(35);
        var licz3 = new Licz(3);

        licz1.Dodaj(5);
        licz1.Odejmij(3);
        licz1.Wypisz();

        licz2.Dodaj(10);
        licz2.Odejmij(5);
        licz2.Wypisz();

        licz3.Dodaj(7);
        licz3.Odejmij(2);
        licz3.Wypisz();
    }
}
