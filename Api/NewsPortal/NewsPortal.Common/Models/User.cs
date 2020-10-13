using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Common.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Phone_No { get; set; }
        public string  Email { get; set; }
        public bool status { get; set; }
        public int? UserRollID { get; set; }
        public virtual UserRoll UserRoll { get; set; }


        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
    }
}
