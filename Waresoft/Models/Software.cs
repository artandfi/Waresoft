using System;
using System.Collections.Generic;

namespace Waresoft
{
    public partial class Software
    {
        public Software()
        {
            Comments = new HashSet<Comments>();
            Purchases = new HashSet<Purchases>();
        }

        public int Id { get; set; }
        public int DeveloperId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Requirements { get; set; }

        public virtual Developers Developer { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Purchases> Purchases { get; set; }
    }
}
