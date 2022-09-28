using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;

namespace DeviceManagement_WebApp.Repository
{
    public interface ICategoriesRepo : IGenericRepo<Category>
    {
        Category GetCategoryByID(Guid? id);
        IEnumerable<Category> GetAllCategories();
        void AddCategory(Category entity);
        void RemoveCategory(Category entity);
        void UpdateCategory(Category entity);
    }
}
