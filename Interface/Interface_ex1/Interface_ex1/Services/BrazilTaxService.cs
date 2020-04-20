﻿namespace Interface_ex1.Services
{
    class BrazilTaxService : ITaxService
    {
        public double Tax(double amout)
        {
            if (amout <= 100.00)
            {
                return amout * .2;
            }
            else
            {
                return amout * .15;
            }
        }
    }
}
