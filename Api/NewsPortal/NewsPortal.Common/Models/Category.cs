using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Common.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Feed> Feeds { get; set; }
    }
}
