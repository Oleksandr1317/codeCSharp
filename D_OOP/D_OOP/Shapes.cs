using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public abstract class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape created");
        }
        public abstract void Draw(); // virtual - могут иметь реализацию,а abstract - нет

        public abstract double Area();

        public abstract double Perimetr();
    }
    public class Triangle : Shape
    {
        private readonly double ab;
        private readonly double bc;
        private readonly double ac;

        public Triangle(double ab,double bc,double ac)
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;

            Console.WriteLine("Triangle created");
        }
        public override double Area()
        {
            double s = (ab+bc+ac)/2;
            return Math.Sqrt(s*(s-ab)*(s-bc)*(s-ac));
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing triangle");
        }

        public override double Perimetr()
        {
            return ab + bc + ac;
        }
    }
    public class Rectangle : Shape
    {
        private readonly double wight;
        private readonly double height;

        public Rectangle(double weight,double hight)
        {
            this.wight = weight;
            this.height = hight;

            Console.WriteLine("Rectangle created");
        }
        public override double Area()
        {
            return height*wight;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override double Perimetr()
        {
            return 2*(wight+height);
        }
    }
}
