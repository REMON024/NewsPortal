using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Context.Models
{
    public class Comments
    {
        public int ID { get; set; }
        public string Comment { get; set; }
        public int? UserID { get; set; }
        public virtual User User { get; set; }
        public int? FeedID { get; set; }
        public virtual Feed Feed { get; set; }

    }
}
