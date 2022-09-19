using System;

namespace _04.p14
{
    internal class Program
    {
        static void Main()
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if ((a > b) && (a > c))
            {
                Console.WriteLine(a);
            }
            else if ((b > c) && (b > a)) 
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}
