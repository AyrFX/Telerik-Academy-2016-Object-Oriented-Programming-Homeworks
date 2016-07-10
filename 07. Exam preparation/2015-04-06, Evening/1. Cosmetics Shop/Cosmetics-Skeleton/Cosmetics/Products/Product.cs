namespace Cosmetics.Products
{
	using System;
	using Cosmetics.Common;
	using Cosmetics.Contracts;
	
	public abstract class Product: IProduct
	{
		//Fields
		private string name;
		private string brand;
		
		//Properties
		public string Name
		{
			get
			{
				return this.name;
			}
			private set
			{
				Validator.CheckIfStringLengthIsValid(value, 10, 3, string.Format(GlobalErrorMessages.InvalidStringLength, "Product name", 3, 10));
				this.name = value;
			}
		}

		public string Brand
		{
			get {
				return this.brand;
			}
			private set
			{
				Validator.CheckIfStringLengthIsValid(value, 10, 2, string.Format(GlobalErrorMessages.InvalidStringLength, "Product brand", 2, 10));
				this.brand = value;
			}
		}

		public virtual decimal Price { get; set; }

		public GenderType Gender { get; private set;}
		
		//Constructors
		public Product(string name, string brand, decimal price, GenderType gender)
		{
			this.Name = name;
			this.Brand = brand;
			this.Price = price;
			this.Gender = gender;
		}
		
		//Methods
		public virtual string Print()
		{
			string result = "";
			
			result += string.Format("- {0} - {1}:\n", this.Brand, this.Name);
    		result += string.Format("  * Price: ${0}\n", this.Price);
    		switch (this.Gender)
    		{
    			case GenderType.Men:
    				result += "  * For gender: Men";
    				break;
    			case GenderType.Women:
    				result += "  * For gender: Women";
    				break;
    			case GenderType.Unisex:
    				result += "  * For gender: Unisex";
    				break;
    		}
    		
    		return result;
		}
	}
}
