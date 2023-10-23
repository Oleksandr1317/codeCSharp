using System;

namespace Homework_delegats1
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(10, Player.Human);
            game.MachinePlayed += Game_MachinePlayed;
            game.HumanTurnToMakeMove += Game_HumanTurnToMakeMove;
            game.EndOfGame += Game_EndOfGame;

            game.Start();


        }

        private static void Game_EndOfGame(Player player)
        {
            Console.WriteLine($"Winner;{player}");
        }

        private static void Game_HumanTurnToMakeMove(object sender, int remainingSticks)
        {
            Console.WriteLine($"Remaining sticks:{remainingSticks}");
            Console.WriteLine($"Take some sticks");

            bool takenCorrectly = false;
            while(!takenCorrectly)
            {
                if(int.TryParse( Console.ReadLine(), out int takenStiks) )
                {
                    var game = (Game)sender;

                    try
                    {
                        game.HumanTakes(takenStiks);
                        takenCorrectly = true;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private static void Game_MachinePlayed(int stickstaken)
        {
            Console.WriteLine($"Machine took:{stickstaken}");
        }
    }
}