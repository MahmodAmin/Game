using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputDevice;
            int randomInt;
       
            bool playAgain = true;
            while (playAgain)
            {
                int ScorePlayer = 0, ScoreDevice = 0;
                while (ScorePlayer < 3 && ScoreDevice < 3)
                {
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.Write("Choose between  ROCK, PAPER and SCISSORS :     ");
                    inputPlayer = Console.ReadLine();
                    Random r = new Random();
                    randomInt = r.Next(1, 4);
                    Console.ForegroundColor= ConsoleColor.White;
                    switch (randomInt)
                    {
                        case 1:
                            inputDevice = "ROCK";
                            Console.WriteLine("Computer choose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.ForegroundColor= ConsoleColor.DarkYellow;
                                Console.WriteLine("Equivalent!!");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.ForegroundColor= ConsoleColor.Cyan;
                                Console.WriteLine("PAPER BEATS ROCK");
                                Console.ForegroundColor= ConsoleColor.DarkGreen;
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                ScorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.ForegroundColor= ConsoleColor.Cyan;
                                Console.WriteLine("ROCK BEATS SCISSORS");
                                Console.ForegroundColor= ConsoleColor.DarkBlue;
                                Console.WriteLine("DIVICE WINS!!\n\n");
                                ScoreDevice++;
                            }
                            break;
                        case 2:
                            inputDevice = "PAPER";
                            Console.WriteLine("Computer choose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Equivalent!!");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("SCISSORS BEATS PAPER");
                                Console.ForegroundColor=ConsoleColor.DarkGreen;
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                ScorePlayer++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("PAPAER BEATS ROCK");
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("DIVICE WINS !!\n\n");
                                ScoreDevice++;
                            }
                            break;
                        case 3:
                            inputDevice = "SCISSORS";
                            Console.WriteLine("Computer choose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Equivalent!!");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("ROCK BEATS SCISSORS");
                                Console.ForegroundColor= ConsoleColor.DarkGreen;
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                ScorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("SCISSORS BEATS PAPER");
                                Console.ForegroundColor= ConsoleColor.DarkBlue;
                                Console.WriteLine("DIVICE WINS!!\n\n");
                                ScoreDevice++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid empty!");
                            break;
                    }
                    Console.ForegroundColor= ConsoleColor.DarkMagenta;
                    Console.WriteLine("\nSCORES :\tPLAYER:\t{0}\tDEVICE:\t{1}", ScorePlayer, ScoreDevice);
                }
                Console.ForegroundColor= ConsoleColor.Blue;
                   if (ScorePlayer == 3)
                   {
                    Console.WriteLine("PLAYER WON!");
                   }
                   else if (ScoreDevice == 3)
                   {
                    Console.WriteLine("DEVICE WON!");
                   }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Do you want to play again ?");
                string ch = Console.ReadLine();
                if(ch=="y"||ch=="Y"||ch=="Yes"||ch=="yes")
                {
                  playAgain = true;
                  Console.Clear();
                }
               else 
               {
                  playAgain = false;
               }
            }
        }
    }
}
