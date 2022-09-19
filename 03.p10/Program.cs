using System;

namespace _03.p10
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int lastDigit;
            lastDigit = n % 10;
            Console.WriteLine(lastDigit);
        }
    }
}
