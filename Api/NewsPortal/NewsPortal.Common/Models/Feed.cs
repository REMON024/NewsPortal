using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Common.Models
{
    public class Feed
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public bool isHeadline { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
    }
}
