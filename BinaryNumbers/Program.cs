using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Int32.MaxValue);
            int n = Convert.ToInt32(Console.ReadLine());
            //string binaryN = Convert.ToString(n, 2);
            string binaryN = Convert10To2Radix(n);
            int streak = FindLongestStreak(binaryN);
            Console.WriteLine(streak);
        }

        private static int FindLongestStreak(string binaryN)
        {
            if (string.IsNullOrEmpty(binaryN))
                return 0;
            var charArray = binaryN.ToCharArray();
            var longestStreak = 0;
            var currentStreak = 0;
            for (var i = 0; i < charArray.Length; i++)
            {
                var digit = int.Parse(charArray[i].ToString());
                if (digit == 1)
                {
                    currentStreak++;
                }
                if (digit == 0)
                {
                    if (currentStreak > longestStreak)
                        longestStreak = currentStreak;
                    currentStreak = 0;
                }
            }
            return Math.Max(longestStreak, currentStreak);
        }

        private static string Convert10To2Radix(int value)
        {
            var stack = new Stack<int>();
            while (value > 0)
            {
                stack.Push(value % 2);
                value = value / 2;
            }
            //var result = stack.ToArray().Select((elem, index) => elem * Math.Pow(10, stack.Count - 1 - index));
            //return result.Sum().ToString(CultureInfo.InvariantCulture);
            return String.Join(String.Empty, stack.ToArray());
        }
    }
}