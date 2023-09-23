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
            Character c1 = new Character();
            Character c2 = new Character();
            Console.WriteLine($"c1.Speed = {c1.PrintSpeed()}. c2.Speed = {c2.PrintSpeed()}");
            c1.IncreaseSpeed();
            Console.WriteLine($"c1.Speed = {c1.PrintSpeed()}. c2.Speed = {c2.PrintSpeed()}");

            //double result = Calculator.Average2(1, 2, 3);
            //Console.WriteLine(result);
        }
    }
}