using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class ClientContacts
    {

        public int ClientID { get; set; }
        public int ContactID { get; set; }
        public DateTime DateAdded { get; set; }
        public string AddedByUserID { get; set; }
    }
}
