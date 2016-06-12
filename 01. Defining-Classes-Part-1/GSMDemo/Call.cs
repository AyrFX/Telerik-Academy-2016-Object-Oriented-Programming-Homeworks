namespace GSMDemo
{
    using System;

    public class Call
    {
        public DateTime callDate { get; set; }
        public DateTime callTime { get; set; }
        public string callNumber { get; set; }
        public int callDuration { get; set; }

        public Call (DateTime date, DateTime time, string number, int duration)
        {
            this.callDate = date;
            this.callTime = time;
            this.callNumber = number;
            this.callDuration = duration;
        }
    }
}
