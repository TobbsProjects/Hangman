using System.Security.Cryptography;

Console.ForegroundColor = ConsoleColor.Green;

// The menu where the user makes their choice.

Console.WriteLine("Welcome to the classic game Hangman!");
Console.WriteLine("");
Console.WriteLine("What would you like to do?");
Console.WriteLine("1. Start a singleplayer game.");
Console.WriteLine("2. Start a local multiplayer game.");
Console.WriteLine("3. Rules.");
Console.WriteLine("4. Exit.");

string? choice = Console.ReadLine();

// Choice 1 begins.

if (choice == "1" || choice == "start")
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

    Random rnd = new Random();
    int computerChoice = rnd.Next(0, 9);
    string[] computerAlternative = new string[10];
    string secretWord = computerAlternative[computerChoice];
    string guessWord = "";


    while(secretWord != guessWord)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Make your guess of a letter: ");
        string? guess = Console.ReadLine();

        if(guess == null || guess == "")
        {
            Console.ForegroundColor = ConsoleColor.Red;
 
            int wrong = rnd.Next(0, 5);

            switch (wrong)
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
    }
}