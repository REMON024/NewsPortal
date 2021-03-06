﻿using NewsPortal.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewPortal.BLL.Interface
{
    public interface IUserService
    {
        Task<bool> AddUser(User user);
        Task<List<User>> GetAllUser();
        Task<User> GetById(int id);
        Task<bool> UpdateUser(User user);
        Task<bool> Delete(int id);
    }
}
