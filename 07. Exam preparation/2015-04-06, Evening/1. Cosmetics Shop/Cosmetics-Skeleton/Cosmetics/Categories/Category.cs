namespace Cosmetics.Categories
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Cosmetics.Contracts;
	using Cosmetics.Common;
	
	public class Category: ICategory
	{
		//Fields
		private string categoryName;
		private List<IProduct> products;
				
		//Properties
		public string Name
		{
			get
			{
				return this.categoryName;
			}
			private set
			{
				Validator.CheckIfStringLengthIsValid(value, 15, 2, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", 2, 15));
				this.categoryName = value;
			}
		}
		
		public List<IProduct> Products
		{
			get
			{
				return this.products;
			}
		}
		
		//Constructor
		public Category(string name)
		{
			this.Name = name;
			this.products = new List<IProduct>();
		}
		
        //Methods
		public void AddCosmetics(IProduct cosmetics)
        {
			this.products.Add(cosmetics);
			var sortedList = products
				.OrderBy(x => x.Brand)
				.ThenByDescending(x => x.Price)
				.ToList();
			this.products = sortedList;
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
        	if (this.products.IndexOf(cosmetics) == -1)
    	    {
        		throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
    	    }
        	while (this.products.IndexOf(cosmetics) > -1)
        	{
        		this.products.Remove(cosmetics);
        	}
        }

        public string Print()
        {
        	string result = "";
        	
        	if (this.products.Count == 1)
        	{
        		result += string.Format("{0} category - {1} product in total", this.Name, this.products.Count());
        	}
        	else
        	{
        		result += string.Format("{0} category - {1} products in total", this.Name, this.products.Count());
        	}
        	
        	for (int i = 0; i < this.products.Count; i++)
    		{
    			result += "\n" + this.products[i].Print();
        	}
        	
        	return result;
        }
	}
}
