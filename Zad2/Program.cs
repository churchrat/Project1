namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double currNum = 0;
            do
            {
                try
                {
                    currNum = double.Parse(Console.ReadLine());
                }
                catch
                {
                    break;
                }
                if (currNum > 0)
                {
                    double negNum = currNum / -1;
                    Console.WriteLine($"{currNum} --> {negNum}");
                }
            } while (currNum != 0);           
        }
    }
}
