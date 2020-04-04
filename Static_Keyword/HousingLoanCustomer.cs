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
        static double _ROI { get; set; }
        public static double ROI
        {
            get { return _ROI; }
            set { _ROI = value; }
        }

        static HousingLoanCustomer()
        {
            _ROI = 7.5;
        }
        public HousingLoanCustomer(int CustomerId, string Name, double LoanAmount)
        {
            this.CustomerId = CustomerId;
            this.Name = Name;
            this.LoanAmount = LoanAmount;
        }

        public void CalculateIntrest(int months)
        {
            double Intrest = (LoanAmount * _ROI) / 100;
            double RepayAmount = Intrest + LoanAmount;

            Console.WriteLine("Loan Amount:{0} IntAmount:{1} RepayAmount:{2} ROI:{3}", LoanAmount, Intrest, RepayAmount, _ROI);
            Console.WriteLine("EMI:{0}", (RepayAmount / months));
        }

        public static void Enquery(double EnloanAmout, int months)
        {
            Console.WriteLine("ROI:{0}", ROI);
            Console.WriteLine("Loan Amount:{ 0}", EnloanAmout);
            Console.WriteLine("IntAmount:{ 0}", (EnloanAmout * ROI / 100));
            Console.WriteLine("RepayAmount:{ 0}", (EnloanAmout + (EnloanAmout * ROI / 100)));
            Console.WriteLine("EMI Months:{ 0}", months);
            Console.WriteLine("EMI:{ 0}", (EnloanAmout + (EnloanAmout * ROI / 100)) / months);
        }
    }
}
