/**
 * OOP4200 Book Excercise 
 * 
 * By following the "Adding a Cards Collection to CardLib",
 * "Adding Deep Copying to CardLib", and other excercises written in chapter 11, 12, 13 
 *  of the book called: Beginning Visual C# 2012 Programming
 * the associated library was created, and demonstrated here.
 * 
 * @author       Nathan Williams
 * @author       Karli Watson (author of the book)
 * @version      1.0
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
    public class Player
    {
        public string Name { get; private set; }
        public Cards PlayHand { get; private set; }
        private Player()
        {
        }

        public Player(string name)
        {
            Name = name;
            PlayHand = new Cards();
        }

        public bool HasWon()
        {
            bool won = true;
            Suit match = PlayHand[0].suit;
            for (int i = 1; i < PlayHand.Count; i++)
            {
                won &= PlayHand[i].suit == match;
            }
            return won;
        }
    }
}
