using System;

namespace hw_11
{
    public class Motorcycle
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }

        public Motorcycle(string name, string model, int year, int odometer)
        {
            Id = new Guid();
            Name = name;
            Model = model;
            Year = year;
            Odometer = odometer;
        }
    }
}
