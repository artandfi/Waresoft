using System;
using System.Collections.Generic;

namespace Waresoft
{
    public partial class Developers
    {
        public Developers()
        {
            Software = new HashSet<Software>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Software> Software { get; set; }
    }
}
