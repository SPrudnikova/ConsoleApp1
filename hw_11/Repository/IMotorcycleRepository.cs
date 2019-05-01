using System;
using System.Collections.Generic;

namespace hw_11.Repository
{
    public interface IMotorcycleRepository
    {
        IEnumerable<Motorcycle> GetAll();
        bool TryGetById(Guid motorcycleID, out Motorcycle moto);
        Guid Create(Motorcycle motorcycle);
        void Update(Motorcycle motorcycle);
        void Delete(Guid motorcycleID);
    }
}
