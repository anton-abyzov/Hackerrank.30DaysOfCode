using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegexPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            var persons = new List<Person>();
            for (int a0 = 0; a0 < N; a0++)
            {
                string[] tokens_firstName = Console.ReadLine().Split(' ');
                string firstName = tokens_firstName[0];
                string emailID = tokens_firstName[1];
                persons.Add(new Person()
                {
                    FirstName = firstName,
                    EmailID = emailID
                });
            }

            var result = new List<string>();
            foreach (var person in persons)
            {
                var regex = new Regex("[a-z\\.]+(@gmail.com)$");
                if (regex.IsMatch(person.EmailID))
                {
                    var email = regex.Match(person.EmailID).Value;
                    result.Add(person.FirstName);
                }
                
            }
            result.Sort();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string EmailID { get; set; }
    }
}