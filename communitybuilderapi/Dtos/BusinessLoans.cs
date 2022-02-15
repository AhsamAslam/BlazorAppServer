using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace communitybuilderapi.Dtos
{
    public class BusinessLoans
    {
        public int BusinessLoanId { get; set; }
        public Business Businesses { get; set; }
        public Loans Loans { get; set; }
 

    }
}
