using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> FebuaryIncome = new Dictionary<int, double>();
            int date = 0;
            double income = 0;
            double bestIncome = double.MinValue;
            int bestDate = 0;//Nai dohodonosen den
            Dictionary<int, double> WeakDays = new Dictionary<int, double>();//Dni s oborot po nisuk ot 200
            for (int i = 1; i <= 29; i++)
            {
                date = i;
                Console.Write($"Enter the income for day {date}:");
                income = double.Parse(Console.ReadLine());
                FebuaryIncome.Add(date, income);
                if (income > bestIncome)
                {
                    bestIncome = income;
                    bestDate = i;
                }
                if (FebuaryIncome[date] < 200)
                {
                    WeakDays.Add(date,income);
                }
            }
            WeakDays = WeakDays.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            Console.WriteLine("=============================================================");
            Console.WriteLine($"Best day is {bestDate} and it generated {FebuaryIncome[bestDate]}");
            Console.WriteLine("=============================================================");
            double average = 0;
            double sum = 0;
            int elemCount = 0;
            Console.Write("Enter start day:");
            int startDay = int.Parse(Console.ReadLine());
            Console.Write("Enter end day:");
            int endDay = int.Parse(Console.ReadLine());
            for (int i = startDay; i <= endDay; i++)
            {
                sum += FebuaryIncome[i];
                elemCount++;
            }
            average= sum /elemCount;
            Console.WriteLine($"The average income from Day {startDay} to Day {endDay} is {average}");
            Console.WriteLine("=============================================================");
            Console.WriteLine("The weakest days are:");
            foreach (var pair in WeakDays)
            {
                Console.WriteLine($"Day {pair.Key} and its income is {pair.Value}");
            }
        }
    }
}
