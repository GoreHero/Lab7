using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Два треугольника заданы длинами своих сторон.
//Определить, площадь какого из них больше
//(создать метод для вычисления  площади  треугольника по длинам его сторон).
//Для решения задачи можно использовать формулу Герона 
//, где x, y, z – стороны треугольника, p – полупериметр.

namespace HW_Task1
{
    internal class Program
    {
        static double GetAreaTriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }


        static void Main(string[] args)
        {
            Console.Write("Введите стороны первого треугольника через пробел: ");
            string[] side1 = Console.ReadLine().Split(' ');
            double x1 = Convert.ToDouble(side1[0]);
            double y1 = Convert.ToDouble(side1[1]);
            double z1 = Convert.ToDouble(side1[2]);
            double Area1 = GetAreaTriangle(x1, y1, z1); 
            Console.Write("Введите стороны второго треугольника через пробел: ");
            string[] side2 = Console.ReadLine().Split(' ');
            double x2 = Convert.ToDouble(side2[0]);
            double y2 = Convert.ToDouble(side2[1]);
            double z2 = Convert.ToDouble(side2[2]);
            double area2 = GetAreaTriangle(x2, y2, z2);
            Console.WriteLine();
            if (Area1 > area2)
                Console.WriteLine("Площадь первого треугольника больше");
            else
                if (Area1 < area2)
                Console.WriteLine("Площадь второго треугольника больше");
            else
                Console.WriteLine("треугольники равны");
            Console.ReadKey();
        }
    }
}
