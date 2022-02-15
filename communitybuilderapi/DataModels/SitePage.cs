﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class SitePage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SitePageID { get; set; }
        public string Name { get; set; }
    }
}
