using System;
using System.Collections.Generic;

namespace hw_11.Repository
{
    public class MotorcycleRepository : IMotorcycleRepository
    {
        public void Create(Motorcycle motorcycle)
        {
            DataBase.Motorcycles.Add(motorcycle.Id, motorcycle);
        }

        public void Delete(Guid motorcycleID)
        {
            DataBase.Motorcycles.Remove(motorcycleID);
        }

        public IEnumerable<Motorcycle> GetAll()
        {
            return DataBase.Motorcycles.Values;
        }

        public Motorcycle GetById(Guid motorcycleID)
        {
            Motorcycle moto;
            DataBase.Motorcycles.TryGetValue(motorcycleID, out moto);

            return moto;
        }

        public void Update(Motorcycle motorcycle)
        {
            DataBase.Motorcycles[motorcycle.Id] = motorcycle;
        }
    }
}
