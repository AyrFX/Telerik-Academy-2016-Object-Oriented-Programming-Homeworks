namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;

    public class Chair : Furniture, IFurniture, IChair
    {
        //Fields
        private int numberOfLegs;
        public Chair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }
            private set
            {
                this.numberOfLegs = value;
            }
        }
    }
}
