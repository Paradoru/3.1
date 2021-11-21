using System;

namespace Bonkai
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число k:");
                int k = int.Parse(Console.ReadLine());
                double S = 0;
                for (int i = 1; i <= k; i++)
                {
                    if (i == 3 || i == 4) continue;
                    long Fact = 1;
                    for (int n = 1; n <= i; n++) Fact *= n;
                    S += Math.Pow(-1, i) * Math.Pow(i - 3, 2) / Fact;
                }
                Console.WriteLine($"A={S:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
