using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 calc = new Class1();
            calc.CalcSquare(10, 20, 30);
            calc.CalcSquare(ac: 10,ab: 20,bc: 30);
        }
    }
}