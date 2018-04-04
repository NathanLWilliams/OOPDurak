/**
 * OOP4200 Book Excercise 
 * 
 * By following the "Adding a Cards Collection to CardLib",
 * "Adding Deep Copying to CardLib", and other excercises written in chapter 11, 12, 13
 *  of the book called: Beginning Visual C# 2012 Programming
 * this library was created.
 * 
 * @author       Nathan Williams
 * @author       Karli Watson (author of the book)
 * @version      1.0
 * @since        2018-03-18
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class CardOutOfRangeException : Exception
    {
        private Cards deckContents;
        public Cards DeckContents
        {
            get
            {
                return deckContents;
            }
        }
        public CardOutOfRangeException(Cards sourceDeckContents)
            : base("There are only 52 cards in the deck.")
        {
            deckContents = sourceDeckContents;
        }
    }
}
