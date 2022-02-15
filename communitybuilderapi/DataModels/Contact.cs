using communitybuilderapi.Common.BaseObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class Contact: BaseObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string SiteID { get; set; }
        public string UserID { get; set; }
        public string Comment { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string AddressStreet { get; set; }
        public string AddressSuite { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressZip { get; set; }
        public string AddressCountry { get; set; }
    }
}
