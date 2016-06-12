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
            Console.WriteLine(list.ToString());
            Console.WriteLine(new string('=', 21));

            list.RemoveElement(3);
            Console.WriteLine(list.ToString());
            Console.WriteLine(new string('=', 21));

            Console.WriteLine(list.GetElement(4));
            Console.WriteLine(new string('=', 21));

            list.InsertElement(12, 3);
            Console.WriteLine(list.ToString());
            Console.WriteLine(new string('=', 21));

            Console.WriteLine(list.GetIndex(4));
            Console.WriteLine(new string('=', 21));

            list.ClearList();
            Console.WriteLine(list.ToString());
            Console.WriteLine(new string('=', 21));
        }
    }
}
