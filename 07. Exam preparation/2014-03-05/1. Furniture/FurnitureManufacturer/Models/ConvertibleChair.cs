namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;

    class ConvertibleChair : Chair, IConvertibleChair
    {
        //Fields
        private bool isConverted;

        public ConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {
            this.IsConverted = false;
        }

        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }
            private set
            {
                this.isConverted = value;
            }
        }

        public override decimal Height
        {
            get
            {
                if (this.IsConverted)
                {
                    return 0.1m;
                }
                else
                {
                    return this.height;
                }
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

        public void Convert()
        {
            this.IsConverted = !this.IsConverted;
        }
    }
}
