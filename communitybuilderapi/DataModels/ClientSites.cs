using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class ClientSites
    {
        public int ClientID { get; set; }
        public int SiteID { get; set; }
        public DateTime DateAdded { get; set; }
        public string AddedByUserID { get; set; }

    }
}
