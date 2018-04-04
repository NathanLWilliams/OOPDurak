/**
 * OOP4200 Book Excercise 
 * 
 * By following the "Adding a Cards Collection to CardLib",
 * "Adding Deep Copying to CardLib", and other excercises written in chapter 11, 12
 *  of the book called: Beginning Visual C# 2012 Programming
 * this library was created.
 * 
 * @author       Nathan Williams
 * @author       Karli Watson (author of the book)
 * @version      3.0
 * @since        2018-03-07
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Cards : ObservableCollection<Card>, ICloneable
    {
        /// <summary>
        /// Utility method for copying card instances into another Cards
        /// instance—used in Deck.Shuffle(). This implementation assumes that
        /// source and target collections are the same size.
        /// </summary>
        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        public object Clone()
        {
            Cards newCards = new Cards();
            foreach (Card sourceCard in this)
            {
                newCards.Add((Card)sourceCard.Clone());
            }
            return newCards;
        }
    }
}
