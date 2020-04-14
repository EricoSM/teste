using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3_Poli.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0.0;
            if (AnualIncome < 20000.0)
            {
                tax = (AnualIncome * 15 / 100) - (HealthExpenditures * 50 /100);
            }
            else
            {
                tax = (AnualIncome * 25 / 100) - (HealthExpenditures * 50 / 100);
            }

            return tax;
            ;
        }
    }
}
