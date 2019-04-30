using System;
using System.Collections.Generic;

namespace hw_11.Repository
{
    public interface IMotorcycleRepository
    {
        IEnumerable<Motorcycle> GetAll();
        Motorcycle GetById(Guid motorcycleID);
        void Create(Motorcycle motorcycle);
        void Update(Motorcycle motorcycle);
        void Delete(Guid motorcycleID);
    }
}
