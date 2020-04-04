using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Keyword
{
    public class HousingLoanCustomer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public double LoanAmount { get; set; }
        public double ROI { get; set; }


        public HousingLoanCustomer(int CustomerId, string Name, double LoanAmount, double ROI)
        {
            this.CustomerId = CustomerId;
            this.Name = Name;
            this.LoanAmount = LoanAmount;
            this.ROI = ROI;
        }
    }
}
