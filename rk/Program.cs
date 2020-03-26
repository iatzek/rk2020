using System;

namespace rk
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1, b = 0, c = -36;
            double delta = b * b - 4 * a * c;

            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine(String.Format("x1={0}, x2={1}", x1, x2));

        }
    }
}
