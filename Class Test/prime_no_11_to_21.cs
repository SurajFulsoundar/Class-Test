using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    internal class prime_no_11_to_21
    {
        static void Main(string[] args)
        {



            for (int i = 11; i <= 21; i++)
            {
                int a = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        a = 1;
                        break;

                    }
                }
                if (a == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
