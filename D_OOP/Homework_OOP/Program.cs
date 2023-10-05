using Microsoft.VisualBasic;
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
            MyStack<int> ms = new MyStack<int>(); 

            ms.Push(1);
            ms.Push(2);
            ms.Push(3); 

            foreach (var item in ms) // теперь мы можем проходиться форичем
            {
                Console.WriteLine(item);
            }
            Console.ReadLine(); 

            while(ms.Count != 0) 
            {
                Console.WriteLine((int)ms.Peek());
                ms.Pop();
            }

            Console.WriteLine(ms.Peek());
            ms.Pop();
            Console.WriteLine(ms.Peek());
            ms.Push(3);
            ms.Push(4);
            ms.Push(5);
            Console.WriteLine(ms.Peek());
        }
        public void ProblemofRepresentetives()
        {
            IShape rect = new Rect() { Height = 2, Wight = 5 };
            IShape square = new Square { SideLenght = 10 }; // теперь мы не можем указать разные длинны
            Console.WriteLine($"Rect area = {rect.CalcSuqare()}");
            Console.WriteLine($"Square area = {square.CalcSuqare()}");

            //Rect rect = new Rect { Height = 2, Wight = 5 }; // значит что мы вызвали конструктор по умолчанию
            //int rectArea = AreaCalculator.CalcSquare(rect);
            // Console.WriteLine($"Rect area = {rectArea}");
            // Rect square = new Square { Height = 2, Wight = 10 }; // бред ибо мы создали 2 Height - но кампилятор не ругается
            // AreaCalculator.CalcSquare(square);
        }
        static void InterFaceandExtencion()
        {
            List<object> list = new List<object>() { 1, 2, 3 }; // создаём лист обьектов

            IBaseCollectrion collectrion = new BaseList(4);
            collectrion.AddRange(list);
            collectrion.Add(1);


            Shape[] shapes = new Shape[2];
            shapes[0] = new Triangle(10, 20, 30);
            shapes[1] = new Rectangle(5, 10);
            foreach (Shape shape in shapes)
            {
                shape.Draw();
                Console.WriteLine(shape.Perimetr());
            }
            Console.ReadLine();
        }
        static void Do(object obj)
        {
            bool isPointRef = obj is PointRef;  // is для проверки
            if (isPointRef)
            {
                PointRef pr = (PointRef)obj;
                Console.WriteLine(pr.x);
            }else
            {
                // do smth
            }

            // 2 способ
            PointRef pr1 = obj as PointRef;
            if(pr1 != null)
            {
                Console.WriteLine(pr1.x);
            }
            else
            {
                // if pr1 = null
            }
        }
        static void Boxing_and_Unboxing()
        {
            int x = 1;
            object obj = x; // boxing

            int y = (int)obj; // unboxing

            double pi = 3.14;
            object obj1 = pi;

            int number = (int)obj1; // будет исключение(не стоит разбрасываться типами)
            Console.WriteLine(number);
        }
        static void NRE_NullableValTypesDemo()
        {
            PointVal? pv = null; // что-бы поставить null значение в структуре ставим ?
            if (pv.HasValue)
            {
                PointVal pv2 = pv.Value;
                Console.WriteLine(pv2.x);
            }
            else
            {
                // если в pv будет null
            }
            PointVal pv3 = pv.GetValueOrDefault();

            PointRef c = null; // тоже самое что PointRef c = null;  в классе без проблем присваеваем null значение
            // new PointRef(); - выделили бы кусок памяти,а в этом случае не выделяем
            Console.WriteLine(c.x); // NullReferenceException
        }
        static void PassByRefDemo()
        {
            int a = 1; int b = 2;
            Swap(ref a, ref b); // вызывае функцию замены
            Console.WriteLine($"a = {a}. b  = {b}");

            Console.ReadLine();
            List<int> list = new List<int>();
            AddNumbers(list);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
        static void Swap(ref int a,ref int b)
        {
            Console.WriteLine($"Original a = {a}. Original b  = {b}");
            int tmp = a;
            a = b;
            b = tmp; // меняем местами а и б
            Console.WriteLine($"Swapped a = {a}. Swapped b  = {b}");
        }
        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }
        static void ValRefDemo()
        {
            EvilStruct es1 = new EvilStruct();
            es1.PointRef = new PointRef() { x = 1, y = 2 };
            //es1.PointRef.x = 1;
            //es1.PointRef.y = 2;
            EvilStruct es2 = es1;
            Console.WriteLine($"Es1 pointref x = {es1.PointRef.x}. Es1 point ref y = {es1.PointRef.y}");
            Console.WriteLine($"Es2 pointref x = {es2.PointRef.x}. Es2 point ref y = {es2.PointRef.y}");

            es2.PointRef.x = 42;
            es2.PointRef.y = 45;

            Console.WriteLine($"Es1 pointref x = {es1.PointRef.x}. Es1 point ref y = {es1.PointRef.y}");
            Console.WriteLine($"Es2 pointref x = {es2.PointRef.x}. Es2 point ref y = {es2.PointRef.y}");

            Console.ReadLine();
            PointVal a;
            a.x = 3;
            a.y = 5;

            PointVal b = a;
            b.x = 7;
            b.y = 10;

            a.LogValues();
            b.LogValues();

            Console.WriteLine("//////////");
            PointRef c = new PointRef();
            c.x = 3;
            c.y = 5;

            PointRef d = c;
            d.x = 7;
            d.y = 10;

            a.LogValues();
            b.LogValues();
        }
    }
}