using System;

namespace hw_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info($"Project name: {System.Reflection.Assembly.GetEntryAssembly().GetName().Name}");

            Random randomGenerator = new Random();
            Circle circle = new Circle("Circle", randomGenerator.Next(1, 10));
            Square square = new Square("Square", randomGenerator.Next(1, 10));
            Triangle triangle = new Triangle("Triangle", randomGenerator.Next(1, 10), randomGenerator.Next(1, 10), randomGenerator.Next(1, 10));

            Logger.Log.Info("Start shapes array initialization");
            IShape[] spapesArray = { circle, square, triangle };

            for (int i = 0; i < spapesArray.Length; i++)
            {
                var shape = spapesArray[i];

                Logger.Log.Info($"Start {shape.GetType()} area calculating");
                var shapeArea = shape.GetArea();

                Logger.Log.Info($"Start printing {shape.Name} information into console.");
                Console.WriteLine($"This is {shape.Name}. CLR Type is {shape.GetType()}. Square is {shapeArea}");
            }

            Logger.Log.Info("Finished successfully");

            Console.Read();
        }
    }
}
