using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Ex_1_heranca.Entities
{
    sealed class SavingsAccount : Account  //** "sealed" na frente de class não deixa que seja criada uma sub classe desta  
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amout) // saque - "Override" é para sobrepor  valores quando este método for chamdao nesta classe..
        {                                           //..não irá descontar os 5.0 conforme é descontado na classe "Account"
            Balance -= amout;
        }

        /* Para utilizar a regra da super classe "neste caso a classe Account" e acrescentar mais algumas regras podemos utilizar a palavra """"base""""
         * 
         * public override void Withdraw(double amount) 
         * {
         * base.Withdraw(amount);
         * Balance -= 2.0;  // regra que irá acrescentar a principal 
         * }
         * 
         * Neste caso irá utilizar a regra da classe Account e irá acrescentar mais uma regra ( - 5.0 -2.0 = -7.0)
         * 
         * Quando é utilizado a palavra "sealed" na frente do um método sobreposto faz com que o método não possa ser mais utilizado L 128
         * 
         */

    }
}
