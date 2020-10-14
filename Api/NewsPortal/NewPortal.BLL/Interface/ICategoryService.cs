using NewsPortal.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewPortal.BLL.Interface
{
    public interface ICategoryService
    {
        Task<bool> AddCategory(Category category);
        Task<List<Category>> GetAllCategory();
        Task<Category> GetById(int id);
        Task<bool> UpdateCategory(Category category);
        Task<bool> Delete(int id);
    }
}
