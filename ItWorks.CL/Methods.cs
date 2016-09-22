namespace ItWorks.CL
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Caching;

    public static class Methods
    {
        private const int DivideBy = 7;

        /// <summary>
        /// Function that takes in a number, and returns a set of numbers less than the number, and divisible by 7.
        /// </summary>
        public static List<int> Method1(int value)
        {
            var values = new List<int>();

            for (var x = 1; x <= value / DivideBy; x++)
            {
                values.Add(x * DivideBy);
            }

            return values;
        }

        /// <summary>
        /// Same method as the first, but uses a caching mechanism to improve performance.
        /// </summary>
        public static List<int> Method2(int value)
        {
            var cache = MemoryCache.Default;
            var values = cache[value.ToString()] as List<int>;

            if (values == null)
            {
                values = new List<int>();

                for (var x = 1; x <= value / DivideBy; x++)
                {
                    values.Add(x * DivideBy);
                }

                cache[value.ToString()] = values;
            }

            return values;
        }

        /// <summary>
        /// Function that takes in a string value, and returns a string that reverses the characters. 
        /// </summary>
        public static string Method3(string value)
        {
            var charArray = value.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
