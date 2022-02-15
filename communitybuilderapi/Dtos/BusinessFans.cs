using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communitybuilderapi.Dtos
{
    public class BusinessFans
    {
        public string BusinessName { get; set; }
        public int NumberOfFans { get; set; }
        public int ThisWeek { get; set; }
    }
}
