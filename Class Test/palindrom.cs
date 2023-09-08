using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    internal class palindrom
    {
        // WAP to Check given number is palindrome or not.
        static void Main(string[] args)
        {
            int num = 121;
            int remd = 0;
            int rev = 0;
            int temp = num;

            while(num != 0)
            {
                remd = num % 10;
                rev = (rev * 10) + remd;
                num = num / 10;
            }
            num = temp;
           
            if(num == rev)
            {
                Console.WriteLine(" Number is Palindrom ");

            }
            else
            {
                Console.WriteLine(" Number is not Palindrom ");
            }
        }
    }
}
