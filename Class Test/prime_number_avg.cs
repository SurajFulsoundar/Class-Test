using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    internal class prime_number_avg
    {
        // Find the avg of prime elements from array.
        static void Main(string[] args) {

            int[] arr = new int[6];
            int sum = 0;
            int count = 0;

            Console.WriteLine("Enter the number ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    sum = sum + arr[i];
                    count++;

                }
            }
            int avg = sum / count;
            Console.WriteLine("The prime number avg is "+avg);
        }
    }
}

























