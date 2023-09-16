using System;
using System.Collections.Generic;

namespace ArrayCollection{
    class Program{
        static void Main(string[] args)
        {
            Array myArray = Array.CreateInstance(typeof(int),new[] { 4 }, new[] { 1 });
            // { 4 } - раземерность массива , { 1 } - с какого елемента отсчёт
            myArray.SetValue(2019, 1);
            myArray.SetValue(2019, 2);
            myArray.SetValue(2019, 3);
            myArray.SetValue(2019, 4);

            System.Console.WriteLine($"Starling index: {myArray.GetLowerBound(0)}");
            System.Console.WriteLine($"Ending index: {myArray.GetUpperBound(0)}");

            for(int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0);i++){
                System.Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
            }
                for(int i = 1;i <= 5;i++) {
                    System.Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
                }
            
        }
        static void Jagged_Array(){
            int [][] jeggedArray = new int[4][]; // создали массив из 4 столбцов
            jeggedArray[0] = new int[1]; // в нулевой строке будет 1 елемент
            jeggedArray[1] = new int[3]; // во 2 строке 3 елемента
            jeggedArray[2] = new int[2];
            jeggedArray[3] = new int[4];

            System.Console.WriteLine("Enter the numbers for a jegged array.");
            for(int i = 0; i < jeggedArray.Length;i++){
                for (int j = 0; j < jeggedArray[i].Length; j++)
                {
                    string st = Console.ReadLine();
                    jeggedArray[i][j] = int.Parse(st);
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Printing the elements");
            for(int i = 0; i < jeggedArray.Length;i++){
                for (int j = 0; j < jeggedArray[i].Length; j++)
                {
                    System.Console.Write(jeggedArray[i][j] + " ");
                    
                }
                System.Console.WriteLine();
            } 
        }
        static void multidimencional_arrays(){
            // 1,2,3,4 - одномерный массив

            // 1 2 3
            // 2 3 4
            // 3 4 5 - двумерный массив (строчки и столбцы)

            int[,] array_1 = new int[2,3] { {1,2,3},{4,5,6} };
            int[,] array_2 = { {1,2,3},{4,5,6} };
            // [,] - указываем что он двумерный,[2,3] - 2 строчки,3 - столбца
            for(int i = 0;i < array_2.GetLength(0);i++){
                for(int j = 0;j < array_2.GetLength(1);j++){
                    System.Console.Write($"{array_2[i,j]} ");
                }
            System.Console.WriteLine();
            }
        }
        static void Stack_Queue(){
            var queue = new Queue<int>(); // create queue
            queue.Enqueue(1); // aded element
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            System.Console.WriteLine($"First element queue: {queue.Peek()}"); // out element
            queue.Dequeue(); // next out be two (skip first element)
            System.Console.WriteLine($"Second element queue {queue.Peek()}");
            foreach (var item in queue)
            {
                System.Console.WriteLine(item);
            }
            Console.ReadLine();
            var stack = new Stack<int>(); // created stack
            stack.Push(1); // aded element
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            System.Console.WriteLine($"Stack print out 4 : {stack.Peek()}"); // out last element
            stack.Pop();
            System.Console.WriteLine($"Stack print out 3 : {stack.Peek()}");
            System.Console.WriteLine($"Iterate over the stack.");
            foreach(var el in stack){
                System.Console.WriteLine(el);
            }
        }
        static void Dictionary(){
            var people = new Dictionary<int, string>(); // < тип ключа/тип значения>
            people.Add(1,"John");
            people.Add(2,"Ken");
            people.Add(3,"Elice"); // т.е добавляем значение

            people = new Dictionary<int, string>()
            {
                {1,"John"},
                {2, "Ken"},
                {3, "Elice"}
            }; // НЕЛЬЗЯ ДОБАВИТЬ 2 ОДИНКОВЫХ КЛЮЧА В 1 СЛОВАРЕ
            string name = people[1];
            System.Console.WriteLine(name);
            System.Console.WriteLine("Iterating over keys: ");
            var keys = people.Keys;
            foreach (var item in keys)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("Iterating over values");
            var values = people.Values;
            foreach (var item in values)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("Iterating over key-value pairs");
            foreach (var pair in people)
            {
                System.Console.WriteLine($"Key: {pair.Key}. Value: {pair.Value}");
            }
            System.Console.WriteLine(people.Count); // количесто елементов дикт

            bool ContainsKey = people.ContainsKey(2); // поиск ключа
            bool ContainsValue = people.ContainsValue("John"); // поиск значения
            System.Console.WriteLine($"Contains key: {ContainsKey}. Contains value: {ContainsValue}");

            people.Remove(1); // Удаление по ключу

            if(people.TryAdd(2, "Elice")){ // т.е если у нас получится добавить знач по кл 2 = тру
                System.Console.WriteLine("Added succesfully");}
                else {
                    System.Console.WriteLine("Fail to add using key 2");
                }
            if(people.TryGetValue(2,out string val)) // т.е вытаскиваем значение по ключу
            {
                System.Console.WriteLine($"Key 2 = {val}");
            }
            else {
                System.Console.WriteLine("Fail get");
            }
            people.Clear(); // очищение словаря
        }
        static void List_class(){
            var intList = new List<int> {1, 2, 3, 4, 5, 6, 7}; // <тип листа>
            intList.Add(7); // добавит число 7 в конец

            int[] intArray = {1,2,3};
            intList.AddRange(intArray); // добавляем массив внутрь списка
            if(intList.Remove(1)){ // удаляет первого найденого ел. по значению (т.е первую единицу которую встретит)
             // do
            } else { }
            intList.RemoveAt(0); // сразу удаление за индексом
            intList.Reverse(); // переворот
            bool cont = intList.Contains(3); // поиск елемента
            int min = intList.Min(); // min element
            int max = intList.Max(); // max element

            int indexOf = intList.IndexOf(2); // найти индекс первой двойки
            int lastindexof = intList.LastIndexOf(2); // индекс последней двойки
            System.Console.WriteLine($"Indexof2 = {indexOf}.Last index of 2 = {lastindexof}");

            for (int i = 0; i < intList.Count; i++) // Count (for list) = Lenght (for array/variable)
            {
                System.Console.WriteLine(intList[2]);
            }
            System.Console.WriteLine();
            foreach (int i in intList)
            {
                System.Console.WriteLine(i);
            }
        }
        static void Types_Array(){
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            int index = Array.BinarySearch(numbers, 7); // только упорядоченые массив,ищет чисто
            // Он разделяет масив пополам и сравнивает число с искаемым,и так далее пока не дойдёт до искаемого
            // т.е разделил на пополам получил 4,4 меньше 7.Поэтому работает только с частью справа от 4
            // дальше делит на пополам часть справа и получает 7 и выдаёт нам индекс 7 (т.е индекс = 6)
            System.Console.WriteLine(index);

            int[] copy = new int[10];
            Array.Copy(numbers,copy,numbers.Length); // (от куда,куда,сколько елементов) 0 будет вконце - по умолчанию

            int[] anothercopy = new int[10];
            copy.CopyTo(anothercopy,0); // массив.CopyTo(куда копируем,начальный индекс)

            Array.Reverse(copy); // метод реверс - переворачивает массив (не зависит от порядка чисел,сохраняет порядок)
            foreach (var c in copy)
            {
                System.Console.WriteLine(c);
            }
            Array.Sort(copy); // метод сорт - выводит в возрастающем порядке елементы
            foreach (var c in copy)
            {
                System.Console.WriteLine(c);
            }
            Array.Clear(copy,0,copy.Length); // очищаем масив (какой масив,с какого елемента,по какой)

            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] {1, 3, -2, 5, 10};

            int[] a4 = {1, 2, 3, 4, 5}; // 4 - способа создать массивы

            Array myArray = new int[5]; // полная запись создание массива
            // Верхняя и нижняя строка полностью еквивалентны (только разная запись)
            Array myArray2 = Array.CreateInstance(typeof(int),5); // Самая полная запись
            myArray2.SetValue(12,0); // SetValue - устанавливаем значение 12,0-му елементу

            System.Console.WriteLine(myArray2.GetValue(0)); // GetValue - получаем значение (из за типа Array,нет array[0])
        }
    }
}