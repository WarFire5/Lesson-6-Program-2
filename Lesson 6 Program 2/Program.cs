using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Program_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A, B, BA;

            Console.WriteLine("Задайте число 'A':");
            A = Console.ReadLine();

            Console.WriteLine("Задайте число 'B':");
            B = Console.ReadLine();

            int a = Convert.ToInt32(A);

            int b = Convert.ToInt32(B);

            int temp;

            temp = a;
            a = b;
            b = temp;

            BA = a + " " + b + ".";

            Console.WriteLine(BA);

            Console.ReadLine();

        }
    }
}
