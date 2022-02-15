using communitybuilderapi.Common.BaseObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class CustomCss : BaseObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomCssID { get; set; }
        public string TextColor { get; set; }
        public string FontSize { get; set; }
        public string FontWeight { get; set; }
        public string FontFamily { get; set; }
        public string TextDecoration { get; set; }
        public string BackGroundColor { get; set; }
        public string Tag { get; set; }
        public int SitePageID { get; set; }
    }
}
