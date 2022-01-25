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
    public class EfCarDal : ICarDal
    {
        public void Add(Cars entity)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Cars entity)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Cars Get(Expression<Func<Cars, bool>> filter)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                return context.Set<Cars>().SingleOrDefault(filter);
            }
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                return filter == null
                    ? context.Set<Cars>().ToList()
                    : context.Set<Cars>().Where(filter).ToList();
            }
        }

        public void Update(Cars entity)
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
