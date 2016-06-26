namespace BankAccounts
{
    using System;

    class DepositAccount : Account
    {
        //Constructor
        public DepositAccount(Customer customer, decimal initialBalance, decimal interestRate)
            : base(customer, initialBalance, interestRate)
        {
        }

        //Methods
        public void Withdraw(decimal amount)
        {
            if (this.Balance < amount)
            {
                throw new ArgumentException("The amount in the account is not enough!");
            }
            else if (amount < 0)
            {
                throw new ArgumentException("The amount must be positive!");
            }
            else
            {
                this.Balance -= amount;
            }
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return this.InterestRate * months;
            }
        }
    }
}
