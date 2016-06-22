namespace Divisable
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main(string[] args)
        {
            int[] numbersArray = { 16, 7, 3, 12, 24, 4, 21, 18, 27, 28, 32, 63 };

            var selectedWithMethods =
                numbersArray
                .Where(n => n % 7 == 0 && n % 3 == 0)
                .Select(n => n);

            var selecredWithLINQ =
                from number in numbersArray
                where number % 7 == 0 && number % 3 == 0
                select number;

            foreach (var number in selectedWithMethods)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(new string('=', 20));

            foreach (var number in selecredWithLINQ)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}