using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class Localization
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LocalizationID { get; set; }
        public int LanguageID { get; set; }
        public int SiteID { get; set; }

        //public Site Site { get; set; }
        //public Language Language { get; set; }

        //public IAsyncEnumerable<LocalizationKeyValues> LocalizationKeyValues { get; set; }
    }
}
