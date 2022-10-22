using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task2
{
    internal class Program
    {
        static void GetParamsSph(double r, out double s, out double v)
        {
            s = 4 * Math.PI * r * r;
            v = 4.0 / 3 * Math.PI * r * r * r;

        }
        static void Main(string[] args)
        {
            Console.Write("R= ");
            double r = Convert.ToDouble(Console.ReadLine());
            double s, v;
            GetParamsSph(r, out s, out v);
            Console.WriteLine("{0:.00},  {1:.00}",s,v);
            Console.ReadKey();


        }

    }
}
