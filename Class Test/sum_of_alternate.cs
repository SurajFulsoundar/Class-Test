using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    internal class sum_of_alternate
    {
        // WAC to display alternate elements from the array.
        static void Main(string[] args)
        {
            int[] arr = {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16};
            int sum = 0;

            for(int i = 0; i < arr.Length; i = i + 2)
            {
                sum = sum + i;
                
            }
            Console.WriteLine(sum);
        }
    }
}
