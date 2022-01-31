using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental entity);
        IDataResult<List<Rental>> GetRentalsByCarId(int carId);
        IDataResult<List<Rental>> GetRentalsByCustomerId(int customerId);
        IDataResult<List<Rental>> GetAll();
    }
}
