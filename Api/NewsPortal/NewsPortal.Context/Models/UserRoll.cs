using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Context.Models
{
    public class UserRoll
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }

    }
}
