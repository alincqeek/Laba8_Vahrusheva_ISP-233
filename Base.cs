using System;
namespace Base {
    class Company
    {
        string tittle;
        public Company(string tittle) => this.tittle = tittle;
        public void Print() => Console.WriteLine($"Компания: {tittle}");
    }
}
   
