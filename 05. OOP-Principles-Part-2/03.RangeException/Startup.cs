namespace RangeException
{
    using System;

    class Startup
    {
        static void Main()
        {
            int someInteger = -20;
            try
            {
                if (someInteger < 1 || someInteger > 100)
                {
                    throw new InvalidRangeException<int>("The number is out of the range", 1, 100);
                }
                else Console.WriteLine(someInteger);
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine("{0}. Available range is between {1} and {2}", e.Message, e.RangeStart, e.RangeEnd);
            }

            var someDateTime = new DateTime(2016, 6, 24);
            try
            {
                var startDate = new DateTime(1980, 1, 1);
                var endDate = new DateTime(2013, 12, 31);
                if (startDate > someDateTime || someDateTime > endDate)
                {
                    throw new InvalidRangeException<DateTime>("The date is out of the range", startDate, endDate);
                }
                else
                {
                    Console.WriteLine(someDateTime);
                }
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine("{0}. Available range is between {1} and {2}", e.Message, e.RangeStart, e.RangeEnd);
            }
        }
    }
}
