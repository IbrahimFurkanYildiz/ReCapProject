using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Cars> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Cars> 
            {
                new Cars{Id=1,BrandId=1,ColorId=1,DailyPrice=400,ModelYear=1985,Description="B Sınıf"},
                new Cars{Id=2,BrandId=1,ColorId=2,DailyPrice=200,ModelYear=1995,Description="A Sınıf"},
                new Cars{Id=3,BrandId=2,ColorId=2,DailyPrice=500,ModelYear=1975,Description="C Sınıf"},
                new Cars{Id=4,BrandId=2,ColorId=3,DailyPrice=600,ModelYear=1965,Description="B Sınıf"},
                new Cars{Id=5,BrandId=3,ColorId=1,DailyPrice=900,ModelYear=2005,Description="C Sınıf"},
                new Cars{Id=6,BrandId=3,ColorId=3,DailyPrice=200,ModelYear=2015,Description="A Sınıf"},
            };
        }

        public void Add(Cars car)
        {
            _cars.Add(car);
        }

        public void Delete(Cars car)
        {
            Cars carToDelete = _cars.First(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Cars Get(Expression<Func<Cars, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetAll()
        {
            return _cars;
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Cars car)
        {
            Cars carToUpdate = _cars.First(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
