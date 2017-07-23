using System;

namespace NestedLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            var readLine = Console.ReadLine().Split(' ');
            var actualReturnDate = new DateTime(Convert.ToInt32(readLine[2]), Convert.ToInt32(readLine[1]), Convert.ToInt32(readLine[0]));
            readLine = Console.ReadLine().Split(' ');
            var returnDate = new DateTime(Convert.ToInt32(readLine[2]), Convert.ToInt32(readLine[1]), Convert.ToInt32(readLine[0]));
            var fine = CalcFine(actualReturnDate, returnDate);
            Console.WriteLine(fine);
        }

        private static int CalcFine(DateTime actualReturnDate, DateTime returnDate)
        {
            if (actualReturnDate < returnDate)
            {
                return 0;
            }
            if (actualReturnDate.Month == returnDate.Month && actualReturnDate.Year == returnDate.Year)
            {
                return 15 * (actualReturnDate.Day - returnDate.Day);
            }
            if (actualReturnDate.Year == returnDate.Year)
                return 500 * (actualReturnDate.Month - returnDate.Month);
            return 10000;
        }
    }
}