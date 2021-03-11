using System;

namespace Intro_Github
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.WriteLine("Enter a value for a:");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b:");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{a} times {b} equals {MultilpyNumbers(a,b)}");
        }

        public static int MultilpyNumbers(int a, int b)
        {
            return a * b;
        }
    }
}
