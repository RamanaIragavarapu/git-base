using System;
namespace Evenorodd
{
    static class EvenOdd
    {
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter The Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Given Number Is An Even Number");
            }
            else
            {
                Console.WriteLine("Given Number Is Not An Even Number");
            }
        }
    }
}