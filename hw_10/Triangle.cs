using System;

namespace hw_10
{
    class Triangle : IShape
    {
        public string Name { get; set; }
        private int SideA { get; set; }
        private int SideB { get; set; }
        private int SideC { get; set; }

        public Triangle(string name, int sideA, int sideB, int sideC)
        {
            Name = name;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetArea()
        {
            double halfPerimeter = (SideA + SideB + SideC) / 2;
            if (halfPerimeter <= SideA || halfPerimeter <= SideB || halfPerimeter <= SideC)
            {
                return 0;
            }

            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }
    }
}
