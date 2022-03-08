using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage.Entities
{
    sealed internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        public sealed override void Withdraw(double amount)
        {
            //With sealed on methods i can't do other override again 
            base.Withdraw(amount);
            Balance -= 2.0;
            //Balance -= amount;
        }
    }
}
