using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareAreaMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(SquareArea(a));
        }
        static double SquareArea(double sideA) {
            double area = sideA * sideA;
            return area;
        }
    }
}
