using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    internal class sum_of_1st_Digit_and_last_Digit
    {
        /*WAP to calculate sum of 1st number and last number.
         *  i.e --> 312 =   3 + 2 = 5.
         * 
        */ 
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());

            int firstDigit = num;

            while (firstDigit >= 10)
            {
                firstDigit = firstDigit / 10;

            }

            int lastDigit = num % 10;

            int sum = firstDigit + lastDigit;
            Console.WriteLine("The Sum of First Digit and Last Digit is " + sum);






        }  
    }
}
