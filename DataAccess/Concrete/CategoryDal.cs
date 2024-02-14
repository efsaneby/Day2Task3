using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {
            _categories = new List<Category>
            {
                new Category {Id = 1, Name = "C# kursu"},
                new Category {Id = 2, Name = "Java kursu"}
            };
        }

        public Category Get(int id)
        {
            return _categories.First(c=>c.Id == id);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Add(Category entity)
        {
            _categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            var deletedCategory = _categories.First(c => c.Id == entity.Id);
            _categories.Remove(deletedCategory);
        }

        public void Update(Category entity)
        {
            var updatedCategory = _categories.First(c=>c.Id==entity.Id);
            updatedCategory.Id = entity.Id;
            updatedCategory.Name = entity.Name;
        }
    }
}
