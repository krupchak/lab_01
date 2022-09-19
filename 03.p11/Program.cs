using System;

namespace _03.p11
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int nDigit = (int)(number / Math.Pow(10, n - 1)) % 10;

            if (nDigit != 0)
            {
                Console.WriteLine(nDigit);
            }
            else 
            {
                Console.WriteLine("-");
            }
        }
    }
}
