using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    //    public class Cards : List<Card>, ICloneable
    //    {
    //        /// <summary>
    //        /// Utility method for copying card instances into another Cards
    //        /// instance—used in Deck.Shuffle(). This implementation assumes that
    //        /// source and target collections are the same size.
    //        /// </summary>
    //        public void CopyTo(Cards targetCards)
    //        {
    //            for (int index = 0; index < this.Count; index++)
    //            {
    //                targetCards[index] = this[index];
    //            }
    //        }

    //        public object Clone()
    //        {
    //            Cards newCards = new Cards();
    //            foreach (Card sourceCard in this)
    //            {
    //                newCards.Add((Card)sourceCard.Clone());
    //            }
    //            return newCards;
    //        }
    //    }
    public class Hand : ICloneable
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
    //        // event to be raised when the last card is drawn form the deck
    //        public event EventHandler LastCardDrawn;

    //        private Cards cards = new Cards();

    //        public Hand()
    //        {
    //            for (int suitVal = 0; suitVal < 4; suitVal++)
    //            {
    //                for (int rankVal = 1; rankVal < 14; rankVal++)
    //                {
    //                    cards.Add(new Card((Rank)rankVal, (Suit)suitVal));
    //                }
    //            }
    //        }

    //        private Hand(Cards newCards)
    //        {
    //            cards = newCards;
    //        }

    //        /// <summary>
    //        /// Nondefault constructor. Allows aces to be set high.
    //        /// </summary>
    //        public Deck(bool isAceHigh)
    //           : this()
    //        {
    //            Card.isAceHigh = isAceHigh;
    //        }

    //        /// <summary>
    //        /// Nondefault constructor. Allows a trump suit to be used.
    //        /// </summary>
    //        public Hand(bool useTrumps, Suit trump)
    //           : this()
    //        {
    //            Card.useTrumps = useTrumps;
    //            Card.trump = trump;
    //        }

    //        /// <summary>
    //        /// Nondefault constructor. Allows aces to be set high and a trump suit
    //        /// to be used.
    //        /// </summary>
    //        public Deck(bool isAceHigh, bool useTrumps, Suit trump)
    //           : this()
    //        {
    //            Card.isAceHigh = isAceHigh;
    //            Card.useTrumps = useTrumps;
    //            Card.trump = trump;
    //        }

    //        public Card GetCard(int cardNum)
    //        {
    //            if (cardNum >= 0 && cardNum <= 51)
    //            {
    //                if ((cardNum == 51) && (LastCardDrawn != null))
    //                    LastCardDrawn(this, EventArgs.Empty); // raising the last card drawn event 
    //                return cards[cardNum];
    //            }
    //            else
    //                // erasing previous exception and replacing with new exception class
    //                throw new CardOutOfRangeException(cards.Clone() as Cards);
    //        }

    //        public void Shuffle()
    //        {
    //            Cards newDeck = new Cards();
    //            bool[] assigned = new bool[52];
    //            Random sourceGen = new Random();
    //            for (int i = 0; i < 52; i++)
    //            {
    //                int sourceCard = 0;
    //                bool foundCard = false;
    //                while (foundCard == false)
    //                {
    //                    sourceCard = sourceGen.Next(52);
    //                    if (assigned[sourceCard] == false)
    //                        foundCard = true;
    //                }
    //                assigned[sourceCard] = true;
    //                newDeck.Add(cards[sourceCard]);
    //            }
    //            newDeck.CopyTo(cards);
    //        }

    //        public object Clone()
    //        {
    //            Hand newDeck = new Hand(cards.Clone() as Cards);
    //            return newDeck;
    //        }
    //    }
    //}

}
