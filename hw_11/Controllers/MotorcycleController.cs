using System;
using System.Collections.Generic;
using hw_11.Repository;

namespace hw_11.Controllers
{
    class MotorcycleController : Controller<Motorcycle>
    {
        private IMotorcycleRepository _motorcycleRepository;
        public MotorcycleController()
        {
            _motorcycleRepository = new MotorcycleRepository();
        }

        public override void Create(Motorcycle motorcycle)
        {
            _motorcycleRepository.Create(motorcycle);
        }

        public override void Delete(Guid motorcycleID)
        {
            _motorcycleRepository.Delete(motorcycleID);
        }

        public override IEnumerable<Motorcycle> GetAll()
        {
            return _motorcycleRepository.GetAll();
        }

        public override Motorcycle GetById(Guid motorcycleID)
        {
            return _motorcycleRepository.GetById(motorcycleID);
        }

        public override void Update(Motorcycle motorcycle)
        {
            _motorcycleRepository.Update(motorcycle);
        }
    }
}
