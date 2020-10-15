using NewsPortal.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewPortal.BLL.Interface
{
    public interface ICommentService
    {

        Task<bool> AddComments(Comments comments);
        Task<List<Comments>> GetAllComments();
        Task<Comments> GetCommentsbyID(int id);
        Task<bool> UpdateComments(Comments comments);
        Task<bool> Delete(int id);
    }
}
