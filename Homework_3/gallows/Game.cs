using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gallows
{
    public class Game
    {
        private string randomWord;
        private string hiddenWord;
        private int count;
        private HashSet<char> guessedLatters = new HashSet<char>();
        bool isGameWin;
        bool isGameLose;

        public void StartGame()
        {
            string FilePath = "WordsStockRus.txt";
            List<string> words = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        words.Add(line);
                    }
                }
                if (words.Count > 0)
                {
                    Random random = new Random();
                    int indexrandom = random.Next(0,words.Count);
                    randomWord = words[indexrandom];
                    hiddenWord = new string('*', randomWord.Length);
                    count = 6;
                    isGameWin = false;
                    isGameLose = false;
                    Console.WriteLine($"Word : {hiddenWord}");
                }
            } catch (Exception ex)
            {
                Console.WriteLine("File reading error: " + ex.Message);
            }
        }
        public void GuessLatter()
        {
            while(count > 0 && !isGameWin && !isGameLose)
            {
                Console.Write("Enter your latter: ");
                char letter = char.Parse(Console.ReadLine().ToLower());
                if (guessedLatters.Contains(letter))
                {
                    Console.WriteLine($"You have already entered a letter : '{letter}'");
                    continue;
                }

                guessedLatters.Add(letter);

                if (randomWord.Contains(letter))
                {
                    StringBuilder newhide = new StringBuilder(hiddenWord);
                    for (int i = 0;i < randomWord.Length; i++)
                    {
                        if (Char.ToLower(randomWord[i]) == letter)
                        {
                            newhide[i] = letter;
                        }

                    }
                    hiddenWord = newhide.ToString();
                    Console.WriteLine($"Current word : {hiddenWord}");
                }
                else
                {
                    count--;
                }

                if(hiddenWord == randomWord)
                {
                    Console.WriteLine($"Congrats! You win.Word was {randomWord}");
                    isGameWin = true;
                }
                else if (count == 0) { Console.WriteLine($"You lost!.Word was {randomWord}"); isGameLose = true; }
            }
        }
    }
}
