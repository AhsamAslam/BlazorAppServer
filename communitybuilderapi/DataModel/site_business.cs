using communitybuilderapi.Common.BaseObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.DataModel
{
    public class site_business : BaseObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_site_business { get; set; }
        [Required]
        public int id_site { get; set; }
        [Required]
        public int id_business { get; set; }
        [MaxLength]
        public string internal_comments { get; set; }
    }
}
