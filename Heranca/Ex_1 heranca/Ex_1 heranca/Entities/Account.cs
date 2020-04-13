using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_1_heranca.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public  string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amout) // saque - "virtual" é para sobrepor  valores  - - Quando este método for chamado ira descontar 5.0 
        {
            Balance -= amout + 5.0;
        }

        public void Deposit(double amout) // deposito
        {
            Balance += amout;
        }

    }
}
