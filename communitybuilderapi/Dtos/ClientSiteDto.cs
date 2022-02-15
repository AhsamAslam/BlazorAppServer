using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communitybuilderapi.Dtos
{
    public class ClientSiteDto
    {
        public int ClientID { get; set; }
        public int SiteID { get; set; }
        public DateTime? DateAdded { get; set; }
        public string AddedByUserID { get; set; }
    }
}
