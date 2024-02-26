using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nArchitecture.Persistence.Repositories
{
    public interface IRepository<TEntity , TEntityId>
        where TEntity : Entity<TEntityId>
    {
        //CRUD
        TEntity Add(TEntity entity);
        IList<TEntity> GetList();
    }
}
