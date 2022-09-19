using System;

namespace _04.p14
{
    internal class Program
    {
        static void Main()
        {
            double a, b, c;
            string product;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            if ((a < 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0))
            {
                product = "Negative";
                Console.WriteLine(product);
            }
            else if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c > 0) || (a < 0 && b > 0 && c < 0) || (a > 0 && b < 0 && c < 0)) 
            {
                product = "Positive";
                Console.WriteLine(product);
            }
        }
    }
}
