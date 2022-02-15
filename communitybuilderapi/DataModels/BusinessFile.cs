using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class BusinessFile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FileID { get; set; }
        public int BusinessID { get; set; }
        public string FileURL { get; set; }
        public string IconURL { get; set; }
        public int? SortIndex { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime? Stamp { get; set; }

        //Relationship
        //public Business Business { get; set; }
    }
}
