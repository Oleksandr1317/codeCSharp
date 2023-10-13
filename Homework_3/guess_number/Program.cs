using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static guess_number.Guessnumber;

namespace guess_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Guessnumber(guessingPlayer: GuessingPlayer.Machine);
            game.Start();

            Console.ReadLine();
        }
    }
}