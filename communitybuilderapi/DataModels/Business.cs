using communitybuilderapi.Common.BaseObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class Business: BaseObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessID { get; set; }
        public string BusinessName { get; set; }
        public string BusinessAddressStreet { get; set; }
        public string BusinessAddressSuite { get; set; }
        public string BusinessAddressCity { get; set; }
        public string BusinessAddressState { get; set; }
        public string BusinessAddressZipcode { get; set; }
        public string BusinessAddressCountry { get; set; }
        public int? SortIndex { get; set; }
        public int? BusinessNumber { get; set; }
        public string Type { get; set; }
        public bool? Visible { get; set; }
        public int? NumberOfFans { get; set; }
        public string Description { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public bool? Offers { get; set; }
        public string SearchTerms { get; set; }
        public string UserID { get; set; }
        public int? SiteID { get; set; }
        public int LocallyOwned { get; set; }
        public bool? Published { get; set; }
        public DateTime? PublishDate { get; set; }
        public string PublishedByUserID { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public bool Inactive { get; set; }
        public DateTime? DateAdded { get; set; }
        public string AddedByUserID { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        //Relationships

        //public IAsyncEnumerable<BusinessComment> BusinessComment { get; set; }
        //public IAsyncEnumerable<BusinessFile> BusinessFile { get; set; }
        //public IAsyncEnumerable<Fan> Fan { get; set; }
        //public Site Site { get; set; }
    }
}
