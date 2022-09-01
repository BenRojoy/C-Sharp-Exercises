using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Question7
    {
        public static void Main7()
        {
            int a, b;

            Console.Write("Input the first number: ");
            a = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input the second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} x {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");

            Console.ReadKey();
        }
    }
}
