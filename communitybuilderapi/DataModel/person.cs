using communitybuilderapi.Common.BaseObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.DataModel
{
    public class person: BaseObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_person { get; set; }
        [StringLength(450)]
        public string asp_net_user_Id { get; set; }
        [StringLength(250)]
        public string prefix { get; set; }
        [StringLength(250)]
        public string first_name { get; set; }
        [StringLength(250)]
        public string last_name { get; set; }
        [MaxLength]
        public string internal_comments { get; set; }
        public int language_default { get; set; } = 1;
    }
}
