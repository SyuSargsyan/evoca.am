using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoca.am.data
{
    public class Loan
    {
        public string LoanContract { get; set; }

        public  Loan (string LoanContract)
        {
            this.LoanContract = LoanContract;
        }

        public static Loan testLoan;
        public static Loan syuLoan = new Loan("TV275480");

    }
}
