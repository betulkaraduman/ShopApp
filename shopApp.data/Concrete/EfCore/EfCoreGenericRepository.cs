using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using shopApp.data.Abstract;

namespace shopApp.data.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext context;

        public EfCoreGenericRepository(DbContext cntx)
        {
            context = cntx;
        }
        public void Create(TEntity entity)
        {

            context.Set<TEntity>().Add(entity);
            context.SaveChanges();

        }

        public void Delete(TEntity entity)
        {


            context.Set<TEntity>().Remove(entity); 
            context.SaveChanges();

        }

        public async Task<TEntity> GetById(int id)
        {

            return await context.Set<TEntity>().FindAsync(id);

        }

        public async Task<List<TEntity>> GetAll()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public virtual void Update(TEntity entity)
        {

            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

        }

        public async Task CreateAsync(TEntity entity)
        {
           await   context.Set<TEntity>().AddAsync(entity);
            context.SaveChanges();
        }
    }
}