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
        static double ROI { get; set; }


        static HousingLoanCustomer()
        {
            ROI = 7.5;
        }
        public HousingLoanCustomer(int CustomerId, string Name, double LoanAmount)
        {
            this.CustomerId = CustomerId;
            this.Name = Name;
            this.LoanAmount = LoanAmount;
        }

        public void CalculateIntrest()
        {
            double Intrest = (LoanAmount * ROI) / 100;
        }
    }
}
