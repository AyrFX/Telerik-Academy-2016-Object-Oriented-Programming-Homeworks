namespace BankAccounts
{
    class MortgageAccount : Account
    {
        //Constructors
        public MortgageAccount(Customer customer, decimal initialBalance, decimal interestRate) : base(customer, initialBalance, interestRate)
        {
        }

        //Methods
        public override decimal CalculateInterest(int months)
        {
            if (this.AccountCustomer.Type == CustomerType.Company)
            {
                if (months <= 12)
                {
                    return (this.InterestRate / 2) * months;
                }
                else
                {
                    decimal interest = 0;
                    interest = (this.InterestRate / 2) * 12;
                    months -= 12;
                    interest += this.InterestRate * months;
                    return interest;
                }
            }
            else
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    months -= 6;
                    return this.InterestRate * months;
                }
            }
        }
    }
}
