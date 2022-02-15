using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class GenericLocalizationKeyValues
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KeyValueID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int LanguageId { get; set; }
        public string Comment { get; set; }
        public Language Language { get; set; }

    }
}
