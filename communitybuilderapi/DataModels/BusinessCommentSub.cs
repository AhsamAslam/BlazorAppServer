using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class BusinessCommentSub
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubCommentID { get; set; }
        public int CommentID { get; set; }
        public string UserID { get; set; }
        public string Comment { get; set; }
        public DateTime PublishDate { get; set; }
        public bool Inactive { get; set; }
    }
}
