using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Common.VM
{
   public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public int Usertype { get; set; }
    }

    public class LoginReturn
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public int UserId { get; set; }

        public string Token { get; set; }
        public int UserRoleId { get; set; }
        public string Role { get; set; }
        public string Message { get; set; }
    }
}
