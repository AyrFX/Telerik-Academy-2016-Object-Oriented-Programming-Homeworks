namespace Cosmetics.Products
{
	using System;
	using  System.Collections.Generic;
	using Cosmetics.Contracts;
	using Cosmetics.Common;
	
	public class Toothpaste: Product, IToothpaste
	{
		//Field
		private List<string> ingradients;
		
		//Properties
		public string Ingredients
		{
			get
			{
				return string.Join(", ", this.ingradients);
				//return this.ingradients;
			}
//			private set
//			{
//				
//			}
		}

		//Constructors
		public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingradients)
			:base(name, brand, price, gender)
		{
			for (int i = 0; i < ingradients.Count; i++)
			{
				Validator.CheckIfStringLengthIsValid(ingradients[i], 12, 4, string.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient", 4, 12));
			}
			this.ingradients = new List<string>();
			this.ingradients.AddRange(ingradients);
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
    		result += "  * Ingredients: " + this.Ingredients;
    		
    		return result;
		}
	}
}
