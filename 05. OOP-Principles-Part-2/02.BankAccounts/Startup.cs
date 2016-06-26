namespace BankAccounts
{
    using System;

    class Startup
    {
        static void Main()
        {
            var individualCustomer = new Customer(CustomerType.Individual, "Pesho Goshev");
            var companyCustomer = new Customer(CustomerType.Company, "Some company");

            Account[] individualAccounts =
            {
                new DepositAccount(individualCustomer, 300, 3.4m),
                new LoanAccount(individualCustomer, 300, 7.4m),
                new MortgageAccount(individualCustomer, 300, 4.7m)
            };

            Account[] companyAccounts =
            {
                new DepositAccount(companyCustomer, 3000, 1.8m),
                new LoanAccount(individualCustomer, 400, 4.7m),
                new MortgageAccount(individualCustomer, 4000, 3.7m)
            };

            Console.WriteLine("Individual accounts interests for 7 months:");
            Console.WriteLine("===========================================");
            foreach (var account in individualAccounts)
            {
                Console.WriteLine("{0}: {1}", account.GetType().Name, account.CalculateInterest(7));
            }

            Console.WriteLine("Company accounts interests for 7 months:");
            Console.WriteLine("========================================");
            foreach (var account in companyAccounts)
            {
                Console.WriteLine("{0}: {1}", account.GetType().Name, account.CalculateInterest(7));
            }
        }
    }
}
