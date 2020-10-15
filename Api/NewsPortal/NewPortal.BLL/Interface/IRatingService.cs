using NewsPortal.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewPortal.BLL.Interface
{
    public interface IRatingService
    {
        Task<bool> AddRating(Rating rating);
        Task<List<Rating>> GetAllRating();
        Task<Rating> GetById(int id);
        Task<bool> UpdateRating(Rating rating);
        Task<bool> Delete(int id);
    }
}
