using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    internal class factors
    {
        // WAP to find the factors of given number if it is ,even number, otherwise calculate its square.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());


            if(num % 2 == 0)
            {
                for(int i = 1; i <= num; i++)
                {
                    if(num % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

                
            }
            else
            {
                int square = num * num;
                Console.WriteLine(square);
            }



            

        }
    }
}
