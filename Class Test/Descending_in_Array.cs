using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    internal class Descending_in_Array
    {
        // WAP to sort an array in Descending order.
        static void Main(string[] args)
        {
            int[] arr = { 5,1, 3, 3, 2 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];   //1,5,1,3,1
                        arr[i] = arr[j];    //5,9,3,5,3
                        arr[j] = temp;   //1,5,1,3,1
                    }
                }
            }

            for(int i = 0; i <=arr.Length-1; i ++)
            {
                Console.WriteLine(arr[i]);
            }
            
        }


    }
    
}
