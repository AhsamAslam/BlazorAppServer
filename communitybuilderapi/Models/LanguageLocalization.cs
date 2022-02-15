using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class LanguageLocalization
    {
        public int KeyValueID { get; set; }
        public int LocalizationID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int LanguageID { get; set; }
        public int SiteID { get; set; }
        public string LanguageDescription { get; set; }
        public string LanguageCode { get; set; }
    }
}
