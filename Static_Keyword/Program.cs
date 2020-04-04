using System;
using Static_Keyword;

namespace Static_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var LoadnCustomer1 = new HousingLoanCustomer(1, "Fáusio", 4114);
            var LoadnCustomer2 = new HousingLoanCustomer(2, "Luís", 1000);

            LoadnCustomer1.CalculateIntrest(1);
            LoadnCustomer2.CalculateIntrest(1);

            HousingLoanCustomer.ROI = 1.5;

            LoadnCustomer1.CalculateIntrest(1);
            LoadnCustomer2.CalculateIntrest(1);

            Console.ReadKey();


           // var a = Calculation();           statinc class can´t be referenced or use objects


        }
    }
}
