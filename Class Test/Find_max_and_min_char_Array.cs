using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    internal class Find_max_and_min_char_Array
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'b', 'c', 's', 'e', 'w' };
            char min = ch[0];
            char max = ch[0];

            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i] > max)
                {
                    max = ch[i];

                }
                if (ch[i] < min)
                {
                    min = ch[i];

                }
            }
            Console.WriteLine("mazimum character "+max);
            Console.WriteLine("min character "+min);
        }
    }
}
