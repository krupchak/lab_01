using System;

namespace _03.p12
{
    internal class Program
    {
        static void Main()
        {
            bool result;
            int n = int.Parse(Console.ReadLine());

            if ((n > 20) && (n % 2 != 0))  
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
