using communitybuilderapi.Common.BaseObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.DataModel
{
    public class site:BaseObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_site { get; set; }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid guid { get; set; }
        [Required]
        [StringLength(250)]
        public string name { get; set; }
        [StringLength(150)]
        public string short_description { get; set; }
        [MaxLength]
        public string internal_comments { get; set; }
        [Required]
        [StringLength(250)]
        public string url { get; set; }
        public bool is_master_site { get; set; } = false;
        public bool parent_id { get; set; } = false;
        public int language_default { get; set; } = 1;
        [MaxLength]
        public string facebook_url { get; set; }
        [MaxLength]
        public string twitter_url { get; set; }
        [MaxLength]
        public string youtube_url { get; set; }
        [MaxLength]
        public string instagram_url { get; set; }
    }
}
