using communitybuilderapi.Common.BaseObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.DataModel
{
    public class business: BaseObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_business { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid guid { get; set; }
        [Required]
        [StringLength(250)]
        public string name { get; set; }
        [StringLength(150)]
        public string tagline { get; set; }
        [StringLength(150)]
        public string type { get; set; }
        [StringLength(150)]
        public string short_description { get; set; }
        [MaxLength]
        public string our_story { get; set; }
        [MaxLength]
        public string internal_comments { get; set; }
        [Column(TypeName = "decimal(8,6)")]
        public decimal latitude { get; set; }
        [Column(TypeName = "decimal(9,6)")]
        public decimal longitude { get; set; }
        public int language_default { get; set; } = 1;
        [MaxLength]
        public string search_terms { get; set; }
        public int? locally_owned { get; set; }

        //Relation

        public virtual ICollection<business_address> business_addresses { get; set; }
    }
}
