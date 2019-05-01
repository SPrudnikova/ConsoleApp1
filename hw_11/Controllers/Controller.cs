using System;
using System.Collections.Generic;

namespace hw_11.Controllers
{
    public abstract class Controller<TEntity>
    {
        public abstract Guid Create(TEntity entity);

        public abstract void Delete(Guid id);

        public abstract IEnumerable<TEntity> GetAll();

        public abstract bool TryGetById(Guid id, out Motorcycle moto);

        public abstract void Update(TEntity entity);
    }
}
