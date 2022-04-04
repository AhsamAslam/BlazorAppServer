using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.DataModel
{
    public class video
    {
        public int videoId { get; set; }
        public string name { get; set; }
        public string size { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }
}
