using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class xStage1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public int LanguageID { get; set; }
        public string FileName { get; set; }
        public string Comment { get; set; }
        public string Key { get; set; }
        public string Filler { get; set; }
        public string Comment_OLd { get; set; }
        public string Value { get; set; }
    }
}
