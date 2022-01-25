using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brands entity)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brands entity)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Brands Get(Expression<Func<Brands, bool>> filter)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                return context.Set<Brands>().SingleOrDefault(filter);
            }
        }

        public List<Brands> GetAll(Expression<Func<Brands, bool>> filter = null)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                return filter == null
                    ? context.Set<Brands>().ToList()
                    : context.Set<Brands>().Where(filter).ToList();
            }
        }

        public void Update(Brands entity)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
