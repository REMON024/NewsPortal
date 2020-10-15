using Microsoft.EntityFrameworkCore;
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
    public class RatingService : IRatingService
    {
        private readonly NewsPortalContext _db;
        public RatingService(NewsPortalContext db)
        {
            _db = db;

        }
        public async Task<bool> AddRating(Rating rating)
        {
            bool result = false;
            await _db.Ratings.AddAsync(rating);
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
            var rating = await _db.Ratings.Where(p => p.ID == id).FirstOrDefaultAsync();
            _db.Ratings.Remove(rating);
            var res = await _db.SaveChangesAsync();
            if (res > 0)
            {
                result = true;
            }
            return result;
        }

        public async Task<List<Rating>> GetAllRating()
        {
            return await _db.Ratings.ToListAsync();
        }

        public async Task<Rating> GetById(int id)
        {
            var rating = await _db.Ratings.Where(p => p.ID == id).FirstOrDefaultAsync();
            if (rating != null)
            {
                return rating;
            }
            throw new Exception("Feed Not Found");
        }

        public async Task<bool> UpdateRating(Rating rating)
        {
            var result = false;
            _db.Ratings.Update(rating);
            var res = await _db.SaveChangesAsync();
            if (res > 0)
            {
                result = true;
            }
            return result;
        }
    }
}

