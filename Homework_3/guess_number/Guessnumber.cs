using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace guess_number
{
    public class Guessnumber
    {
        public enum GuessingPlayer
        {
            Human,
            Machine
        }
        private readonly int max;
        private readonly int m_try;
        private readonly GuessingPlayer guessingPlayer;

        public Guessnumber(int max = 100,int m_try = 5, GuessingPlayer guessingPlayer = GuessingPlayer.Human) 
        {
            this.max = max;
            this.m_try = m_try;
            this.guessingPlayer = guessingPlayer; 
        }
        public void Start()
        {
            if(guessingPlayer == GuessingPlayer.Human)
            {
                HumanGuesses();
            }
            else
            {
                MachineGuesses();
            }
        }

        private void MachineGuesses()
        {
            Random rand = new Random();
            int guessedNumber = rand.Next(0,max);

            int lastGuess = -1;
            int tries = 0;
            while(lastGuess != guessedNumber && tries < m_try) 
            {
                Console.WriteLine("Guess the number!");
                lastGuess = int.Parse(Console.ReadLine());

                if(lastGuess == guessedNumber)
                {
                    Console.WriteLine("Congrats! You guessed the number!");
                    break;
                }else if (lastGuess < guessedNumber)
                {
                    Console.WriteLine("My number is greater!");
                }else
                {
                    Console.WriteLine("My number is less!");
                }
                tries++;

                if (tries == m_try)
                {
                    Console.WriteLine("You lost!");
                }
            }
        }

        private void HumanGuesses()
        {
            Console.WriteLine("Enter a number that going to be guessed by a computer.");
            int guessedNumber = -1;
            while(guessedNumber == -1)
            {
                int parsedNumber = int.Parse(Console.ReadLine());
                if (parsedNumber >= 0 && parsedNumber <= this.max)
                {
                    guessedNumber = parsedNumber;
                }
            }

            int lastGuess = -1;
            int min = 0;
            int max = this.max;
            int tries = 0;
            while (lastGuess != guessedNumber && tries < m_try)
            {
                lastGuess = (max + min) / 2;
                Console.WriteLine($"Did you guessed this number : {lastGuess}?");
                Console.WriteLine("If yes, enter 'y',if your number if greater enter 'g',if less 'l'");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("Supper! I guess your number!");
                }else if (answer == "g") 
                {
                    min = lastGuess;
                }else
                {
                    max = lastGuess;
                }
                if (lastGuess == guessedNumber)
                {
                    Console.WriteLine("Don't cheat! man!");
                }
                tries++;
                if(tries == m_try)
                {
                    Console.WriteLine("No tries anymore :( i lost");
                }
            }
        }
    }
}
