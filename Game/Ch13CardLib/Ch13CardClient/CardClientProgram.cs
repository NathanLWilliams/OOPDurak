/**
 * OOP4200 Book Excercise 
 * 
 * By following the "Adding a Cards Collection to CardLib",
 * "Adding Deep Copying to CardLib", and other excercises written in chapter 11, 12 
 *  of the book called: Beginning Visual C# 2012 Programming
 * the associated library was created, and demonstrated here.
 * 
 * @author       Nathan Williams
 * @author       Karli Watson (author of the book)
 * @version      4.0
 * @since        2018-03-18
 */

using Ch13CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13CardClient
{
    class CardClientProgram
    {
        static void Main(string[] args)
        {
            // Display introduction.
            Console.WriteLine("KarliCards: a new and exciting card game.");
            Console.WriteLine("To win you must have 7 cards of the same suit in" +
                              " your hand.");
            Console.WriteLine();

            // Prompt for number of players.
            bool inputOK = false;
            int choice = -1;
            do
            {
                Console.WriteLine("How many players (2–7)?");
                string input = Console.ReadLine();
                try
                {
                    //Attempt to convert input into a valid number of players.
                    choice = Convert.ToInt32(input);
                    if ((choice >= 2) && (choice <= 7))
                        inputOK = true;
                }
                catch
                {
                    //Ignore failed conversions, just continue prompting.
                }
            } while (inputOK == false);

            // Initialize array of Player objects.
            Player[] players = new Player[choice];

            // Get player names.
            for (int p = 0; p < players.Length; p++)
            {
                Console.WriteLine("Player {0}, enter your name:", p + 1);
                string playerName = Console.ReadLine();
                players[p] = new Player(playerName);
            }

            // Start game.
            Game newGame = new Game();
            newGame.SetPlayers(players);
            int whoWon = newGame.PlayGame();

            // Display winning player.
            Console.WriteLine("{0} has won the game!", players[whoWon].Name);
            Console.ReadKey();
        }
    }
}
