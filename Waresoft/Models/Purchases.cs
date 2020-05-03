using System;
using System.Collections.Generic;

namespace Waresoft
{
    public partial class Purchases
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int SoftwareId { get; set; }
        public DateTime Date { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Software Software { get; set; }
    }
}
