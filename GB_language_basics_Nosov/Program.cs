using System;

namespace GB_language_basics_Nosov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x1: ");
            double x1 = float.Parse(Console.ReadLine());
            Console.Write("Введите y1: ");
            double y1 = float.Parse(Console.ReadLine());
            Console.Write("Введите x2: ");
            double x2 = float.Parse(Console.ReadLine());
            Console.Write("Введите y2: ");
            double y2 = float.Parse(Console.ReadLine());
            double r = CalcIndexMass(x1, y1, x2, y2);
            Console.WriteLine($"Растояние {r:F2}");
        }

        private static double CalcIndexMass(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
