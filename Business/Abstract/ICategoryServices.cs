using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryServices
    {
        List<Category> GetAll();
        Category GetByCategoryId(int id);
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);

    }
}
