using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Colors> _colors;

        public InMemoryColorDal()
        {
            _colors = new List<Colors>
            { 
                new Colors { Id=1,ColorName="Siyah"},
                new Colors { Id=2,ColorName="Beyaz"},
                new Colors { Id=3,ColorName="Mavi"}
            };
        }

        public void Add(Colors color)
        {
            _colors.Add(color);
        }

        public void Delete(Colors color)
        {
            Colors colorToDelete = _colors.SingleOrDefault(c => c.Id == color.Id);
            _colors.Remove(colorToDelete);
        }

        public Colors Get(Expression<Func<Colors, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Colors> GetAll()
        {
            return _colors;
        }

        public List<Colors> GetAll(Expression<Func<Colors, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Colors color)
        {
            Colors colorToUpdate = _colors.First(c => c.Id == color.Id);
            colorToUpdate.ColorName = color.ColorName;
        }
    }
}
