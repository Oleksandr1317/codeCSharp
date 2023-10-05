﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public interface IShape
    {
        int CalcSuqare();
    }
    public class Rect : IShape
    {
        public int Wight { get; set; }
        public int Height { get; set; }

        public int CalcSuqare()
        {
            return Wight * Height;
        }
    }
    public class Square : IShape
    {
        public int SideLenght {  get; set; }
        public int CalcSuqare()
        {
            return SideLenght * SideLenght;
        }
    }
    //public static class AreaCalculator
    //{
        //public static int CalcSquare(Square square)
       // {
           // return square.Height * square.Height;
       // }
       // public static int CalcSquare(Rect rect)
       // {
         //   return rect.Wight* rect.Height;
       // }
   // }
}
