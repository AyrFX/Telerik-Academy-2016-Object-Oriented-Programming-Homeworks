namespace BankAccounts
{
    class LoanAccount : Account
    {
        //Constructor
        public LoanAccount(Customer customer, decimal initialBalance, decimal interestRate)
            : base(customer, initialBalance, interestRate)
        {
        }

        //Methods
        public override decimal CalculateInterest(int months)
        {
            if (this.AccountCustomer.Type == CustomerType.Individual)
            {
                months -= 3;
            }
            else if (this.AccountCustomer.Type == CustomerType.Company)
            {
                months -= 2;
            }

            if (months <= 0)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterest(months);
            }
        }
    }
}
