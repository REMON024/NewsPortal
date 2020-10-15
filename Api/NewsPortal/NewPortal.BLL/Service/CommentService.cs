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


    public class CommentService : ICommentService
    {

        private readonly NewsPortalContext _db;
        public CommentService(NewsPortalContext db)
        {
            _db = db;

        }
        public async Task<bool> AddComments(Comments comments)
        {
            bool result = false;
            await _db.Comments.AddAsync(comments);
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
            var comment = await _db.Comments.Where(p => p.ID == id).FirstOrDefaultAsync();
            _db.Comments.Remove(comment);
            var res = await _db.SaveChangesAsync();
            if (res > 0)
            {
                result = true;
            }
            return result;
        }

        public async Task<List<Comments>> GetAllComments()
        {
            return await _db.Comments.ToListAsync();
        }

        public async Task<Comments> GetCommentsbyID(int id)
        {
            var comment = await _db.Comments.Where(p => p.ID == id).FirstOrDefaultAsync();
            if (comment != null)
            {
                return comment;
            }
            throw new Exception("Feed Not Found");
        }

        public async Task<bool> UpdateComments(Comments comments)
        {
            var result = false;
            _db.Comments.Update(comments);
            var res = await _db.SaveChangesAsync();
            if (res > 0)
            {
                result = true;
            }
            return result;
        }
    }
}
