namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using FurnitureManufacturer.Interfaces;

    class Company : ICompany
    {
        //Fields
        private string name;
        private string registrationNumber;
        private List<IFurniture> furnitures;

        //Constructor
        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }
        
        //Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Name can't be null!");
                }
                if (value == String.Empty)
                {
                    throw new ArgumentException("Name can't be empty!");
                }
                if (value.Length < 5)
                {
                    throw new ArgumentException("Name should be at least 5 symbols!");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            private set
            {
                if (registrationNumber.Length != 10)
                {
                    throw new ArgumentException("The registration number should be 10 symbols long!");
                }
                for (int i = 0; i < registrationNumber.Length; i++)
                {
                    if (registrationNumber[i] < 48 || registrationNumber[i] > 57)
                    {
                        throw new ArgumentException("The registration number should consist of digits only!");
                    }
                }
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
            }
        }

        //Methods
        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public string Catalog()
        {
            throw new NotImplementedException();
        }

        public IFurniture Find(string model)
        {
            for (int i = 0; i < this.furnitures.Count; i++)
            {
                if (this.furnitures[i].Model.ToLower() == model.ToLower())
                {
                    return this.furnitures[i];
                }
            }
            return null;
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }
    }
}
