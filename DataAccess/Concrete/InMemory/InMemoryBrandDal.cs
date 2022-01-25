using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brands> _brands;

        public InMemoryBrandDal()
        {
            _brands = new List<Brands>
            {
                new Brands{Id=1,BrandName="BMW"},
                new Brands{Id=2,BrandName="Audi"},
                new Brands{Id=3,BrandName="Mercedes"}
            };
        }

        public void Add(Brands brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brands brand)
        {
            Brands brandToDelete = _brands.First(b => b.Id == brand.Id);
            _brands.Remove(brandToDelete);
        }

        public Brands Get(Expression<Func<Brands, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brands> GetAll()
        {
            return _brands;
        }

        public List<Brands> GetAll(Expression<Func<Brands, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Brands brand)
        {
            Brands brandToUpdate = _brands.First(b => b.Id == brand.Id);
            brandToUpdate.BrandName = brand.BrandName;
        }
    }
}
