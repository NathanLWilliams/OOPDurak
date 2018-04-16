/**
 * OOP4200 Book Excercise 
 * 
 * By following the "Adding a Cards Collection to CardLib",
 * "Adding Deep Copying to CardLib", and other excercises written in chapter 11, 12
 *  of the book called: Beginning Visual C# 2012 Programming
 * this library was created.
 * 
 * @author       Qasim Iqbal
 * @author       Nathan Williams
 * @author       Karli Watson (author of the book)
 * @version      4.0
 * @since        2018-03-18
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame
{
    public class Deck  : Cards
    {
        public enum Size
        {
            Small,
            Medium,
            Large
        }
        //private Cards cards = new Cards();
        public event EventHandler LastCardDrawn;

        #region Constructors
        public Deck(Size size, bool isAceHigh = false, bool useTrumps = false, Suit trump = Suit.Clubs)
        {
            int minRank = isAceHigh ? 2 : 1;

            switch(size)
            {
                case Size.Small:
                    minRank = 10;
                    break;
                case Size.Medium:
                    minRank = 6;
                    break;
            }

            for(int suitVal = 0; suitVal < 4; suitVal++)
            {
                for(int rankVal = minRank; rankVal < 14; rankVal++)
                {
                    this.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
                if(isAceHigh)
                    this.Add(new Card((Suit)suitVal, Rank.Ace));
            }

            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        private Deck(Cards newCards)
        {
            newCards.CopyTo(this); // not sure if this works
        }
        #endregion

        /// <summary>
        /// Nondefault constructor. Allows aces to be set high.
        /// </summary>
        public Deck(bool isAceHigh) : this(Size.Large, isAceHigh)
        {
            Card.isAceHigh = isAceHigh;
        }

        /// <summary>
        /// Nondefault constructor. Allows a trump suit to be used.
        /// </summary>
        public Deck(bool useTrumps, Suit trump) : this(Size.Large)
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        /// <summary>
        /// Nondefault constructor. Allows aces to be set high and a trump suit
        /// to be used.
        /// </summary>
        public Deck(bool isAceHigh, bool useTrumps, Suit trump) : this(Size.Large, isAceHigh)
        {
            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
            {
                if ((cardNum == 51) && (LastCardDrawn != null))
                    LastCardDrawn(this, EventArgs.Empty);
                return this[cardNum];
            }
            else
                throw new CardOutOfRangeException((Cards)this.Clone());
        }

        public Card DrawCard()
        {
            Card card = (Card)GetCard(this.Count - 1).Clone();
            this.RemoveAt(this.Count - 1);
            return card;
        }

        public void Shuffle()
        {
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for (int i = 0; i < 52; i++)
            {
                int sourceCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    sourceCard = sourceGen.Next(52);
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }
                assigned[sourceCard] = true;
                newDeck.Add(this[sourceCard]);
            }
            newDeck.CopyTo(this);
        }

      
    }
}