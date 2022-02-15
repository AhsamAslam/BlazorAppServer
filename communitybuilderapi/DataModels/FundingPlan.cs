using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class FundingPlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FundingPlanID { get; set; }
        public int BusinessID { get; set; }
        public int FundingTypeID { get; set; }
        public string PlanTerms { get; set; }
        public string PlanComments { get; set; }
        public DateTime PlanPublicizeDate { get; set; }
        public DateTime? PlanFulfilledDate { get; set; }
    }
}
