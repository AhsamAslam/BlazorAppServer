using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communitybuilderapi.Dtos
{
    public class CountryDto
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
        public string NameLong { get; set; }
        public int DefaultLanguageID { get; set; }
        
    }
}
