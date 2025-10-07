using System;

class Car {
   public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; } 
    public int Mileage { get; set; }

    public void PrintInfo() { Console.WriteLine($"Марка: {Brand}       Модель: {Model}       Год выпуска: {Year}       Пробег: {Mileage} км "); }


}