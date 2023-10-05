using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    public class Point2D
    {
        private int x;
        private int y;

        public Point2D(int x, int y)
        {
            // x =  x - т.е будет ошибка
            this.x = x; // this что-бы обратиться к полям класса
            this.y = y;
        }
    }
    public class Character
    {
        public double CalcSquare(double ac, double ab, int sin, bool isInRadians = false)
            // опциональный параметр isInRadians - т.е присвоили значение.Всегда в конце
        {
            if (ac < 0 || ab < 0)
            {
                Console.WriteLine("Side of the triangle can't be <0");
                return 0;
            }
            if(isInRadians)
            {
                return 0.5 * ac * ab * Math.Sin(sin);
            }
            else
            {
                double rads = sin * Math.PI / 180;
                return 0.5 * ac * ab * Math.Sin(rads);
            }
        }

        private readonly int speed = 10;

        public int Health { get; set; } = 100;

        public Race Race { get;private set; }

        public int Armor { get; set; } 

        public Character(Race race)
        {
            Race = race;
            
            switch(race)
            {
                case Race.Elf:
                    Armor = 30;
                    break;
                case Race.Ork:
                    Armor = 40;
                    break;
                case Race.Terrain:
                    Armor = 20;
                    break;
                default:
                    throw new ArgumentException("Unknown race.");
            }
            if (Race == Race.Elf)
            {
                Armor = 30;
            } else if (Race == Race.Ork)
            {
                Armor = 40;
            } else if (Race == Race.Terrain)
            {
                Armor = 20;
            }
            else { Console.WriteLine("Unknown race"); }
        }
        public Character(Race rase,int armor)
        {
            Race = rase;
            Armor = armor;
        }
        public void Hit(int damage)
        {
            if (damage > Health)
            {
                damage = Health;
            }
            Health -= damage;
        }
        public int PrintSpeed()
        {
            return speed;
        }
        //public void IncreaseSpeed()
        //{
           // speed += 10;
        //}
    }
}
