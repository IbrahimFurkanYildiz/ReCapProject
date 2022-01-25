using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public bool Add(Cars entity)
        {
            if (entity.DailyPrice > 0)
            {
                _carDal.Add(entity);
                return true;
            }
            else
            {
                Console.WriteLine("Günlük limit değeri 0 ve aşağısı olamaz!"); 
                return false;
            }
        }

        public List<Cars> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Cars> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Cars> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
    }
}
