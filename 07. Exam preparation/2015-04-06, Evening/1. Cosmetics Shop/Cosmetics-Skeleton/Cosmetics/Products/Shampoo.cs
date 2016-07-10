namespace Cosmetics.Products
{
	using System;
	using Cosmetics.Common;
	using Cosmetics.Contracts;
	
	public class Shampoo: Product, IShampoo
	{
		//Properties
		public override decimal Price
		{
			get
			{
				return base.Price * this.Milliliters;
			}
			set
			{
				base.Price = value;
			}
		}
		public uint Milliliters {get; private set; }
		public UsageType Usage { get; private set; }
		
		//Constructor
		public Shampoo(string name, string brand, decimal price, GenderType gender, uint mililiters, UsageType usage)
			: base(name, brand, price, gender)
		{
			this.Milliliters = mililiters;
			this.Usage = usage;
		}
		
		//Methods
		public override string Print()
		{
			string result = "";
			
//			result += string.Format("- {0} - {1}:\n", this.Brand, this.Name);
//    		result += string.Format("  * Price: ${0}\n", this.Price);
//    		switch (this.Gender)
//    		{
//    			case GenderType.Men:
//    				result += "  * For gender: Men\n";
//    				break;
//    			case GenderType.Women:
//    				result += "  * For gender: Women\n";
//    				break;
//    			case GenderType.Unisex:
//    				result += "  * For gender: Unisex\n";
//    				break;
//    		}
			result += base.Print() + "\n";
    		result += string.Format("  * Quantity: {0} ml\n", this.Milliliters);
    		switch (this.Usage)
    		{
    			case UsageType.EveryDay:
    				result += "  * Usage: EveryDay";
    				break;
    			case UsageType.Medical:
    				result += "  * Usage: Medical";
    				break;
    		}
    		
    		return result;
		}
	}
}
