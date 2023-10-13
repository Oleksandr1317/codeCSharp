using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    public class Complex_number
    {
        public double Real { get;private set; }
        public double Imaginary { get;private set; }
        public Complex_number(double real,double imaginary) 
        {
            Real = real;
            Imaginary = imaginary;
        }
        public Complex_number Plus(Complex_number other)
        {
            double rP = Real + other.Real;
            double iP = Imaginary + other.Imaginary;
            return new Complex_number(rP, iP);
        }
        public  Complex_number Minus(Complex_number other)
        {
            double rP = Real - other.Real;
            double iP = Imaginary - other.Imaginary;
            return new Complex_number(rP, iP);
        }
    }
}
