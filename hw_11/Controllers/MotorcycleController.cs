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
            Logger.Log.Info("Start create MotorcycleRepository in controller");
            _motorcycleRepository = new MotorcycleRepository();
        }

        public override Guid Create(Motorcycle motorcycle)
        {
            Logger.Log.Info("Controller get commads to create motorcycle");
            return _motorcycleRepository.Create(motorcycle);
        }

        public override void Delete(Guid motorcycleID)
        {
            Logger.Log.Info("Controller get commads to delete motorcycle");
            _motorcycleRepository.Delete(motorcycleID);
        }

        public override IEnumerable<Motorcycle> GetAll()
        {
            Logger.Log.Info("Controller get commads to get all motorcycles");
            return _motorcycleRepository.GetAll();
        }

        public override bool TryGetById(Guid motorcycleID, out Motorcycle moto)
        {
            Logger.Log.Info("Controller get commads to get motorcycle by id");
            return _motorcycleRepository.TryGetById(motorcycleID, out moto);
        }

        public override void Update(Motorcycle motorcycle)
        {
            Logger.Log.Info("Controller get commads to update motorcycle by id");
            _motorcycleRepository.Update(motorcycle);
        }
    }
}
