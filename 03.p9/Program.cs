using System;

namespace _03.p8
{
    internal class Program
    {
        static void Main()
        {
            float a, b, h, area;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            h = float.Parse(Console.ReadLine());

            area = ((a + b) / 2) * h;
            Console.WriteLine(area);
        }
    }
}
