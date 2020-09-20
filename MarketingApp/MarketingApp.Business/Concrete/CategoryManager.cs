using System.Collections.Generic;
using MarketingApp.Business.Abstract;
using MarketingApp.Data.Abstract;
using MarketingApp.Entity;

namespace MarketingApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Create(Category entity)
        {
            _categoryRepository.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryRepository.Delete(entity);
        }

        public void DeleteProductFromCategory(int productId, int categoryId)
        {
            _categoryRepository.DeleteProductFromCategory(productId,categoryId);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public Category GetByIdWithProduct(int categoryId)
        {
            return _categoryRepository.GetByIdWithProduct(categoryId);
        }

        public void Update(Category entity)
        {
            _categoryRepository.Update(entity);
        }
    }
}