using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Question8
    {
        public static void Main8()
        {
            int a, i;

            Console.Write("Enter the number: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{a} * {i} = {a * i}");
            }

            Console.ReadKey();
        }
    }
}
