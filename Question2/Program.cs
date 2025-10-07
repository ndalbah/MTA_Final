using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = { 12, 35, 10, 250, 12, -77, 35, 7, 9, 10 };
            int[] array2 = { 12, -5, 250, 17, 12, 250, 35, 10 };

            Func<int[], int> indexOfLargest = arr => Array.IndexOf(arr, arr.Max());

            int index1 = indexOfLargest(array1);
            int index2 = indexOfLargest(array2);

            Console.WriteLine("Index of the largest element in the first array: " + index1);
            Console.WriteLine("\nIndex of the largest element in the second array: " + index2 + "\n");
        }
    }
}
