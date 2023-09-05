using System;
using System.Text;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void ComparingString(){
        // string str1 = "abcde";
            // string str2 = "abcde";
            // bool areEqual = str1 == str2;
            // System.Console.WriteLine(areEqual);
            // areEqual = string.Equals(str1,str2,StringComparison.Ordinal);
            // System.Console.WriteLine(areEqual);
            // // Ordinal == bool areEqual = str1 == str2; // т.е едентичные сравнения

            string str1 = "Strasse";
            string str2 = "Straße"; // на немецком языке точно такое же слово
            bool areEqual = string.Equals(str1,str2,StringComparison.Ordinal); // сравнивает байтовые репрезинтации
            System.Console.WriteLine(areEqual);
            areEqual = string.Equals(str1,str2,StringComparison.InvariantCulture); // понимает линг.правила и расширения
            // и выводит может ß - расшифровать этот символ и получить значение - будет True
            System.Console.WriteLine(areEqual);
            areEqual = string.Equals(str1,str2,StringComparison.CurrentCulture); // учитывает специфику алфавита (Если есть на ОС)
            System.Console.WriteLine(areEqual);
        }
        static void StringFormat(){
        string name = "John";
            int age = 30;
            string str1 = string.Format("My name is {0} and I'm {1}",name,age);
            // Считайте после текста с запятой начинаются переменные по индексам
            // т.е name 0 index,age = 1 inder. In text {index} 
            // string str2 = "My name is " + name + "and I'm " + age;
            // System.Console.WriteLine(str2);
            string str2 = $"My name is {name} and i'm {age}"; // $ - вместо stringFormat
            // и теперь в стрингхолдер можем вводить переменные {name}
            string str3 = "My name is \nJohn"; // \n - переход на новую строку
            string str4 = "I'm \t30";
            str3 = $"My name is {Environment.NewLine}John"; // тоже самое что и \n но под все ОС
            string str5 = "I'm John and I'm \"good\" programmer";

            // string str6 = "C:\\tm\\test_amp";
            string str6 = @"C:\tm\test_amp";
            System.Console.WriteLine(str1+str2+str3+str4+str5+str6);

            double answer = 42.08;
            // string result = string.Format("{0:d}", answer);
            // string result1 = string.Format("{0:d4}",answer);  т.е наше число дополняется нулями

            string result = string.Format("{0:f}", answer);
            string result1 = string.Format("{0:f1}",answer); // тут будет окургление к большему

            Console.OutputEncoding = Encoding.UTF8;
            double money = 12.8;
            result = string.Format("{0:C}",money);
            result1 = string.Format("{0:C2}",money); // вывод знака денег (которые в системе стоят)
            // result = $"{money:C2}"; - можно и так
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            // изменяем на доллары
            System.Console.WriteLine(result);
            System.Console.WriteLine(money.ToString("C2"));
        }
        static void StringBuilder(){
            StringBuilder sb = new StringBuilder(); // более производительный когда будет больше 7 строк
            sb.Append("My "); // добавление
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John");
            sb.AppendLine("|"); // переводит некст строку на новый рядок
            sb.AppendLine("Hello");
            sb.Append("!");
            System.Console.WriteLine(sb);
        }
        static void StringModification(){
         string nameConcat = string.Concat("My ","name ","is ","John");
            string nameJoin = string.Join(" ","My","Name","is","John"); // in first " " указываем разделитель
            System.Console.WriteLine(nameConcat);
            System.Console.WriteLine(nameJoin);
            nameConcat = "My " + "name " + "is " + "John"; // анологично 1 строке
            nameConcat = nameConcat.Insert(0,"By the way, "); // 0 is index
            System.Console.WriteLine(nameConcat);

            nameConcat = nameConcat.Remove(0,1); // удаление елементов (от и сколько)
            System.Console.WriteLine(nameConcat);

            string replaced = nameConcat.Replace('n','z'); // замена (символа какой меняем,на что меняем)
            System.Console.WriteLine(replaced);

            string data = "12;28;21;22;23";
            string[] splitData = data.Split(';'); // разделение за символом
            string first = splitData[0];
            System.Console.WriteLine(first);

            char[] chars = nameConcat.ToCharArray();
            System.Console.WriteLine(chars[2]);
            System.Console.WriteLine(nameConcat[2]); // т.е не обезательный метод ToCharArray

            string lower = nameConcat.ToLower(); // преобразовано к нижнему регистру
            System.Console.WriteLine(lower);
            string upper = nameConcat.ToUpper(); // к верхнему регистру
            System.Console.WriteLine(upper);

            string John = " My name is John"; // обрезает все пробелы в начале и конце
            System.Console.WriteLine(John.Trim());
        }
        static void StringEptiness(){
            string empty = ""; // = string empty = string.Empty;
            string whiteSpace = " ";
            string notEmpty = " b";
            string NullString = null; // т.е отсутствие екземпляра
            System.Console.WriteLine("IsNullorEmpty");
            bool IsNullorEmpty = string.IsNullOrEmpty(NullString);
            System.Console.WriteLine(IsNullorEmpty);
            IsNullorEmpty = string.IsNullOrEmpty(whiteSpace);
            System.Console.WriteLine(IsNullorEmpty);
            IsNullorEmpty = string.IsNullOrEmpty(notEmpty);
            System.Console.WriteLine(IsNullorEmpty);
            IsNullorEmpty = string.IsNullOrEmpty(empty);
            System.Console.WriteLine(IsNullorEmpty);
            System.Console.WriteLine();
            System.Console.WriteLine("IsNullOrWhiteSpace");
            bool IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(NullString);
            System.Console.WriteLine(IsNullOrWhiteSpace);
            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpace);
            System.Console.WriteLine(IsNullOrWhiteSpace);
            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            System.Console.WriteLine(IsNullOrWhiteSpace);
            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
            System.Console.WriteLine(IsNullOrWhiteSpace);
        }
        static void QueryintStrings(){
            string name = "abracadabra";
            bool ContainsA = name.Contains('a');
            bool ContainsE = name.Contains('E');
            System.Console.WriteLine(ContainsA);
            System.Console.WriteLine(ContainsE);
            bool EndSwitchAbra = name.EndsWith("abra"); // проверка конца
            System.Console.WriteLine(EndSwitchAbra);
            bool StartswitchAbra = name.StartsWith("abra"); // проверка начала
            System.Console.WriteLine(StartswitchAbra);
            int indexof = name.IndexOf('a'); // поиск первого индекса буквы
            // ('a',1) - можно задать значение с какого индекса ищем
            System.Console.WriteLine(indexof);
            int Lastindexof = name.LastIndexOf('a'); // поиск последнего
            System.Console.WriteLine(Lastindexof);
            System.Console.WriteLine(name.Length); // длина строки

            string substrfrom5 = name.Substring(5);
            string substr = name.Substring(0,3);
            System.Console.WriteLine(substrfrom5);
            System.Console.WriteLine(substr);
        }
        static void StaticandInstanceMembers(){
            string name = "AbraCadabra";
            bool ContainsA = name.Contains('a');
            bool ContainsE = name.Contains('e');
            System.Console.WriteLine(ContainsA);
            System.Console.WriteLine(ContainsE);
            string abs = string.Concat("a","b","c");
            // concat вызываем на самом типе
            System.Console.WriteLine(abs);
            System.Console.WriteLine(int.MinValue);
            int x = 1;
            string strx = x.ToString(); // преобразуем инт в стринг
            System.Console.WriteLine(x);
            System.Console.WriteLine(strx);
        }
        static void ComperisonOperation(){
            // Операторы сравнения
            int y = 1;
            int x = 2;
            bool areEqual = x == y;
            System.Console.WriteLine(areEqual);
            bool res = x>y;
            System.Console.WriteLine(res);
            bool res1 = x>=y;
            System.Console.WriteLine(res1);
            bool res2 = x<=y;
            System.Console.WriteLine(res2);
            bool res3 = x!=y;
            System.Console.WriteLine(res3);
        }
        static void MathOperations(){
            int x = 1;
            int y = 2;
            int z = x+y;
            int k = x-y;
            int a = z + k - y;

            int b = z/2; // деление b/=2;
            int b1 = k*2; // умножение b1*=2;
            a = 4%2; // остаток деления
            b = 5%2;}
        static void IncrementDecrementDemo(){
            // прибавляем 1
            int x = 1;
            x = x + 1;
            System.Console.WriteLine(x);
            x++;
            System.Console.WriteLine(x);
            ++x;
            System.Console.WriteLine(x);
            // отнимаем 1
            x = x-1;
            x--;
            --x;
            System.Console.WriteLine($"Last x state is {x}");
            // Разница между постфиксным инкрементом и префиксным инкрементом
            int j = x++;
            System.Console.WriteLine(j);
            System.Console.WriteLine(x);
            j = ++x;
            System.Console.WriteLine(j);
            System.Console.WriteLine(x); // Обьяснение в файле Важно под пунктом 1
            System.Console.WriteLine();
            // Другие операции
            x += 2; // x = x += 2;
            j -= 3; // j = j - 3;
            System.Console.WriteLine(x);
            System.Console.WriteLine(j);}
        static void OverFlow(){
            checked{ // т.е теперь переполнение будет ошибкой.Блок чекд
            uint x = uint.MaxValue;
            System.Console.WriteLine(x);
            x = x+1;
            System.Console.WriteLine(x); // Если мы перевысим макс значение - мы переходим к началу (т.е у нас к 0)
            // если писать без чека
            x = x-1;
            System.Console.WriteLine(x);}
        }
        static void VariablesScope() {
            var a = 1;
            {
                var b = 2;
                {
                    var c = 3;
                    System.Console.WriteLine(a);
                    System.Console.WriteLine(b);
                    System.Console.WriteLine(c);
                }
                System.Console.WriteLine(a);
                System.Console.WriteLine(b);
                // System.Console.WriteLine(c); - в данном контексте отсутствует С            
                }
                System.Console.WriteLine(a);
            // System.Console.WriteLine(b); не имеем доступа к б и с
            // System.Console.WriteLine(c);
        }
        static void Literals(){
            int x = 0b11; // число предст в бинарном виде
            int y = 0b1001;
            int k = 0b10001001;
            int m = 0b000_1001;
            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            System.Console.WriteLine(k);
            System.Console.WriteLine(m);
            System.Console.WriteLine();
            x = 0x1f; // 16-ти мерные литералы
            y = 0xff0D;
            k = 0x1FAB30EF;
            m = 0x1FAB_30EF;
            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            System.Console.WriteLine(k);
            System.Console.WriteLine(m);
            System.Console.WriteLine();

            System.Console.WriteLine(4.5e2); // тоже самое что 4.5 умн на 10 в квадрате
            System.Console.WriteLine(3.1E-1); // 3.1 умн на 10 в -1 степени
            System.Console.WriteLine();
            System.Console.WriteLine('\x78'); // маленькая х (через юникод)
            System.Console.WriteLine('\x5A'); //  Z большое
            System.Console.WriteLine('\u0420'); // Пи
            System.Console.WriteLine('\u0421'); // Си
        }
    }
}
