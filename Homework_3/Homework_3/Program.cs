using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex_number c1 = new Complex_number(1,1);
            Complex_number c2 = new Complex_number(1,2);
            Complex_number result = c1.Plus(c2);
            Console.WriteLine($"Real = {result.Real}. Imaginary = {result.Imaginary}");
        }
    }
}