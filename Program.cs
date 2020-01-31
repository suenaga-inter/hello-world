using System;
using System.Linq;
using System.Collections.Generic;

namespace hello_world
{
    class Program
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var numbers = Enumerable.Range(1, 100);
            var strings = GetStrings(numbers);
            foreach (var s in strings)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        /// <summary>
        /// numbers to strings
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        static IEnumerable<string> GetStrings(IEnumerable<int> numbers)
        {
            try
            {
                return numbers.Select(x => x.ToString());
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}
