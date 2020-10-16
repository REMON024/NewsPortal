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
    public class FeedService : IFeedService
    {
        private readonly NewsPortalContext _db;

        public FeedService(NewsPortalContext db)
        {
            _db = db;
        }

        public async Task<bool> AddFeed(Feed feed)
        {
            bool result = false;

            //user.status = true;
            //user.UserRollID = 2;

            await _db.Feeds.AddAsync(feed);
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
            var feed = _db.Feeds.Where(p => p.ID == id).FirstOrDefault();
            _db.Feeds.Remove(feed);
            var res =await _db.SaveChangesAsync();
            if (res > 0)
            {
                result = true;
            }
            return result;
        }

        public async Task<List<Feed>> GetAllFeed()
        {
          return await _db.Feeds.Include(p=>p.Category).ToListAsync();
        }

        public async Task<Feed> GetById(int id)
        {
            var feed =  _db.Feeds.Where(p => p.ID == id).FirstOrDefault();
            if (feed != null)
            {
                return feed;
            }

            throw new Exception("Feed Not Found");
        }

        public async Task<bool> UpdateFeed(Feed feed)
        {
            bool result = false;
            _db.Feeds.Update(feed);
            var res = await _db.SaveChangesAsync();

            if (res > 0)
            {
                result = true;
            }
            return result;
        }
    }
}
