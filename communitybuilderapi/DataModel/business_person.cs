using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.DataModel
{
    public class business_person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_business_person { get; set; }
        [Required]
        public int id_business { get; set; }
        [Required]
        public int id_person { get; set; }
        [Required]
        public bool is_owner { get; set; } = false;
        [Required]
        public bool is_contact { get; set; } = false;
        [Required]
        public bool is_administrative { get; set; } = false;
        [StringLength(250)]
        public string title { get; set; }
        [MaxLength]
        public string internal_comments { get; set; }
    }
}
