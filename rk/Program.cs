using System;

namespace rk
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("ax^2+bx+c = 0");
            Console.WriteLine("Podaj a");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj c");
            c = double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;
            if (delta >= 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                double x2 = (-b - Math.Sqrt(delta)) / 2 * a;

                Console.WriteLine(String.Format("x1={0}, x2={1}", x1, x2));
            } else
            {
                Console.WriteLine("Brak rozwiązań rzeczywistych");
            }
        }
    }
}
