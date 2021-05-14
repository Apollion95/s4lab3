using s4lab3.ScaffoldModel;
using System;

namespace s4lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new NorthwindContext();

            db.Add(new Osoba() {Name="Michal",DateTime=DateTime.Now, RegistrationDate=DateTime.Now});
            db.SaveChanges();
        }
    }
}