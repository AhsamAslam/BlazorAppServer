using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class Languages
    {
        public int LanguageID { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageDescription { get; set; }

        //Custom
        public int DefaultLanguageID { get; set; }
    }
}
