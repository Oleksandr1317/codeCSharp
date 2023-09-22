using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP
{
    class Rim
    {
        private static Dictionary<char, int> slov = new Dictionary<char, int>()
       {
           {'I',1},
           {'V',5},
           {'X',10},
           {'L',50},
           {'C',100},
           {'D',500},
           {'M',1000},
       };
        public static int Result(string number)
        {
            int result = 0;
            for(int i = 0;i < number.Length;i++)
            {
                if (i+1< number.Length && isSubtractive(number[i], number[i+1]))
                {
                    result -= slov[number[i]];
                }
                else
                {
                    result += slov[number[i]];
                }
            }
            return result;
        }

        private static bool isSubtractive(char c1, char c2)
        {
            return slov[c1] < slov[c2];
        }
    }
}
