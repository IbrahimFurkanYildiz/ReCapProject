using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer entity);
        IDataResult<List<Customer>> GetCustomerByUserId(int userId);
        IDataResult<List<Customer>> GetAll();
    }
}
