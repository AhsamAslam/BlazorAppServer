using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communitybuilderapi.Dtos
{
    public class GenericLocalizationKeyValuesDto
    {
        public int KeyValueID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int LanguageId { get; set; }
        public string Comment { get; set; }
    }
}
