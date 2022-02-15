using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class xStage2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Stage2ID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int LanguageID { get; set; }
        public string Comment { get; set; }
    }
}
