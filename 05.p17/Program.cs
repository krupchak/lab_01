using System;

namespace _05.p17
{
    internal class Program
    {
        static int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }

        static void Main()
        {
            int n;

            n = int.Parse(Console.ReadLine());

            int factorial = Factorial(n);
            Console.WriteLine(factorial);
        } 
    }
}
