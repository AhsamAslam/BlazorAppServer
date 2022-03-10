using communitybuilderapi.Common.BaseObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.DataModel
{
    public class address: BaseObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_address { get; set; }
        [StringLength(120)]
        public string address1 { get; set; }
        [StringLength(120)]
        public string address2 { get; set; }
        [StringLength(120)]
        public string address3 { get; set; }
        [StringLength(120)]
        public string city { get; set; }
        [StringLength(120)]
        public string state { get; set; }
        [StringLength(20)]
        public string postalcode { get; set; }
        [StringLength(120)]
        public string country { get; set; }
        [MaxLength]
        public string telephone1 { get; set; }
        [MaxLength]
        public string telephone2 { get; set; }
        [MaxLength]
        public string telephone3 { get; set; }
        [MaxLength]
        public string email { get; set; }
        [MaxLength]
        public string website { get; set; }
        [MaxLength]
        public string internal_comments { get; set; }

        // Relations
       
    }
}
