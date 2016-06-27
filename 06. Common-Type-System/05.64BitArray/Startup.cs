namespace SixtyFourBitArray
{
    using System;

    class Startup
    {
        static void Main()
        {
            var firstArray = new SixtyFourBitArray();
            foreach (var item in firstArray)
            {
                System.Console.Write(item);
            }

            Console.WriteLine();
            firstArray[7] = 1;
            firstArray[12] = 1;
            firstArray[28] = 1;
            foreach (var item in firstArray)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            var secondArray = new SixtyFourBitArray();
            Console.WriteLine(firstArray == secondArray);
        }
    }
}
