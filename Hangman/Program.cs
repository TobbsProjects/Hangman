using System.Runtime.CompilerServices;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        bool running = true;
        while (running)
        {
            // The menu where the user makes their choice.
            Console.Clear();
            Console.WriteLine("Welcome to the classic game Hangman!");
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Start a singleplayer game.");
            Console.WriteLine("2. Start a local multiplayer game.");
            Console.WriteLine("3. Rules.");
            Console.WriteLine("4. Exit.");
            Console.WriteLine();


            string? choice = Console.ReadLine();

            if(choice == "4")
            {
                running = false;
            }

            else if(choice == "3")
            {
                Console.Clear();
                Console.WriteLine("The rules of hangman is easy. All you got to do is guess the correct letters of a word and survive. To many wrong guesses and you're out.");
                Console.WriteLine("Hit enter to continue.");
                Console.ReadLine();
            }

            else if (choice == "2")
            {
                Console.Clear();
                Console.Write("Write a word you want your friend to guess: ");
                string secretWord = Console.ReadLine().ToUpper();
                Console.Clear();
                string guessWord = "";
                int wrong = 0;

                foreach (char c in secretWord)
                {
                    guessWord += "_";
                };


                while (!secretWord.Equals(guessWord) && wrong <= 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    // Switchstatement to show the stickfigure
                    switch (wrong)
                    {
                        case 0:
                            Console.WriteLine("_______");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            break;
                        case 1:
                            Console.WriteLine("_______");
                            Console.WriteLine("|   |");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            break;
                        case 2:
                            Console.WriteLine("_______");
                            Console.WriteLine("|   |");
                            Console.WriteLine("| (x.x) ");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            break;
                        case 3:
                            Console.WriteLine("_______");
                            Console.WriteLine("|   |");
                            Console.WriteLine("| (x.x) ");
                            Console.WriteLine("|  \\|/");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            break;
                        case 4:
                            Console.WriteLine("_______");
                            Console.WriteLine("|   |");
                            Console.WriteLine("| (x.x) ");
                            Console.WriteLine("|  \\|/");
                            Console.WriteLine("|   | ");
                            Console.WriteLine("|");
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            break;
                        case 5:
                            Console.WriteLine("_______");
                            Console.WriteLine("|   |");
                            Console.WriteLine("| (x.x) ");
                            Console.WriteLine("|  \\|/");
                            Console.WriteLine("|   | ");
                            Console.WriteLine("|  / \\");
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("");
                            Console.WriteLine("THIS IS YOUR LAST CHANCE TO SAVE THE STICKFIGURE!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        default:
                            Console.WriteLine("You dead!");
                            Thread.Sleep(2000);
                            wrong++;
                            break;
                    }

                    Console.WriteLine("Word to guess: " + guessWord);
                    Console.Write("Make your guess of a letter: ");
                    string? guess = Console.ReadLine().ToUpper();

                    if (guess == null || guess.Equals(""))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Random rnd = new();
                        int emptyGuess = rnd.Next(0, 5);

                        switch (emptyGuess)
                        {
                            case 0:
                                Console.WriteLine("I would hope you do know the alphabet.");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            case 1:
                                Console.WriteLine("That emptyness. Is your brain the beginning of what they call antimateria?");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            case 2:
                                Console.WriteLine("Wow. Clock is ticking and we still have no winner.");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            case 3:
                                Console.WriteLine("Can you try and take this serious?");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            case 4:
                                Console.WriteLine("As Morpheous once told Neo: Stop trying to hit me and hit me!");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            case 5:
                                Console.WriteLine("I'm all out of luck for you.");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("This is just no fun.");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;

                        }
                    }
                    else
                    {
                        int letters = 0;
                        char[] guessArray = guessWord.ToCharArray();
                        char guessChar = guess[0];
                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            if (guess.Equals(secretWord[i].ToString()))
                            {
                                letters++;
                                guessArray[i] = guessChar;
                                string correctGuessedLetters = new string(guessArray);
                                guessWord = correctGuessedLetters;
                            }
                        }
                        if (letters > 0)
                        {
                            Console.WriteLine($"Congratulations! I found {letters} in the word you're looking for!");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("That's a no go");
                            wrong++;
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                    }
                }
            }


            // Singleplayer begins

            else if (choice == "1" || choice == "start")
            {
                Console.Clear();
                Console.Write("The computer is thinking of a word");
                Thread.Sleep(200);
                Console.Clear();
                Console.Write("The computer is thinking of a word.");
                Thread.Sleep(200);
                Console.Clear();
                Console.Write("The computer is thinking of a word..");
                Thread.Sleep(200);
                Console.Clear();
                Console.Write("The computer is thinking of a word...");
                Thread.Sleep(200);
                Console.Clear();
                Console.Write("The computer is thinking of a word");
                Thread.Sleep(200);
                Console.Clear();
                Console.Write("The computer is thinking of a word.");
                Thread.Sleep(200);
                Console.Clear();
                Console.Write("The computer is thinking of a word..");
                Thread.Sleep(200);
                Console.Clear();
                Console.Write("The computer is thinking of a word...");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("I got it!");
                Thread.Sleep(1500);
                Console.Clear();

                // Random generator created to choose a word of the given array.

                Random rnd = new();


                List<string> computerAlternative = new()
                {
                    "Hangman",
                    "Magical",
                    "Streamlined",
                    "Fixed",
                    "Control",
                    "Funsize",
                    "Flower",
                    "Music",
                    "Elevator",
                    "Factory",
                };

                int computerChoice = rnd.Next(computerAlternative.Count);

                string secretWord = computerAlternative[computerChoice].ToUpper();
                string guessWord = "";
                int wrong = 0;

                foreach (char c in secretWord)
                {
                    guessWord += "_";
                };


                while (!secretWord.Equals(guessWord) && wrong <= 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    // Switchstatement to show the stickfigure
                    switch (wrong)
                    {
                        case 0:
                            Console.WriteLine("_______");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            break;
                        case 1:
                            Console.WriteLine("_______");
                            Console.WriteLine("|   |");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            break;
                        case 2:
                            Console.WriteLine("_______");
                            Console.WriteLine("|   |");
                            Console.WriteLine("| (x.x) ");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            break;
                        case 3:
                            Console.WriteLine("_______");
                            Console.WriteLine("|   |");
                            Console.WriteLine("| (x.x) ");
                            Console.WriteLine("|  \\|/");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            break;
                        case 4:
                            Console.WriteLine("_______");
                            Console.WriteLine("|   |");
                            Console.WriteLine("| (x.x) ");
                            Console.WriteLine("|  \\|/");
                            Console.WriteLine("|   | ");
                            Console.WriteLine("|");
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            break;
                        case 5:
                            Console.WriteLine("_______");
                            Console.WriteLine("|   |");
                            Console.WriteLine("| (x.x) ");
                            Console.WriteLine("|  \\|/");
                            Console.WriteLine("|   | ");
                            Console.WriteLine("|  / \\");
                            Console.WriteLine("_______");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            Console.WriteLine("|     |");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("");
                            Console.WriteLine("THIS IS YOUR LAST CHANCE TO SAVE THE STICKFIGURE!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        default:
                            Console.WriteLine("You dead!");
                            Thread.Sleep(2000);
                            wrong++;
                            break;
                    }
                    
                    Console.WriteLine("Word to guess: " + guessWord);
                    Console.Write("Make your guess of a letter: ");
                    string? guess = Console.ReadLine().ToUpper();

                    if (guess == null || guess.Equals(""))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        int emptyGuess = rnd.Next(0, 5);

                        switch (emptyGuess)
                        {
                            case 0:
                                Console.WriteLine("I would hope you do know the alphabet.");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            case 1:
                                Console.WriteLine("That emptyness. Is your brain the beginning of what they call antimateria?");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            case 2:
                                Console.WriteLine("Wow. Clock is ticking and we still have no winner.");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            case 3:
                                Console.WriteLine("Can you try and take this serious?");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            case 4:
                                Console.WriteLine("As Morpheous once told Neo: Stop trying to hit me and hit me!");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            case 5:
                                Console.WriteLine("I'm all out of luck for you.");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("This is just no fun.");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;

                        }
                    }
                    else
                    {
                        int letters = 0;
                        char[] guessArray = guessWord.ToCharArray();
                        char guessChar = guess[0];
                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            if (guess.Equals(secretWord[i].ToString()))
                            {
                                letters++;
                                guessArray[i] = guessChar;
                                string correctGuessedLetters = new string(guessArray);
                                guessWord = correctGuessedLetters;
                            }
                        }
                        if (letters > 0)
                        {
                            Console.WriteLine($"Congratulations! I found {letters} in the word you're looking for!");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("That's a no go");
                            wrong++;
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                    }
                }
            }
        }
    }
}