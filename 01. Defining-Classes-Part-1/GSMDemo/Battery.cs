namespace GSMDemo
{
    public class Battery
    {
        private string model;
        private float hoursIdle;
        private float hoursTalk;
        private BatteryType type;

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

        public BatteryType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public float HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }

        public float HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }

        public Battery(string model)
        {
            this.Model = model;
            this.HoursIdle = 10;
            this.HoursTalk = 4;
        }

        public Battery(string model, BatteryType type, float hoursIdle, float hoursTalk)
            : this(model)
        {
            this.Type = type;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }
    }
}