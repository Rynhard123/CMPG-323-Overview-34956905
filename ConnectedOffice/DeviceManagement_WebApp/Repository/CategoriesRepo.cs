using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoriesRepo : GenericRepo<Category>, ICategoriesRepo
    {
        public CategoriesRepo(Proj3_AppDevContext Proj3_AppDevContext) : base(Proj3_AppDevContext)
        {
        }
        public Category GetCategoryByID(Guid? id)
        {
            return GetAll().FirstOrDefault(x => x.CategoryId == id);
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return GetAll().ToList();
        }
        public void AddCategory(Category entity)
        {
            Add(entity);
        }
        public void RemoveCategory(Category entity)
        {
            Remove(entity);
        }
        public void UpdateCategory(Category entity)
        {
            Update(entity);
        }
    }
}
