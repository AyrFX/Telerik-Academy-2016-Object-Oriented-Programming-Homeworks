namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            dynamic result = 0;
            foreach (T element in collection)
            {
                result += element;
            }
            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            dynamic result = 1;
            foreach (T element in collection)
            {
                result *= element;
            }
            return result;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            T min = collection.First();
            foreach (T element in collection)
            {
                if (element.CompareTo(min) < 0)
                {
                    min = element;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            T max = collection.First();
            foreach (T element in collection)
            {
                if (element.CompareTo(max) > 0)
                {
                    max = element;
                }
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            dynamic result = 0;
            foreach (T element in collection)
            {
                result += element;
            }

            return result/collection.Count();
        }
    }
}
