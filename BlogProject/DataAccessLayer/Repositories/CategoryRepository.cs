using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        
        public void AddCategory(Category category)
        {
            using var context = new Context();
            context.Add(category);
            context.SaveChanges();
        }

        public void Delete(Category item)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            using var context = new Context();
            context.Remove(category);
            context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetCategory(int id)
        {
            using var context = new Context();
            return context.Categories.Find(id);
        }

        public void Insert(Category item)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCategories()
        {
            using var context = new Context();
            return context.Categories.ToList();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            using var context = new Context();
            context.Update(category); 
            context.SaveChanges();
        }
    }
}
