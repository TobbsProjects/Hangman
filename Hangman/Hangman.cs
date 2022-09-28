using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Hangman
    {
        public static void printHangman(int wrong)
        {
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
                    break;
                default:
                    Console.WriteLine("You dead!");
                    break;
            }
        }
    }
}
