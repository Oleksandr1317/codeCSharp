using System;

namespace B_ControlFlow{
    class Program{
        static void Main(string[] args)
        {
            
        }
        static void Continue_Break(){
            int[] numbers3 = {0, 3, 2, 1, 5, 4, 6, 7, 8, 9};
            foreach(int n in numbers3)
            {
                // if (n%2==0)
                // System.Console.WriteLine(n); // первый способ вывода чётных чисел
                if (n%2 != 0)
                continue; // если нужно перейти к следующей итерации (т.е продолжать это уже не нужно)

                System.Console.WriteLine(n);
            }

            Console.ReadLine();
            int[] numbers1 = {0, 3, 2, 1, 5, 4, 6, 7, 8, 9};
            char[] latters = {'a','b','c','d','e','f','g','h','i','j'};
            for(int i = 0;i<numbers1.Length;i++)
            {
                System.Console.WriteLine($"Number={numbers1[i]}");

                for (int j = 0; j < latters.Length; j++)
                {
                    if (numbers1[i]==j)
                       break;
                    Console.Write($" {latters[j]} ");
                }
                System.Console.WriteLine();
            }
            

            Console.ReadLine();
            int[] numbers = {1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7};
            int counter = 0;
            for(int i = 0;i < numbers.Length - 1;i++)
            {   if(counter == 3)
                    break; // выход с внешнего цикла т.е прерываем его досрочно
                for (int j = i+1; j < numbers.Length; j++) 
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI+atJ==0)
                    {
                        System.Console.WriteLine($"Pair ({atI};{atJ}).Indexes : ({i};{j})");
                        counter++;
                    }
                    if(counter == 3)
                       break; // это выход с внутренего цикла
                }
            }
        }
        static void while_do_while(){
            // white и do while
            int age = 30;
            while(age<18) // будет спрашивать до тех пор пока не будет 18
            {
                System.Console.WriteLine("First while loop");
                System.Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }

            do // т.е в любом случае будет исполнено,даже если изначально age > 18
            {
                System.Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
            }
            while(age<18);

            int[] numbers = {1, 2, 3, 4, 5};
            int i = 0;
            while(i<numbers.Length)
            {
                System.Console.WriteLine(numbers[i] + " ");
                i++;
            }
            System.Console.WriteLine("Good");
        }
        static void nestedFor(){
         // Вложеные циклы
            int[] numbers = {1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7};
            for(int i = 0;i < numbers.Length - 1;i++)
            {
                for (int j = i+1; j < numbers.Length; j++) // т.е j становится -2 и начинает сравнивать теперь с 1 индекса
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI+atJ==0)
                    {
                        System.Console.WriteLine($"Pair ({atI};{atJ}).Indexes : ({i};{j})");
                    }
                }
            }
            System.Console.WriteLine();
            for(int i = 0;i < numbers.Length - 2;i++)
            {
                for (int j = i+1; j < numbers.Length - 1; j++) 
                {
                    for (int k = j + 1;k<numbers.Length;k++) // т.е тут ищем 3 числа которые в сумме дают 0
                    {
                    int atI = numbers[i];
                    int atJ = numbers[j];
                    int atk = numbers[k];

                    if (atI + atJ + atk ==0)
                    {
                        System.Console.WriteLine($"Triplets ({atI};{atJ};{atk}).Indexes : ({i};{j};{k})");
                    }
                    }
                }
            }
        }
        static void for_foreach(){
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for(int i = 0; i < numbers.Length; i++)
            // т.е i = 0 старт. 
            // i < numbers.Lenght - до какого момента будет выполянться масив
            // i++ - шаг т.е на сколько от начального елемента увеличиваем/уменьшаем к конечному
            {
                Console.Write(numbers[i] + " ");
            } 
            for(int i = numbers.Length - 1; i >= 0; i--)
            {
                System.Console.Write(numbers[i] + " ");
            }
            System.Console.WriteLine();
            for(int j = 0;j<numbers.Length;j++){
                if (numbers[j] % 2 == 0) {
                System.Console.Write(numbers[j] + " ");
                }
            }

            // foreach - если просто хотим вывести масив !!! ДОСТУП К ИНДЕКСУ НЕ ИМЕЕМ,ТОЛЬКО ЗНАЧЕНИЕ
            foreach(int val in numbers)
            {
                System.Console.Write(val + " ");
            }
        }
        static void if_else(){
           System.Console.WriteLine("Enter your idx:");
            double a = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            
            bool isToolLow = a <= 18.5;
            bool isNormal = a > 18.5 && a < 25; // && - логическое "и"
            bool isAboveNormal = a >= 25 && a <= 30;
            bool isToolFat = a > 30;

            bool isFat = isAboveNormal || isToolFat; // || - логическое "или"

            if(isFat)
            {
              System.Console.WriteLine("You'd better lose some weight");
            }  // если 1 строка то можно скобки не ставить
            else 
            { // выполнится тогда - когда isFat = false
                System.Console.WriteLine("Oh,you are in a good shape.");
            }
            // if(isFat == False)
            if(!isFat)
            {
                System.Console.WriteLine("You're definitely not fat");
            }
            if(isToolLow)
            {
                System.Console.WriteLine("You'are not enough weight.");
            }
            else if (isNormal) // Дополнительные условия (между иф и елесе)
            {
                System.Console.WriteLine("You'are okey");
            }
            else if (isAboveNormal)
            {
                System.Console.WriteLine("Be careful");
            }
            else 
            {
                System.Console.WriteLine("You need to lose some weight.");
            }

            if (isFat || isToolFat) 
            {
                System.Console.WriteLine("Anyway it's time to get on diet");
            }

            // Тернарный оператор
            string description = age > 18 ? "You can drink alcohol" : "You should get a bit older";
            // если возраст больше 18 то присвоится эта строчка "You can drink alcohol"
            // в противном случае "You should get a bit older"
        }
    }
}
