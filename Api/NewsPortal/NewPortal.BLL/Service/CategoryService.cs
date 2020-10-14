using NewPortal.BLL.Interface;
using NewsPortal.Common.Models;
using NewsPortal.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPortal.BLL.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly NewsPortalContext _db;

        public CategoryService(NewsPortalContext db)
        {
            _db = db;
        }

        public async Task<bool> AddCategory(Category category)
        {
            bool result = false;

            //user.status = true;
            //user.UserRollID = 2;

            await _db.Categories.AddAsync(category);
            var res = await _db.SaveChangesAsync();
            if (res > 0)
            {
                result = true;
            }

            return result;
        }

        public async Task<bool> Delete(int id)
        {
            bool result = false;
            var category = _db.Categories.Where(p => p.ID == id).FirstOrDefault();
            _db.Categories.Remove(category);
            var res =await _db.SaveChangesAsync();
            if (res > 0)
            {
                result = true;
            }
            return result;
        }

        public async Task<List<Category>> GetAllCategory()
        {
          return  _db.Categories.ToList();
        }

        public async Task<Category> GetById(int id)
        {
            var category =  _db.Categories.Where(p => p.ID == id).FirstOrDefault();
            if (category != null)
            {
                return category;
            }

            throw new Exception("Category Not Found");
        }

        public async Task<bool> UpdateCategory(Category category)
        {
            bool result = false;
            _db.Categories.Update(category);
            var res = await _db.SaveChangesAsync();

            if (res > 0)
            {
                result = true;
            }
            return result;
        }
    }
}
