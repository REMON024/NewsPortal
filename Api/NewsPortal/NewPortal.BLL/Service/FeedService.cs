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
            await _db.Feeds.AddAsync(feed);
            var res = await _db.SaveChangesAsync();
            if(res > 0)
            {
                result = true;
            }
            return result;
        }

        public async Task<bool> Delete(int id)
        {
            bool result = false;
            var feed = await _db.Feeds.Where(p => p.ID == id).FirstOrDefaultAsync();
            _db.Feeds.Remove(feed);
            var res = await _db.SaveChangesAsync();
            if(res > 0)
            {
                result = true;
            }
            return result;
        }

        public async Task<List<Feed>> GetAllFeed()
        {
            return await _db.Feeds.ToListAsync();
        }

        public async Task<Feed> GetById(int id)
        {
            var feed = await _db.Feeds.Where(p => p.ID == id).FirstOrDefaultAsync();
            if(feed != null)
            {
                return feed;
            }
            throw new Exception("Feed Not Found");
        }

        public async Task<bool> UpdateFeed(Feed feed)
        {
            var result = false;
            _db.Feeds.Update(feed);
            var res = await _db.SaveChangesAsync();
            if(res > 0)
            {
                result = true;
            }
            return result;
        }
    }
}
