using NewsPortal.Common.Models;
using NewsPortal.Common.VM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewPortal.BLL.Interface
{
    public interface IAuthService
    {
        Task<LoginReturn> Login(Login login);
        //Task<List<User>> GetAllUser();
        //Task<User> GetById(int id);
        //Task<bool> UpdateUser(User user);
        //Task<bool> Delete(int id);
    }
}
