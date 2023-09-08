using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    internal class Sum_of__Elements
    {
        // Find the sum of element from the array.
        static void Main(string[] args)
        {
            int[] arr = new int [8];
            Console.WriteLine("Enter the Array List ");
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];
                
            }
            Console.WriteLine("The Sum of Elements Array is "+sum);

        }
    }
}
