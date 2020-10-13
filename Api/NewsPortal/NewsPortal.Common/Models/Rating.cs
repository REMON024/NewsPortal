using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Common.Models
{
    public class Rating
    {
        public int ID { get; set; }
        public float Point { get; set; }
        public int? UserID { get; set; }
        public virtual User User { get; set; }
        public int? FeedID { get; set; }
        public virtual Feed Feed { get; set; }

    }
}
