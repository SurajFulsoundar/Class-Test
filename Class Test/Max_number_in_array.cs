using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    internal class Max_number_in_array
    {
        // Find the Max number from array.
        static void Main(string[] args)
        {
            int[] arr = { 12, 21, 22, 100, 24, 25, 35, 27, 28, 29, 30, };

              int max = arr[0];

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Max number is {max}");
        }
    }
}
