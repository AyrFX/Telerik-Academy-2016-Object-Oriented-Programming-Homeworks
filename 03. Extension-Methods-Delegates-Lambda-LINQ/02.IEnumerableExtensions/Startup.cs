namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main()
        {
            var someCollection = new List<int>();
            someCollection.Add(7);
            someCollection.Add(3);
            someCollection.Add(4);
            someCollection.Add(12);
            someCollection.Add(21);
            someCollection.Add(16);
            someCollection.Add(24);
            Console.WriteLine("Sum: " + someCollection.Sum<int>());
            Console.WriteLine("Product: " + someCollection.Product<int>());
            Console.WriteLine("Min: " + someCollection.Min<int>());
            Console.WriteLine("Max: " + someCollection.Max<int>());
            Console.WriteLine("Average: " + someCollection.Average<int>());
        }
    }
}
