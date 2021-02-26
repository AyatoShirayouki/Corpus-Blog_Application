using CorpusSMDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CorpusSMDemo.DataAccess
{
    public class BaseRepository<T> where T : BaseEntity
    {
        protected DbSet<T> Items { get; set; }
        protected DbContext Context { get; set; }

        protected virtual IQueryable<T> CascadeInclude(IQueryable<T> query)
        {
            return query;
        }

        public BaseRepository()
        {
            Context = new MyDbContext();
            Items = Context.Set<T>();
        }

        public BaseRepository(UnitOfWork uow)
        {
            Context = new MyDbContext();
            Items = Context.Set<T>();
        }

        public T GetById(int id)
        {
            return Items.Where(u => u.Id == id).FirstOrDefault();
        }

        public List<TResult> GetReferences<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            return Items
                .Where(filter)
                .Select(selector)
                .ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = Items;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query.ToList();

        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> where)
        {
            return Items.Where(where).FirstOrDefault();
        }

        public void Save(T item)
        {
            if (item.Id > 0)
            {
                Items.Update(item);
            }
            else
            {
                Items.Add(item);
            }

            Context.SaveChanges();
        }

        public void Delete(T item)
        {
            Items.Remove(item);
            Context.SaveChanges();
        }
    }
}
