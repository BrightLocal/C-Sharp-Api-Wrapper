using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class RfGetReviews
    {
        public int reportId { get; set; }
        public string directory { get; set; }
        public int stars { get; set; }
        public string sort { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
    }
}
