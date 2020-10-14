using NewPortal.BLL.Interface;
using NewsPortal.Common.Library.Encryption;
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

        public async Task<LoginReturn> Login(Login login)
        {
            string password =  EncryptionLibrary.EncryptText(login.Password);
            var user = _db.SystemUsers.Where(p => p.Username == login.UserName && p.Password == password && p.status==true).Select(c => new LoginReturn()
            {
                Name=c.Name,
                Email=c.Email,
                UserId=c.ID,
                MobileNo=c.Phone_No,
                UserName=c.Username,
                UserRoleId=c.UserRollID,
                Role=c.UserRoll.Name,

            }).FirstOrDefault();

            if (user != null)
            {
                return user;
            }

            throw new Exception("Invalid User Name/ Password");
        }

        
    }
}
