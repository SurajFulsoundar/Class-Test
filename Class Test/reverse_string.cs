using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    internal class reverse_string
    {
        // WAP to reverse a String.
        static void Main(string[] args)
        {
            string str = "My Name is Suraj ";
            string str2 = "";
            string rev = "";
            char[] ch = str.ToCharArray();

            for (int i = ch.Length - 1; i >= 0; i--)
            {
                rev = rev + ch[i];
            }
            str2 = str2 + rev;
            Console.WriteLine(str2);

        }
    }
}
