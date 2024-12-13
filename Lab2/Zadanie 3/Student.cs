using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    private List<int> grades;


    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        grades = new List<int>();
    }


    public double SredniaOcen => grades.Count > 0 ? grades.Average() : 0.0;


    public void DodajOcene(int ocena)
    {
        if (ocena >= 1 && ocena <= 5)
        {
            grades.Add(ocena);
        }
        else
        {
            Console.WriteLine("Ocena musi być w przedziale od 1 do 5.");
        }
    }

    public void View()
    {
        Console.WriteLine($"Student: {FirstName} {LastName}");
        Console.WriteLine($"Oceny: {string.Join(", ", grades)}");
        Console.WriteLine($"Średnia ocen: {SredniaOcen:F2}");
    }
}

