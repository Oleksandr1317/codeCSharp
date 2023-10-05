using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            double sq = square.CalcSquare(3.1, 3, 20);
            double sq1 = square.CalcSquare(3.1, 3.2, 2.2);
            Console.WriteLine(sq);
            Console.WriteLine(sq1);
        }
    }
}