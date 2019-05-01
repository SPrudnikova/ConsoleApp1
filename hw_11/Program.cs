using System;
using System.Linq;
using hw_11.Controllers;

namespace hw_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            MotorcycleController motorcycleController = new MotorcycleController();

            Guid id1 = motorcycleController.Create(new Motorcycle("Name1", "Model1", 2019, 0));
            Guid id2 = motorcycleController.Create(new Motorcycle("Name2", "Model2", 2019, 0));
            Guid id3 = motorcycleController.Create(new Motorcycle("Name3", "Model3", 2019, 0));
            Console.WriteLine($"Motorcycles count: {motorcycleController.GetAll().Count()}");

            motorcycleController.Delete(id2);
            Console.WriteLine($"Motorcycles count: {motorcycleController.GetAll().Count()}");

            if (motorcycleController.TryGetById(id3, out Motorcycle moto))
            {
                Console.WriteLine($"Motorcycles id3: name - {moto.Name}, modle - {moto.Model}, year - {moto.Year}, odometer - {moto.Odometer}");
                moto.Name = "Name3Changed";
                motorcycleController.Update(moto);
                Console.WriteLine($"Motorcycles id3: name - {moto.Name}");
            }

            if (motorcycleController.TryGetById(id2, out Motorcycle notExistedMoto))
            {
                Console.WriteLine($"Motorcycles id1: name - {notExistedMoto.Name}, modle - {notExistedMoto.Model}, year - {notExistedMoto.Year}, odometer - {notExistedMoto.Odometer}");
            }
            else
            {
                Console.WriteLine($"Moto with id {id2} does not exist");
            }

            Console.Read();
        }
    }
}
