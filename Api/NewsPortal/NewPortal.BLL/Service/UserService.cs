using NewPortal.BLL.Interface;
using NewsPortal.Common.Library.Encryption;
using NewsPortal.Common.Models;
using NewsPortal.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPortal.BLL.Service
{
    public class UserService : IUserService
    {
        private readonly NewsPortalContext _db;

        public UserService(NewsPortalContext db)
        {
            _db = db;
        }

        public async Task<bool> AddUser(User user)
        {
            bool result = false;

            user.status = true;
            user.UserRollID = 2;
            user.Password = EncryptionLibrary.EncryptText(user.Password);
            await _db.SystemUsers.AddAsync(user);
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
            var user = _db.SystemUsers.Where(p => p.ID == id).FirstOrDefault();
            _db.SystemUsers.Remove(user);
            var res =await _db.SaveChangesAsync();
            if (res > 0)
            {
                result = true;
            }
            return result;
        }

        public async Task<List<User>> GetAllUser()
        {
          return  _db.SystemUsers.ToList();
        }

        public async Task<User> GetById(int id)
        {
            var user =  _db.SystemUsers.Where(p => p.ID == id).FirstOrDefault();
            if (user != null)
            {
                return user;
            }

            throw new Exception("User Not Found");
        }

        public async Task<bool> UpdateUser(User user)
        {
            bool result = false;
            _db.SystemUsers.Update(user);
            var res = await _db.SaveChangesAsync();

            if (res > 0)
            {
                result = true;
            }
            return result;
        }
    }
}
