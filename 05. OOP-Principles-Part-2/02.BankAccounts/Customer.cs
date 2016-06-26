namespace BankAccounts
{
    public class Customer
    {
        public CustomerType Type { get; set; }
        public string Name { get; set; }

        public Customer(CustomerType type, string name)
        {
            this.Name = name;
            this.Type = type;
        }
    }
}
