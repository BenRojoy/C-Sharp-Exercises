using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Question9
    {
        public static void Main9()
        {
            int a, b, c, d;

            Console.Write("Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the third number: ");
            c = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the fourth number: ");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The average of {a}, {b}, {c} and {d} is {(a + b + c + d)/4}");

            Console.ReadKey();
        }
    }
}
