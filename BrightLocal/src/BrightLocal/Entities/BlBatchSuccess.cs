using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BlBatchSuccess
    {
        public int batchId { get; set; }
        public JobIds jobids { get; set; }
    }

    public class JobIds : Dictionary<string, object>
    {

    }
}
