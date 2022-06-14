using System;

namespace RandToPi
{
    class Program
    {
        public static double GetRandom()
        {
            var rand = new Random();
            return rand.NextDouble();
        }

        public static bool IsInCircle(double x, double y)
        {
            double radius = Math.Sqrt((x * x) + (y * y));
            if (radius <= 1.0) return true;
            return false;
        }
        static void Main(string[] args)
        {
            double pi;
            Console.WriteLine("Enter number of points: ");
            int points = Int32.Parse(Console.ReadLine());
            int inCirclePoints = 0;

            for (int i = 0; i < points; i++)
            {
                if (IsInCircle(GetRandom(), GetRandom())) inCirclePoints++;
            }
            pi = ((double)inCirclePoints * 4) / (double)points;
            Console.WriteLine($"Pi is {pi}");

            Console.ReadKey();
        }
    }
}
