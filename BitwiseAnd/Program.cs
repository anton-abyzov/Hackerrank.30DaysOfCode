using System;
using System.Collections.Generic;
using System.Linq;

namespace BitwiseAnd
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);

                var resultSet = new List<int>();
                for (var i = 1; i <= n; i++)
                    for (var j = i + 1; j <= n; j++)
                    {
                        var bitwiseAnd = i & j;
                        if (bitwiseAnd < k)
                            resultSet.Add(bitwiseAnd);
                    }

                var maxValue = resultSet.Max();
                Console.WriteLine(maxValue);
            }
        }
    }
}
