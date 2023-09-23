using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public static class Calculator
    {

        public static bool TryDevide(double divisible,double divisor,out double result)
        {
            result = 0; // даём началное значение out параметру
            if (divisor == 0)
            {
                return false;
            }
            result = divisible/divisor;
            return true;
        }
        public static double CalcSquare(double ac, double ab, double bc)
        {
            if (ac < 0 || ab < 0 || bc < 0)
            {
                Console.WriteLine("Side of the triangle can't be <0");
                return 0;
            }
            double p = (ac + ab + bc) / 2;
            return Math.Sqrt(p * (p - ac) * (p - ab) * (p - bc));
        }
        public static double Average(int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            return (double)sum/numbers.Length;
        }
        public static double Average2(params int[] numbers)  // params позволяет пользователю передавать елементы через запятую
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            return (double)sum / numbers.Length;
        }
    }
}
