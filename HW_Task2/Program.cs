using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
namespace HW_Task2
{
    internal class Program
    {
        static void GetParamsCube(double face, out double V, out double S)
        {
            V = Math.Pow(face, 3);
            S = 6 * Math.Pow(face, 2);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите длину грани куба: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double V, S;

            GetParamsCube(a, out V, out S);
            Console.WriteLine("Объем куба = {0:.00},\nплощадь куба =  {1:.00}", V, S);
            Console.ReadKey();
        }
    }
}
