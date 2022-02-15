using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communitybuilderapi.Dtos
{
    public class ReferralDto
    {
        public string ReferrerUserID { get; set; }
        public string ReferredUserID { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
