/**
 * OOP4200 Book Excercise 
 * 
 * By following the "Adding a Cards Collection to CardLib",
 * "Adding Deep Copying to CardLib", and other excercises written in chapter 11, 12
 *  of the book called: Beginning Visual C# 2012 Programming
 * this library was created.
 * 
 * @authro       Qasim Iqbal
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
    public class Cards : CollectionBase, ICloneable
    {

        public void Add(Card newCard) { List.Add(newCard); }
        public void Insert(int theIndex, Card aCard) { List.Insert(theIndex, aCard); }
        public void Remove(Card oldCard) { List.Remove(oldCard); }
        public bool Contains(Card aCard) { return List.Contains(aCard); }

        /// <summary>
        /// Indexer is important method as it implements enumerator method which allows Cards to be used enumerated by foreach loop
        /// </summary>
        /// <param name="cardIndex"></param>
        /// <returns></returns>
        public Card this[int cardIndex]
        {
            get
            {
                return (Card)List[cardIndex];
            }
            set
            {
                List[cardIndex] = value;
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        
        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

    }


    //public class Cards : ObservableCollection<Card>, ICloneable
    //{
    //    /// <summary>
    //    /// Utility method for copying card instances into another Cards
    //    /// instance—used in Deck.Shuffle(). This implementation assumes that
    //    /// source and target collections are the same size.
    //    /// </summary>
    //    public void CopyTo(Cards targetCards)
    //    {
    //        for (int index = 0; index < this.Count; index++)
    //        {
    //            targetCards[index] = this[index];
    //        }
    //    }

    //    public object Clone()
    //    {
    //        Cards newCards = new Cards();
    //        foreach (Card sourceCard in this)
    //        {
    //            newCards.Add((Card)sourceCard.Clone());
    //        }
    //        return newCards;
    //    }

    //}
}
