namespace StringBuilderSubstring
{
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int count)
        {
            StringBuilder result = new StringBuilder();
            result.Append(input.ToString().Substring(index, count));
            return result;
        }
    }
}
