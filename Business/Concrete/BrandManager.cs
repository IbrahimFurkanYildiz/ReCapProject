using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public bool Add(Brands entity)
        {

            if (entity.BrandName.Length > 2)
            {
                _brandDal.Add(entity);
                return true;
            }
            else
            {
                Console.WriteLine("Marka ismi için yeterli karakter girişi yapılmadı!");
                return false;
            }
        }

        public List<Brands> GetAll()
        {
            return _brandDal.GetAll();
        }
    }
}
