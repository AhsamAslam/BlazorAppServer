using communitybuilderapi.Common.BaseObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class Site: BaseObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SiteID { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string Comments { get; set; }
        public bool IsMasterSite { get; set; }
        public int? ParentID { get; set; }
        public int DefaultLanguageID { get; set; }
        public DateTime DateAdded { get; set; }
        public string AddedByUserID { get; set; }
        public string LogoPath { get; set; }
        public string FacebookURL { get; set; }
        public string TwitterURL { get; set; }
        public string YoutubeURL { get; set; }
        public string InstagramURL { get; set; }

        //Relationship
        //public IAsyncEnumerable<SiteHeader> SiteHeader { get; set; }
        //public IAsyncEnumerable<Business> Business { get; set; }
        //public ICollection<Localization> Localization { get; set; }
    }
}
