﻿using NewPortal.BLL.Interface;
using NewsPortal.Common.Models;
using NewsPortal.Context;
using System;
using System.Collections.Generic;
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

            await _db.SystemUsers.AddAsync(user);
            var res = await _db.SaveChangesAsync();
            if (res > 0)
            {
                result = true;
            }

            return result;
        }
    }
}
