using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingData
{
    public class Account
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value > 0 ? value : 0; } // if value is greater to zero, set it to balance otherwise set it to zero
        }

        public Account(decimal initBalance = 0)
        {
            Balance = initBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0) balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            bool result = false;
            if (amount >= 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    result = true; // success

                }
            }

                return result;
            }

        
    }
}
