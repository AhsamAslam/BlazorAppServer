using communitybuilderapi.Common.BaseObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class Client: BaseObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public int CountryID { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public DateTime DateAdded { get; set; }
        public string AddedByUserID { get; set; }
    }
}
