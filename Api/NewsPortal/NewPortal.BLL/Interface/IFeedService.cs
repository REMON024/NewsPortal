using NewsPortal.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewPortal.BLL.Interface
{
    public interface IFeedService
    {
        Task<bool> AddFeed(Feed feed);
        Task<List<Feed>> GetAllFeed();
        Task<Feed> GetById(int id);
        Task<bool> UpdateFeed(Feed feed);
        Task<bool> Delete(int id);
    }
}
