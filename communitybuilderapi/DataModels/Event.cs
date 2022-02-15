using communitybuilderapi.Common.BaseObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class Event: BaseObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventID { get; set; }
        public string VirtualOrPhysical { get; set; }
        public string VirtualType { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Time { get; set; }
        public string TimeZone { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string Hyperlink1 { get; set; }
        public string Hyperlink2 { get; set; }
        public string Comment { get; set; }
        public DateTime? DateAdded { get; set; }
        public string AddedByUserID { get; set; }
        public bool Inactive { get; set; }
        public DateTime? DeactivateOn { get; set; }
        public string DeactivatedByUserID { get; set; }
    }
}
