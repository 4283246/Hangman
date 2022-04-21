using System;
using System.Collections.Generic;
using HangmanRenderer.Renderer;

namespace Hangman.Core.Game
{
    public class HangmanGame
    {
        private GallowsRenderer _renderer;

        List<string> _wordDictionary = new List<string> { "bottle", "code", "speed", "snapchat", "radio", "random", "rands", "hands", "robot", "drive", "truck", "dance", "string", "license", "game", "phone", "time", "spoon", "cake", "drunk" };

        private string _randomWord;
        private string _guess;
        private int _numberOflives = 6;

        public HangmanGame()
        {
            _renderer = new GallowsRenderer();

            Random random = new Random();
            
           int index = random.Next(_wordDictionary.Count);
           _randomWord = _wordDictionary[index];

            for(int i=0; i < _randomWord.Length; i++)
            {
                _guess = _guess + "_";
            }

        //   _guess = guess;

      }

      public void Run()
      {

       //   _renderer.Render(10, 5, 0);

          Console.SetCursorPosition(0, 13);
          Console.ForegroundColor = ConsoleColor.Blue;
          
            

            while(_numberOflives > 0 && _numberOflives <=6)
            {
                _renderer.Render(10, 5, _numberOflives);

                Console.SetCursorPosition(0, 15);

                Console.Write("Your current guess: ");
                Console.WriteLine(_guess);


                Console.Write("What is your next guess: ");
                var nextGuess = Console.ReadLine();

                char[] guessArray = _guess.ToCharArray();

                bool correct = false;


                for(int i=0; i < _randomWord.Length; i++)
                { 
                    if (_randomWord[i] == nextGuess[0])
                    {
                        guessArray[i] = _randomWord[i];
                        correct = true;
                        //we know its correct
                    }

                    //it was not correct
                }

                _guess = new string(guessArray);


                if (!correct)
                    _numberOflives--;
            
            }



            /*
            foreach (string word in _wordDictionary)
            {
                if (_guess == word)
                {
                    _wordDictionary = false; 
                    _guess = word;
                    Console .Write(word);
                }
                else
                {
                    if (word == _guess) 
                    {
                        Console.Write("Please enter next guess:");
                    }
                    if (word3 == _guess)
                    
                }
                       
            }

            Console.ForegroundColor = ConsoleColor.Green;

          Console.Write("What is your next guess: ");
          var nextGuess = Console.ReadLine();
            */
            // Game.


        }

        /*        private static int HangmanGame(int wrong)
              {

                  if (wrong == 0)
                  {

                      Console.WriteLine("\n+---+");7
                      Console.WriteLine("    |");
                      Console.WriteLine("    |");
                      Console.WriteLine("    |");
                      Console.WriteLine("    ===");

                  }
                  else if (wrong == 1)
                  {
                      Console.WriteLine("\n+---+");
                      Console.WriteLine("    |");
                      Console.WriteLine("    |");
                      Console.WriteLine("    |");
                      Console.WriteLine("    ===");

                  }

                  else if (wrong == 2)
                  {
                      Console.WriteLine("\n+---+");
                      Console.WriteLine("    |");
                      Console.WriteLine("    |");
                      Console.WriteLine("    |");
                      Console.WriteLine("    ===");

                  }
                  else if (wrong == 3)
                  {
                      Console.WriteLine("\n+---+");
                      Console.WriteLine("    |");
                      Console.WriteLine("    |");
                      Console.WriteLine("    |");
                      Console.WriteLine("    ===");
                  }
                  else if (wrong == 4)
                  {
                      Console.WriteLine("\n+---+");
                      Console.WriteLine("    |");
                      Console.WriteLine("    |");
                      Console.WriteLine("    |");
                      Console.WriteLine("    ===");
                  }
                  else if (wrong == 5)
                  {
                      Console.WriteLine("\n+---+");
                      Console.WriteLine("    |");
                      Console.WriteLine("    |");
                      Console.WriteLine("    |");
                      Console.WriteLine("    ===");
                  }
                  else if (wrong == 6)
                  {
                      Console.WriteLine("\n+---+");
                      Console.WriteLine("    |");
                      Console.WriteLine("    |");
                      Console.WriteLine("    |");
                      Console.WriteLine("    ===");
                  }



              }

              private static int printWord(List<char> guessedLetters, string randomworld)
              {
                  int count = 0;
                  int rightLetters = 0;
                  Console.WriteLine("\r\n");
                  foreach (char c in randomworld)
                  {
                      if (guessedLetters.Contains(c))
                      {
                          Console.Write(c + " ");
                          rightLetters++;
                      }
                      else
                      {
                          Console.Write(" ");

                      }
                      count++;
                  }
                  return rightLetters;
              }

              private static void printLines(string randomWord)
              {
                  Console.Write("\r");
                  foreach (char c in randomWord)
                  {
                      Console.OutputEncoding = System.Text.Encoding.Unicode;
                      Console.Write("\u0305");
                  }

              }
        */

    }
    }
