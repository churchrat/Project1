using System.Diagnostics.CodeAnalysis;

namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("Perfect Number!");
            }
            else
            {
                Console.WriteLine("Not a perfect number!");
            }
        }
    }
}
