using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Sqrt_a_b_
    {
        //Accept two numbers a and b. Find value of a^b.

        static void Main(string[] args)
        {
            int a, b,c=1;
            Console.WriteLine("Enter the value of a:");
            a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of b:");
            b=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= b; i++)
            {
                c = c * a;
            }
            Console.WriteLine($"a^b is{c}");
        }
    }
}
