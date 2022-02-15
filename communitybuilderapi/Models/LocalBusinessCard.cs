using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class LocalBusinessCard
    {
        public int BusinessID { get; set; }
        public string BusinessName { get; set; }
        public string Type { get; set; }
        public string IconURL { get; set; }
    }
}
