using communitybuilderapi.Common.BaseObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.DataModel
{
    public class business_address: BaseObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_business_address { get; set; }
        [Required]
        public int id_business { get; set; }
        [Required]
        public int id_address { get; set; }
        [Required]
        public bool is_physical { get; set; } = false;
        [Required]
        public bool is_billing { get; set; } = false;
        [Required]
        public bool is_administrative { get; set; } = false;
        [MaxLength]
        public string internal_comments { get; set; }

        //Relation

        public virtual address address { get; set; }
        public virtual business business { get; set; }
    }
}
