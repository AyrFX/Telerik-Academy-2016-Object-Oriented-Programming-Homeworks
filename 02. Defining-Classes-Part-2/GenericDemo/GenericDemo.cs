namespace GenericDemo
{
    using System;

    class GenericDemo
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>();
            list.AddItem(3);
            list.AddItem(4);
            list.AddItem(7);
            list.AddItem(12);
            list.AddItem(16);
            list.AddItem(21);
            Console.WriteLine("Initial list: " + list.ToString());
            Console.WriteLine(new string('=', 21));

            list.RemoveElement(3);
            Console.WriteLine("Element at index 3 removed: " + list.ToString());
            Console.WriteLine(new string('=', 21));

            Console.WriteLine("Element at index 4: " + list.GetElement(4));
            Console.WriteLine(new string('=', 21));

            list.InsertElement(12, 3);
            Console.WriteLine("Element 12 inserted at index 3: " + list.ToString());
            Console.WriteLine(new string('=', 21));

            Console.WriteLine("Index of element with value 4: " + list.GetIndex(4));
            Console.WriteLine(new string('=', 21));

            Console.WriteLine("Min value: " + list.Min());
            Console.WriteLine(new string('=', 21));

            Console.WriteLine("Max value: " + list.Max());
            Console.WriteLine(new string('=', 21));

            list.ClearList();
            Console.WriteLine("Cleared list: " + list.ToString());
            Console.WriteLine(new string('=', 21));
        }
    }
}
