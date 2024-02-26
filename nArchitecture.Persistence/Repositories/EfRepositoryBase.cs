using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nArchitecture.Persistence.Repositories
{
    public class EfRepositoryBase<TEntity,TDbContext, TEntityId> : IRepository<TEntity, TEntityId>
        where TEntity : Entity<TEntityId>
        where TDbContext : DbContext
    {
        protected readonly TDbContext _context;

        public EfRepositoryBase(TDbContext context)
        {
            _context = context;
        }

        public TEntity Add(TEntity entity)
        {
            _context.Add(entity);
            _context.SaveChanges();

            return entity;

        }

        public IList<TEntity> GetList()
        {
            return _context.Set<TEntity>().ToList();
        }
    }
}
