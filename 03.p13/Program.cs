using System;

namespace _03.p12
{
    internal class Program
    {
        static void Main()
        {
            bool result;
            int n = int.Parse(Console.ReadLine());

            if ((n % 9 == 0) || (n % 11 == 0) || (n % 13 == 0))
            {
                result = true;
                Console.WriteLine(result);
            }
            else
            {
                result = false;
                Console.WriteLine(result);
            }
        }
    }
}
