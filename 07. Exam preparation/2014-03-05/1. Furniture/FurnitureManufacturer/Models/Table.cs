namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;

    class Table : Furniture, IFurniture, ITable
    {
        //Fields
        private decimal length;
        private decimal width;

        public Table(string model, string material, decimal price, decimal height, decimal length, decimal width)
            : base(model, material, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                this.length = value;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.width = value;
            }
        }

        public decimal Area
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
