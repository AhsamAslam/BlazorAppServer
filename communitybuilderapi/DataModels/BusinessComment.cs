using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class BusinessComment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessCommentID { get; set; }
        public int BusinessID { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string UserID { get; set; }
        public DateTime? PublishDate { get; set; }

        //Relationship
        //public Business Business { get; set; }
    }
}
