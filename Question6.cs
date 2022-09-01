using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Question6
    {
        public static void Main6()
        {
            int a, b, c;

            Console.Write("Input the first number to multiply: ");
            a = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input the second number to multiply: ");
            b = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input the third number to multiply: ");
            c = Convert.ToInt32(Console.ReadLine());


            Console.Write($"{a} x {b} x {c} = {a * b *c}");

            Console.ReadKey();
        }
    }
}
