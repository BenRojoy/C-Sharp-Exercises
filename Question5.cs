using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Question5
    {
        public static void Main5()
        {
            int a, b, t;

            Console.Write("Input the first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            t = a;
            a = b;
            b = t;

            Console.WriteLine("After Swapping:");
            Console.WriteLine($"First number: {a}");
            Console.WriteLine($"Second number: {b}");

            Console.ReadKey();
        }
    }
}
