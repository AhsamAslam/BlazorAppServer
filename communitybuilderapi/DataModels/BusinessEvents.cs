using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class BusinessEvents
    {
        public int BusinessID { get; set; }
        public int EventID { get; set; }
    }
}
