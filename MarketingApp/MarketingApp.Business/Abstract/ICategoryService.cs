using System.Collections.Generic;
using MarketingApp.Entity;

namespace MarketingApp.Business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);

        List<Category> GetAll();

        void Create(Category entity);

        void Update(Category entity);
        
        void Delete(Category entity);
    }
}