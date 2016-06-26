namespace BankAccounts
{
    using System;
    class Account
    {
        //Fields
        protected Customer AccountCustomer { get; set; }
        protected decimal Balance { get; set; }
        protected decimal InterestRate { get; set; }

        //Constructors
        public Account(Customer customer, decimal initialBalance, decimal interestRate)
        {
            this.AccountCustomer = customer;
            this.Balance = initialBalance;
            this.InterestRate = interestRate;
        }

        //Methods
        void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("The sum for depoist must be positive number!");
            }
            else
            {
                this.Balance += amount;
            }
        }

        public virtual decimal CalculateInterest(int months) => this.InterestRate * months;
    }
}
