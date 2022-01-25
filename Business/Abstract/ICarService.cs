using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        bool Add(Cars entity);
        List<Cars> GetCarsByColorId(int id);
        List<Cars> GetCarsByBrandId(int id);
        List<Cars> GetAll();
    }
}
