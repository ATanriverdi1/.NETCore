using System.Collections.Generic;
using MarketingApp.Entity;

namespace MarketingApp.Business.Abstract
{
    public interface ICategoryService
    {
        Category GetByIdWithProduct(int categoryId);
        Category GetById(int id);

        List<Category> GetAll();

        void Create(Category entity);

        void Update(Category entity);
        
        void Delete(Category entity);
        
        void DeleteProductFromCategory(int productId, int categoryId);
    }
}