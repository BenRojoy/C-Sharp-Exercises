using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Question10
    {
        public static void Main()
        {
            int x, y, z;

            Console.Write("Enter first number: ");
            x = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter second number: ");
            y = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter third number: ");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result of specified numbers {x}, {y} and {z}: (x+y).z is {(x + y) * z} and x.y + y.z is {x * y + y * z}");

            Console.ReadKey();
        }
    }
}
