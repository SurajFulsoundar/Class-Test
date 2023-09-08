using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    internal class avg_of_even_digit_number
    {
        //  WAP to find the avg of even number.
        // i.e ------>   12345678  ---> 2 + 4 + 6 + 8 = 20 / 4 = 5 avg. 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());


            int remd = 0;
            int sum = 0;
            int count = 0;
            int avg = 0;

            while (num != 0)
            {
                remd = num % 10;
                if (remd % 2 == 0)
                {
                    sum = sum + remd;
                    count++;
                }
                num = num / 10;
            }
            avg = sum / count;


            Console.WriteLine(avg);
        }
    }
}











