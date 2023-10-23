using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_delegats1
{
    public enum Player
    {
        Human,
        Computer
    }
    public enum GameStatus
    {
        NotStarted,
        InProgress,
        GameIsOver
    }
    public class Game
    {
        private readonly Random randomizer;

        public int InitialStickNumber { get; }

        public Player Turn { get;private set; } 

        public int RemainingSticks { get; private set; }

        public GameStatus GameStatus { get; private set; }

        public event Action<int> MachinePlayed;
        public event EventHandler<int> HumanTurnToMakeMove;

        public event Action<Player> EndOfGame;

        public Game(int initialStickNumber, Player whoMakesFirstMove)
        {
            if (initialStickNumber < 7 || initialStickNumber > 30)
                throw new ArgumentException("Initial number of sticks should be >= 7 and <=30");
            randomizer = new Random();
            InitialStickNumber = initialStickNumber;
            GameStatus = GameStatus.NotStarted;
            RemainingSticks = InitialStickNumber;
            Turn = whoMakesFirstMove;
        }
        public void HumanTakes(int sticks)
        {
            if(sticks<1||sticks > 3)
            {
                throw new ArgumentException("You can take from 1 to 3 sticks in a single move");
            }
            if (sticks > RemainingSticks)
            {
                throw new ArgumentException($"You can't take more than remaining.Remains:{RemainingSticks}");
            }
            TakeSticks(sticks);
        }

        public void Start()
        {
            if (GameStatus == GameStatus.GameIsOver)
                RemainingSticks = InitialStickNumber;

            if (GameStatus == GameStatus.InProgress)
                throw new InvalidOperationException("Can't call start when game is alredy in progress.");

            GameStatus = GameStatus.InProgress;
            while(GameStatus == GameStatus.InProgress)
            {
                if(Turn == Player.Computer)
                {
                    CompMakesMove();
                } 
                else
                {
                    HumanMakesMove();
                }

                FireEndOfGameIfRequired();

                Turn = Turn == Player.Computer ? Player.Human : Player.Computer;
            }
        }

        private void FireEndOfGameIfRequired()
        {
            if (RemainingSticks == 0)
            {
                GameStatus = GameStatus.GameIsOver;
                if(EndOfGame != null)
                    EndOfGame(Turn == Player.Computer ? Player.Human : Player.Computer);
            }
        }

        private void HumanMakesMove()
        {
            if (HumanTurnToMakeMove != null)
                HumanTurnToMakeMove(this, RemainingSticks);
        }

        private void CompMakesMove()
        {
            int maxNumber = RemainingSticks >= 3 ? 3 : RemainingSticks;
            int sticks = randomizer.Next(1,maxNumber);

            TakeSticks(sticks);
            if(MachinePlayed != null)
                MachinePlayed(sticks);
        }

        private void TakeSticks(int sticks)
        {
            RemainingSticks -= sticks;
        }
    }
}
