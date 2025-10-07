using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##Entity Framework##\n");

            emp2Entities db = new emp2Entities();

            foreach (var dr in db.Employees.OrderBy(e => e.Salary).ToList())
            {
                Console.WriteLine("Id = {0}", dr.Id);
                Console.WriteLine("Name = {0}", dr.Name);
                Console.WriteLine("Age = {0}", dr.Age);
                Console.WriteLine("Address = {0}", dr.Address);
                Console.WriteLine("Salary = {0}", dr.Salary);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
