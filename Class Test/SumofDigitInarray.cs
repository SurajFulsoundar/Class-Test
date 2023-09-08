using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    internal class SumofDigitInarray
    {
        // Find the sum of digit from the string.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string ");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();

            int sum = 0;

            for(int i =0; i < str.Length; i++)
            {
                if (ch[i] >= '0' && ch[i] <= '9')
                {
                    int a = (int)(char.GetNumericValue(ch[i]));
                    sum = sum + a;
                } 

            }
            Console.WriteLine($"The Sum of Digit is {sum}");
        }
    }
}
