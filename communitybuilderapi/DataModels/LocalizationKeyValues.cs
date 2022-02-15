using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class LocalizationKeyValues
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KeyValueID { get; set; }
        public int LocalizationID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        //public Localization Localization { get; set; }
    }
}
