namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture
    {
        //Fields
        protected decimal height;
        private string model;
        private decimal price;
        private MaterialType material;

        //Constructor
        public Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Price = price;
            this.Height = height;
            this.Material = material;
        }

        public virtual decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (height <= 0m)
                {
                    throw new ArgumentException("Height can't be less or equal to zero!");
                }
                this.height = value;
            }
        }

        public string Material
        {
            get
            {
                switch(this.material)
                {
                    case MaterialType.Leather:
                        return "leather";
                    case MaterialType.Plastic:
                        return "plastic";
                    case MaterialType.Wooden:
                        return "wooden";
                    default:
                        throw new ArgumentException("Invalid material name!");
                }
            }
            set
            {
                switch(value)
                {
                    case "leather":
                        this.material = MaterialType.Leather;
                        break;
                    case "plastic":
                        this.material = MaterialType.Plastic;
                        break;
                    case "wooden":
                        this.material = MaterialType.Wooden;
                        break;
                    default:
                        throw new ArgumentException("Not valid material!");
                }
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Model can't be null!");
                }
                if (value == String.Empty)
                {
                    throw new ArgumentException("Model can't be empty!");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Model should be at least 3 symbols!");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0m)
                {
                    throw new ArgumentException("Price can't be less or equal to zero!");
                }
                this.price = value;
            }
        }
    }
}
