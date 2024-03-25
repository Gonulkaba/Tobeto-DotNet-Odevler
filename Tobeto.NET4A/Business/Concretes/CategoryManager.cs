using Business.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        List<Category> _categories;

        public CategoryManager()
        {
            _categories = new List<Category>();
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(int id)
        {
            Category category = _categories.FirstOrDefault(x => x.Id == id);
            if (category != null)
            {
                _categories.Remove(category);
            }
        }

        public List<Category> GetAll()
        {
            return this._categories;
        }

        public Category GetById(int id)
        {
            return _categories.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Category updatedCategory)
        {
            Category category = _categories.FirstOrDefault(x => x.Id == updatedCategory.Id);
            if (category != null)
            {
                category.Name = updatedCategory.Name;
                category.Description = updatedCategory.Description;
            }
        }
    }
}
