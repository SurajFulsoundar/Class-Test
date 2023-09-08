using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    internal class revers_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());

            //  213  ----->  312

            int rev = 0;
            int remd = 0;
             while(num != 0)
            {
                remd = num % 10;
                rev = (rev * 10) + remd;
                num = num / 10;


            }
            Console.WriteLine(rev);
        }
    }
}
