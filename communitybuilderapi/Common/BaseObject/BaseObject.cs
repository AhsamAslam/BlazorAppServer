using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Common.BaseObject
{
    public class BaseObject
    {
        [Required]
        public int created_by_id { get; set; } = 0;
        [Required]
        //[DefaultValue(typeof(DateTime), DateTime.Now)]
        //[DefaultValue(DateTime.Now)]
        public DateTime created_datetime { get; set; } = DateTime.Now;
        [Required]
        public DateTime make_active_datetime { get; set; } = DateTime.Now;
        public int? deactivated_by_id { get; set; }
        public DateTime? deactivate_datetime { get; set; }
        [Required]
        public bool invisible { get; set; } = false;
        [Required]
        public bool inactive { get; set; } = false;
    }
}
