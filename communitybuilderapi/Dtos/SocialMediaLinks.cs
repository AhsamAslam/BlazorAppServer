using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communitybuilderapi.Dtos
{
    public class SocialMediaLinks
    {
        public int SocialMediaLinksId { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string TwitterLink { get; set; }
        public string YoutubeLink { get; set; }
    }
}
