using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class SiteHeader
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SiteHeaderID { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int SiteID { get; set; }
        public int SitePageID { get; set; }


        //Relationship
        //public Site Site { get; set; }
        //public SitePage SitePage { get; set; }
    }
}
