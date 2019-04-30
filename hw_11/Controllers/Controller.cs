using System;
using System.Collections.Generic;

namespace hw_11.Controllers
{
    public abstract class Controller<TEntity>
    {
        public abstract void Create(TEntity entity);

        public abstract void Delete(Guid id);

        public abstract IEnumerable<TEntity> GetAll();

        public abstract TEntity GetById(Guid id);

        public abstract void Update(TEntity entity);
    }
}
