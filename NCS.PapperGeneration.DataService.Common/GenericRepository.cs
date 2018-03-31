// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenericRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The generic repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NCS.PapperGeneration.DataService.Common
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;

    using NCS.PaperGeneration.Entities.CommonEntities;

    /// <summary>
    /// The generic repository.
    /// </summary>
    /// <typeparam name="T">Commern entitiy class
    /// </typeparam>
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        public PaperGenerationDbContext Context;
        public IDbSet<T> _dbSet;

        public GenericRepository(PaperGenerationDbContext context)
        {
            this.Context = context;
            this._dbSet = context.Set<T>();
        }

        public virtual T GetById(object id)
        {
            return this._dbSet.Find(id);
        }

        public virtual void Insert(T entity)
        {
            this._dbSet.Add(entity);
            this.Context.Entry(entity).State = EntityState.Added;
            this.Context.SaveChanges();
        }

       public virtual void Delete(object id)
        {
            T entityToDelete = this._dbSet.Find(id);
            this.Delete(entityToDelete);
        }

       public virtual void Delete(T entityToDelete)
        {
            if (this.Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                this._dbSet.Attach(entityToDelete);
            }

            this._dbSet.Remove(entityToDelete);
        }

       public virtual T Update(T entityToUpdate)
        {
            this._dbSet.Attach(entityToUpdate);
            this.Context.Entry(entityToUpdate).State = EntityState.Modified;
            this.Context.SaveChanges();
            return entityToUpdate;
        }

       public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = this._dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split(
                new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
    }
}
