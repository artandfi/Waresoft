using System;
using System.Collections.Generic;

namespace Waresoft
{
    public partial class Customers
    {
        public Customers()
        {
            Purchases = new HashSet<Purchases>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Purchases> Purchases { get; set; }
    }
}
