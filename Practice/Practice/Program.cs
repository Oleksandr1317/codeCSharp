using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Practice
{
    class Program{
        static void Main(string[] args){
        }
        static void Practice_Day3(){
            int input;
            int result = 1;
            System.Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input == 0){
                result = 1;
            }
            else if (input < 0){
                System.Console.WriteLine("Please enter positive number");
                input = int.Parse(Console.ReadLine());
            } else {
            for(int i = 1;i <= input;i++){
                result *= i;
            }
            System.Console.WriteLine(result);
            }
            System.Console.WriteLine();
            var intList = new List<int> {1,2,3,4,5,6};
            int result1 = 0;
            for(int i = 0;i < intList.Count;i++){
                result += intList[i];
            } 
            System.Console.WriteLine(result1);
            System.Console.WriteLine();
            string[] name = new string[] {"John","Anna","Anatolii","Bob","Carl","Leam"};
            Array.Sort(name);
            System.Console.WriteLine(String.Join(",",name));
        }
        static void Practice_day2(){
            double a,b,division;
            System.Console.Write("Please enter numerator:");
            a = double.Parse(Console.ReadLine());
            System.Console.Write("Please enter denumerator:");
            b = double.Parse(Console.ReadLine());
            if (b != 0){
                division = a/b;
                System.Console.WriteLine($"Division = {division}");
            }
            else{
                System.Console.WriteLine("Division by 0 is not allowed");
            }
            System.Console.WriteLine();
            int[,] array_2 = new int[3,4] {{1,2,3,4},{4,5,6,4},{7,8,9,4}};
            for (int i = 0; i < array_2.GetLength(0); i++)
            {
                int sum = 0;

                for (int j = 0; j < array_2.GetLength(1); j++)
                {
                    System.Console.Write($"{array_2[i,j]} ");
                    sum += array_2[i,j];
                }
                System.Console.WriteLine($"Sum of elements in row {i} = {sum}");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Please enter you date birhday (year mounth day):");
            DateTime birhday = DateTime.Parse(Console.ReadLine());
            DayOfWeek dayofweek = birhday.DayOfWeek;
            System.Console.WriteLine($"You were born on a {dayofweek}");
            System.Console.WriteLine();
            int a1 = 0;
            System.Console.Write("Please enter your password: ");
            string password = Console.ReadLine();
            System.Console.Write("Please enter your password again: ");
            string password1 = Console.ReadLine();
            while (a1 < 5)
            {
                if(password == password1) {
                    System.Console.WriteLine("Welcome!");
                    break;
                }
                else {
                    System.Console.WriteLine("Passwords do not match, please enter again");
                    password1 = Console.ReadLine();
                    a1++;
                }
            }
        }
        static void Practice_day1(){
            int myNumber = 45;
            System.Console.WriteLine($"myNumber = 45");
            System.Console.WriteLine();
            System.Console.WriteLine("Please enter first number:");
            double number = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Please enter second number:");
            double number1 = double.Parse(Console.ReadLine());
            double sum = number + number1;
            double vid = number - number1;
            double dob = number * number1;
            double del = number/number1;
            double ost = number%number1;
            System.Console.WriteLine($"Sum = {sum}\nTaking away = {vid}\nProduct = {dob}\nDivision = {del},\nRemainder = {ost}");
            System.Console.WriteLine();
            int[] array = {2, 1, 4, 3, 5};
            Array.Sort(array);
            for(int i = 0;i < array.Length;i++){
                System.Console.WriteLine(array[i]+" ");
            }
            System.Console.WriteLine();
            string myString = "Hello,C#";
            myString += "I', learning";
            System.Console.WriteLine(myString);
            System.Console.WriteLine();
            System.Console.WriteLine("Please enter your number");
            int parity = int.Parse(Console.ReadLine());
            if (parity%2 == 0)
            {
                System.Console.WriteLine("Your number is even!");
            } 
            else {System.Console.WriteLine("Your number is odd number");}
            System.Console.WriteLine();
            for(int i = 1;i <= 10;i++){
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine();
            var myList = new List<string> {"List","Two List", "Three List","Four List"};
            myList.RemoveAt(1);
            foreach (var el in myList)
            {
                System.Console.WriteLine(el);
            }
            System.Console.WriteLine();
            var dict = new Dictionary<string,string>();
            dict.Add("USA","Washington");
            dict.Add("UA","Kyiv");
            dict.Add("United Kingdom","London");
            dict.Add("Chine","Pekin");
            dict.Add("Jopan","Tokyo");
            string CountryToFind = "Chine";
            if(dict.ContainsKey(CountryToFind)){
                string Capital = dict[CountryToFind];
                System.Console.WriteLine($"Capital {CountryToFind}: {Capital}");
            }
            else {System.Console.WriteLine($"Information of Capital {CountryToFind} don't find");}
        }
    }
}
