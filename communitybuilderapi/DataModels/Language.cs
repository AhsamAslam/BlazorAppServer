using communitybuilderapi.Common.BaseObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class Language: BaseObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LanguageID { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageDescription { get; set; }
        public string LanguageDescNative { get; set; }
    }
}
