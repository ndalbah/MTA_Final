using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> baselist = new List<int> { 12, 35, 10, 250, 12, 77, 35, 7, 9, 10 };

            Console.WriteLine($"baselist:\n{string.Join(", ", baselist)}");

            // 1.1 
            int total = baselist.Sum();
            Console.WriteLine("\nQuestion 1.1:");
            Console.WriteLine($"Total of all the numbers in the baselist: {total}");

            // 1.2 
            double average = baselist.Average();
            Console.WriteLine("\nQuestion 1.2:");
            Console.WriteLine($"Average of all the numbers in the baselist: {average}");

            // 1.3 
            var greaterThan30 = baselist.Where(x => x > 30).OrderBy(x => x).ToList();
            Console.WriteLine("\nQuestion 1.3:");
            Console.WriteLine($"Items greater than 30, ordered in ascending order: {string.Join(", ", greaterThan30)}");

            // 1.4
            var queryGreaterThan30 = from num in baselist
                                     where num > 30
                                     orderby num
                                     select num;
            Console.WriteLine("\nQuestion 1.4:");
            Console.WriteLine($"Query syntax - Items greater than 30, ordered in ascending order: {string.Join(", ", queryGreaterThan30)}");

            // 1.5 
            var distinctNumbers = baselist.Distinct().ToList();
            Console.WriteLine("\nQuestion 1.5:");
            Console.WriteLine($"Numbers in the baselist, without repetition: {string.Join(", ", distinctNumbers)}\n");

        }
    }
}
