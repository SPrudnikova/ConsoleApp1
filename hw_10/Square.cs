namespace hw_10
{
    class Square : IShape
    {
        public string Name { get; set; }
        private int Side { get; set; }

        public Square(string name, int side)
        {
            Name = name;
            Side = side;
        }

        public double GetArea()
        {
            return Side * Side;
        }
    }
}
