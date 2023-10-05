using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP
{
    class Square
    {
        public double CalcSquare(double ac,double ab,int sin)
        {
            if (ac < 0 || ab < 0) {
                Console.WriteLine("Side of the triangle can't be <0");
                return 0;
            }
            double rads = sin * Math.PI / 180;
                return 0.5 * ac * ab * Math.Sin(rads);
        }
        public double CalcSquare(double ac,double ab,double bc)
        {
            if(ac < 0 || ab < 0 || bc < 0) {
                Console.WriteLine("Side of the triangle can't be <0");
                return 0;
            }
                double p = (ac + ab + bc) / 2;
                return Math.Sqrt(p * (p - ac) * (p - ab) * (p - bc));
        }
    }
}
