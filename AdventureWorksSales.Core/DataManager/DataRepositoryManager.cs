using AdventureWorksSales.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksSales.Core.DataManager
{
    public class DataRepositoryManager<TEntity> : IDataRepository<TEntity> where TEntity : class
    {
        protected readonly AdventureWorksSalesDbContext context;
        public DataRepositoryManager(AdventureWorksSalesDbContext ctx)
        {
            context = ctx;
        }

        public void Add(TEntity b)
        {
            context.Set<TEntity>().Add(b);
            context.SaveChanges();
        }

        public void Delete(TEntity b)
        {
            context.Set<TEntity>().Remove(b);
            context.SaveChanges();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate);
        }

        public TEntity Get(int id)
        {
            return context.Set<TEntity>().FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

    }
}
