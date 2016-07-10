namespace Cosmetics.ShoppingCart
{
	using System;
	using System.Collections.Generic;
	using Cosmetics.Contracts;
	
	public class ShoppingCart: IShoppingCart
	{
		//Fields
		private List<IProduct> products;
		
		//Constructor
		public ShoppingCart()
		{
			this.products = new List<IProduct>();
		}
		
		//Methods
		public void AddProduct(IProduct product)
		{
			this.products.Add(product);
		}

		public void RemoveProduct(IProduct product)
		{
			this.products.Remove(product);
		}

		public bool ContainsProduct(IProduct product)
		{
			return this.products.Contains(product);
		}

		public decimal TotalPrice()
		{
			decimal sum = 0;
			foreach(IProduct product in this.products)
			{
				sum += product.Price;
			}
			
			return sum;
		}
	}
}
