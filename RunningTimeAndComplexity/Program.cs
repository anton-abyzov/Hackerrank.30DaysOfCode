using System;

namespace RunningTimeAndComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            while (n-- > 0)
            {
                var number = Convert.ToInt32(Console.ReadLine());
                DetermineIfPrime(number);
            }
        }

        private static void DetermineIfPrime(int number)
        {
            if (number < 2)
            {
                Console.WriteLine("Not prime");
                return;
            }
            for (var i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Not prime");
                    return;
                }
            }
            Console.WriteLine("Prime");
        }
    }
}