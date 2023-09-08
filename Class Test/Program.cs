using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int i = 1;
            while(i <= 50)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Welcome to TQ");     // 3 times print.
                    
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("TQ");               //  13 times print.
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Welcome");          // 7 times print.
                }
                i++;
            }*/
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Welcome to TQ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("TQ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Welcome");
                }
            }
        }
    }
}
