using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class Referral
    {
        public string ReferrerUserID { get; set; }
        public string ReferredUserID { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
