namespace GSMDemo
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery phoneBattery;
        private Display phoneDisplay;
        private List<Call> callHistory;

        private static GSM iphone4S = new GSM("4S", "Apple");

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
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
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public Battery PhoneBattery
        {
            get
            {
                return this.phoneBattery;
            }
            set
            {
                this.phoneBattery = value;
            }
        }

        public Display PhoneDisplay
        {
            get
            {
                return this.phoneDisplay;
            }
            set
            {
                this.phoneDisplay = value;
            }
        }

        public static GSM Iphone4S
        {
            get
            {
                return GSM.iphone4S;
            }
            set
            {
                GSM.iphone4S = value;
            }
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.PhoneBattery = new Battery("Initial model");
            this.PhoneDisplay = new Display(5, 16777216);
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
            this.PhoneBattery = null;
            this.PhoneDisplay = null;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.PhoneBattery = battery;
            this.PhoneDisplay = display;
        }

        public string Information()
        {

            return string.Format("Model {0}; Manufacturer: {1}; Price: {2}; Owner: {3}; Battery: {4}; Display: {5}",
                this.Model, this.Manufacturer, this.Price != 0 ? this.Price.ToString() : "No proce information",
                this.Owner != null ? this.Owner : "No owner information",
                this.PhoneBattery != null ? this.PhoneBattery.Model : "No battery Information",
                this.phoneDisplay != null ? this.phoneDisplay.Size.ToString() : "No display Information");
        }

        public override string ToString()
        {
            return this.Information();
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(int callIndex)
        {
            this.callHistory.RemoveAt(callIndex);
        }

        public void ShowCallHistory()
        {
            if (this.callHistory.Count < 1)
            {
                Console.WriteLine("The call history is empty");
                return;
            }
            foreach (Call call in this.callHistory)
            {
                Console.WriteLine("Date: {0:dd.MM.yy}; Time: {1:hh:mm}; Number: {2}; Duration: {3}", call.callDate, call.callTime, call.callNumber, call.callDuration);
            }
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CallsPrice(decimal pricePerMinute)
        {
            decimal sum = 0;
            foreach (Call call in this.callHistory)
            {
                sum += call.callDuration * (pricePerMinute / 60);
            }

            return sum;
        }
    }
}
