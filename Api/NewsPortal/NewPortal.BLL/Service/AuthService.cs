using Microsoft.EntityFrameworkCore;
using NewPortal.BLL.Interface;
using NewsPortal.Common.Models;
using NewsPortal.Common.VM;
using NewsPortal.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPortal.BLL.Service
{
    public class AuthService : IAuthService
    {
        private readonly NewsPortalContext _db;

        public AuthService(NewsPortalContext db)
        {
            _db = db;
        }

        public async Task<User> Login(Login login)
        {
            string password = "";
            var user = await _db.SystemUsers.Where(p => p.Username == login.UserName && p.Password == password && p.status==true).Select(c => new User()
            {
                Name=c.Name,
                Email=c.Email,
                ID=c.ID,
                Phone_No=c.Phone_No,
                status=c.status,
                Username=c.Username,
                UserRoll=c.UserRoll,
                UserRollID=c.UserRollID

            }).FirstOrDefaultAsync();

            if (user != null)
            {
                return user;
            }

            throw new Exception("Invalid User Name/ Password");
        }

        
    }
}
