using System;
using System.Collections.Generic;

namespace Waresoft
{
    public partial class Comments
    {
        public int Id { get; set; }
        public int SoftwareId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }

        public virtual Software Software { get; set; }
    }
}
