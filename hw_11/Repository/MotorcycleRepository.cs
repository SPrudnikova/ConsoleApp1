using System;
using System.Collections.Generic;

namespace hw_11.Repository
{
    public class MotorcycleRepository : IMotorcycleRepository
    {
        public Guid Create(Motorcycle motorcycle)
        {
            Logger.Log.Info("Start add new motorcycle into database");
            DataBase.Motorcycles.Add(motorcycle.Id, motorcycle);
            return motorcycle.Id;
        }

        public void Delete(Guid motorcycleID)
        {
            Logger.Log.Info("Start delete motorcycle from database");
            DataBase.Motorcycles.Remove(motorcycleID);
        }

        public IEnumerable<Motorcycle> GetAll()
        {
            Logger.Log.Info("Start get all motorcycles from database");
            return DataBase.Motorcycles.Values;
        }

        public bool TryGetById(Guid motorcycleID, out Motorcycle moto)
        {
            Logger.Log.Info("Start get motorcycle by id from database");
            return DataBase.Motorcycles.TryGetValue(motorcycleID, out moto);
        }

        public void Update(Motorcycle motorcycle)
        {
            Logger.Log.Info("Start update motorcycle by id in database");
            DataBase.Motorcycles[motorcycle.Id] = motorcycle;
        }
    }
}
