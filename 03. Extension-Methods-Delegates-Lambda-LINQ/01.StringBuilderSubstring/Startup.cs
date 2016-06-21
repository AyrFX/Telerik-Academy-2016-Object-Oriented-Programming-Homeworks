namespace StringBuilderSubstring
{
    using System;
    using System.Text;

    class Startup
    {
        static void Main()
        {
            int index = 3;
            int count = 7;
            StringBuilder someSB = new StringBuilder();
            someSB.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Console.WriteLine(someSB.Substring(index, count));
        }
    }
}
