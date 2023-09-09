using System;

namespace HomeWorkCSharp{
    class Program{
        static void Main(string[] args)
        {   
        }
        // HomeWork 3 ControleFlow
        static void finding_the_maximum_value(){
            System.Console.WriteLine("Please enter your first number:");
            int a = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Please enter your second number:");
            int b = int.Parse(Console.ReadLine());
            if (a>b) 
            {
                System.Console.WriteLine($"First number: {a} is max");
            }
            else if (a == b)
            {
                System.Console.WriteLine($"{a} = {b}");
            }
            else {
                System.Console.WriteLine($"Second number {b} is max");
            }
        }
        // HomeWork 2 Basic C#
        static void HomeWork_Profile(){
            System.Console.WriteLine("Please enter your surname:");
            string surname = Console.ReadLine();
            System.Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            System.Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Please enter your weight (kg):");
            double weight = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Please enter your height (m):");
            double height = double.Parse(Console.ReadLine());
            double imt = weight/(height*height);
            System.Console.WriteLine($"Your profil:\nFull name: {surname},{name}\nAge: {age}\nWeight: {weight}\nHeight: {height}\nBody Mass Index: {imt}");
        }
        static void HomeworkGeron(){
            // Geron task (4)
            System.Console.WriteLine("Please enter first side of a triangle (sm) :");
            string input_a = Console.ReadLine();
            System.Console.WriteLine("Please enter second side of a triangle (sm) :");
            string input_b = Console.ReadLine();
            System.Console.WriteLine("Please enter third side of a triangle (sm) :");
            string input_c = Console.ReadLine();
            double a = double.Parse(input_a);
            double b = double.Parse(input_b);
            double c = double.Parse(input_c);
            double p1 = a+b+c;
            double p = p1/2;
            double result = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            System.Console.WriteLine($"Result: {result}");
        }
        static void HomeWork1_3(){
            // 1 task
            System.Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            System.Console.WriteLine($"Your name is {name}");
            // 2 task
            System.Console.Write("Please enter first number:");
            string input = Console.ReadLine();
            int aa = int.Parse(input);
            System.Console.Write("Please enter second number:");
            string input1 = Console.ReadLine();
            int a1 = int.Parse(input1);
            System.Console.WriteLine($"Your first number is : {aa}");
            System.Console.WriteLine($"Your second number is : {a1}");
            // 3 task
            System.Console.WriteLine("Please enter your number:");
            string num1 = Console.ReadLine();
            int n = int.Parse(num1);
            System.Console.WriteLine($"Number of digits : {num1.Length}"); 
    }
   }
}
