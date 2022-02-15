using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class FundingPlanInvestor
    {
        public int FundingPlanID { get; set; }
        public int InvestorUserID { get; set; }
    }
}
