using System;

namespace hw_10
{
    class Circle : IShape
    {
        public string Name { get; set; }
        private int Radius { get; set; }

        public Circle (string name, int radius)
        {
            Name = name;
            Radius = radius;
        }

        public double GetArea()
        {
            return 2 * Math.PI * Radius * Radius ;
        }
    }
}
