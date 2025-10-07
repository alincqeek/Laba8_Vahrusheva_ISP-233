using Base;
using System;
class Person
{
    //private string name = "Artur";
    //private int age = 1;
    //public string Name
    //{
    //    get => name;
    //    set
    //    {
    //        name = value;
    //    }
    //}
    //public int Age
    //{

    //    set
    //    {
    //        if (value < 1 || value > 120) { Console.WriteLine("Недоступно"); }
    //        else 
    //            age = value; 

    //    }
    //    get => age;
    //}


    string name;
    Company company;
    public Person(string name, Company company)
    {
        this.name = name;
        this.company = company;
    }
    public void Print()

    {

        Console.WriteLine($"Имя: {name}");

        company.Print();

    }
}