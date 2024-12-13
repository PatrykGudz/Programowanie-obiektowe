using System;

public class Program
{
    public static void Main(string[] args)
    { 
        var student = new Student("Adam", "Adamczyk");
        student.DodajOcene(4);
        student.DodajOcene(5);
        student.DodajOcene(3);
        student.View();
    }
}
