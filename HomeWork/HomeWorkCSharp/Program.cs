using System;

namespace HomeWorkCSharp{
    class Program{
        static void Main(string[] args)
        {   
           string login_password = @"johnsilver\qwerty";
           System.Console.Write("Please enter login/password: ");
           string input = Console.ReadLine();
           for (int i = 3; i>0; i--)
           {
            if (login_password == input)
           {
            System.Console.WriteLine("Enter the System");
            break;
           }
           else if (login_password != input){
            System.Console.WriteLine($"Login/password is not correct.Please enter again\nYou have {i} attempts remaining");
            System.Console.Write("Please enter login/password: ");
            input = Console.ReadLine();
           }
           System.Console.WriteLine("The number of available tries have been exceeded");
           }
        }
        // HomeWork 3 ControleFlow
        static void Aundefications(){
            string login_password = @"johnsilver\qwerty";
           System.Console.Write("Please enter login/password: ");
           string input = Console.ReadLine();
           for (int i = 3; i>0; i--)
           {
            if (login_password == input)
           {
            System.Console.WriteLine("Enter the System");
            break;
           }
           else if (login_password != input){
            System.Console.WriteLine($"Login/password is not correct.Please enter again\nYou have {i} attempts remaining");
            System.Console.Write("Please enter login/password: ");
            input = Console.ReadLine();
           }
           System.Console.WriteLine("The number of available tries have been exceeded");
           }
        }
        static void calculate_factorial(){
            int number;
           int i = 1;
           int k = 1;
           System.Console.WriteLine("Enter factorial number to be calculated: ");
           number = int.Parse(Console.ReadLine());
           while (i <= number){
            k*=i;
            i++;
           }
           System.Console.WriteLine(k);
        }
        static void Averange_numbers(){
            int[] array = new int[10];
           int count = 0;
           System.Console.WriteLine("Please enter your positive numbers");
           while(count < 10){
            int input = int.Parse(Console.ReadLine());
            array[count] = input;
            count++;

            if (input == 0){
                break;
            }
            if (input < 0) {
                System.Console.WriteLine("Please enter positive number");
            }
           }
           int sum = 0;
           int add = 0;
            foreach (int b in array){
                if (b > 0 && b % 3 == 0){
                sum += b;
                add++;
                }
            }
            double average = (double)sum / add;
            System.Console.WriteLine($"Average value in array : {average}");
        }
        static void Fibonacci_numbers(){
            System.Console.WriteLine("Please enter number of Fibonacci numbers:");
           int n = int.Parse(Console.ReadLine());
           if (n<=0){
            Console.WriteLine("Enter a positive number.");
            return;
           }
           int[] fab = new int[n];
           fab[0] = 1;
           if (n>1){
            fab[1] = 1;
           }
           for (int i = 2; i < n; i++)
           {
            fab[i] = fab[i -1] + fab[i -2];
           }
           System.Console.WriteLine("Generate numbers fibonacci:");
           foreach (int result in fab)
           {
            System.Console.WriteLine(result);
           }
        }
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
