using communitybuilderapi.Common.BaseObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class Fan : BaseObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string UserID { get; set; }
        public int BusinessID { get; set; }
        public int ThisWeek { get; set; }
        public DateTime? Date { get; set; }

        //Relationship
        //public Business Business { get; set; }
    }
}
