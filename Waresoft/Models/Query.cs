using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Waresoft.Models
{
    public class Query
    {
        public string QueryId { get; set; }

        public string Error { get; set; }

        public int ErrorFlag { get; set; }

        public string DevName { get; set; }

        public decimal AvgPrice { get; set; }

        public List<string> CustNames { get; set; }

        public List<string> CustSurnames { get; set; }
    }
}
