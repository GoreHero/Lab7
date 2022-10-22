using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task2
{
    internal class Program
    {
        static double GetHyp(double a, double b)
        {
            return Math.Sqrt(a*a + b*b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Катеты первого треугольника:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = GetHyp(x1, y1);
            Console.WriteLine("катеты второго треугольника:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2  = GetHyp(x2, y2);

            if (z1 > z2)
                Console.WriteLine("1>");
            else
                if (z2 < z1)
                Console.WriteLine("2>");
            else
                Console.WriteLine("=");
            Console.ReadKey();


        }

    }
}
