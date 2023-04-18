namespace UnitTesting
{
    public class InsuranceService
    {
        public double CalcPremium(int age, string location)
        {
            double premium = 0.0;
            double discount = 0.5;

            if (location == "rural")
            {
                if (age >= 18 && age < 30)
                {
                    premium = 5.0;
                }
                else if (age >= 30)
                {
                    premium = 2.50;
                }
            }
            else if (location == "urban")
            {
                if (age >= 18 && age <= 35)
                {
                    premium = 6.0;
                }
                else if (age >= 36)
                {
                    premium = 5.0;
                }
            }



             if (age >= 50)
             {
                 premium *= discount;
             } 

            return premium;
        }
    }
}