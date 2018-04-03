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
 * Images used are open source, found here:
 * https://code.google.com/archive/p/vector-playing-cards/
 */

using System;
using System.Drawing;

namespace Ch13CardLib
{
    public class Card : ICloneable
    {
        protected Rank rank; //Previously readonly
        public Rank Rank
        {
            get
            {
                return this.rank;
            }
            set
            {
                this.rank = value;
            }
        }

        protected Suit suit; //Previously readonly
        public Suit Suit
        {
            get
            {
                return this.suit;
            }
            set
            {
                this.suit = value;
            }
        }

        private bool isFaceUp;
        public bool FaceUp
        {
            get
            {
                return this.isFaceUp;
            }
            set
            {
                this.isFaceUp = value;
            }
        }

        /// <summary>
        /// Flag for trump usage. If true, trumps are valued higher than cards of other suits.
        /// </summary>
        public static bool useTrumps = false;

        /// <summary>
        /// Trump suit to use if useTrumps is true.
        /// </summary>
        public static Suit trump = Suit.Clubs;

        /// <summary>
        /// Flag that determines whether aces are higher than kings or lower than deuces.
        /// </summary>
        public static bool isAceHigh = true;

        public Card()
        {
            this.Rank = Rank.Ace;
            this.Suit = Suit.Spades;
            this.FaceUp = false;
        }

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
        public override string ToString()
        {
            string cardString;

            if (FaceUp)
            {
                cardString = Rank.ToString() + " of " + Suit.ToString();
            }
            else
            {
                cardString = "Face Down";
            }
            return cardString;
        }
        public static bool operator ==(Card card1, Card card2)
        {
            return (card1.suit == card2.suit) && (card1.rank == card2.rank);
        }
        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }
        public override bool Equals(object card)
        {
            return this == (Card)card;
        }
        public override int GetHashCode()
        {
            return (int)suit * 10 + (int)rank * 100 + ((this.FaceUp)?1:0);
        }
        public static bool operator >(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank > card2.rank);
                    }
                }
                else
                {
                    return (card1.rank > card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }
        public static bool operator <(Card card1, Card card2)
        {
            return !(card1 >= card2);
        }
        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        return true;
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                            return false;
                        else
                            return (card1.rank >= card2.rank);
                    }
                }
                else
                {
                    return (card1.rank >= card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }
        public static bool operator <=(Card card1, Card card2)
        {
            return !(card1 > card2);
        }
        public virtual int CompareTo(object obj)
        {
            if(obj == null)
            {
                throw new ArgumentNullException("Unable to compare a Card to a null object.");
            }
            //convert the argument to a Card
            Card compareCard = obj as Card;
            //if the conversion worked
            if(compareCard != null)
            {
                //compare based on Value first, then suit
                int thisSort = (int)this.Rank * 10 + (int)this.Suit;
                int compareCardSort = (int)compareCard.Rank * 10 + (int)compareCard.Suit;
                return (thisSort.CompareTo(compareCardSort));
            }
            else // otherwise, the conversion failed
            {
                // throw an argument exception
                throw new ArgumentException("Object being compared cannot be converted to a Card.");
            }
        }

        /// <summary>
        /// Gets the card image resource that matches the rank and suit of this card
        /// </summary>
        /// <returns>The card image resource</returns>
        public Image GetCardImage()
        {
            string imageName; // the name of the image in the resource file
            Image cardImage; // holds the image
            //if the card is not face up
            if(!FaceUp)
            {
                imageName = "back";
            }
            else
            {
                //set the image to _{Suit}_of_{Rank}
                imageName = "_" + Rank.ToString().ToLower() + "_of_" + Suit.ToString().ToLower();
            }
            //set the image to the appropriate object we get from the resources file
            cardImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;
            //return the image
            return cardImage;
        }
    }
}