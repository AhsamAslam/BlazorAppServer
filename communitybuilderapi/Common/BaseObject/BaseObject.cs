using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Common.BaseObject
{
    public class BaseObject
    {
        public bool IsActive { get; set; }
        public int CreatedByID { get; set; }
        public string CreatedByName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int UpdatedByID { get; set; }
        public string UpdatedByName { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
