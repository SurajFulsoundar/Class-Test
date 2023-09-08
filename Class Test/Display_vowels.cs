using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    internal class Display_vowels
    {
        // Display all the vowels from the array.
        static void Main(string[] args)
        {
            char[] arr = {'e', 'i', 'd', 'p', 'u', 'z', 'y', 'x', 'h' };
            string vowels = "";
            int count = 0;

            for(int i =  0; i < arr.Length; i++) 
            {
                if (arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u')
                {
                    vowels = vowels + arr[i];
                    count++;
                } 
            }
            Console.WriteLine($"The vowels in the array is {count} this vowel is "+vowels);
        }
    }
}
