/*
 * Card.cs
 * @Author : Qasim Iqbal
 * @since  : March 03, 2018
 * @see    : https://www.youtube.com/watch?v=gK6bJ9IudW8&t=87s Thom MacDonald's Youtube Video on CardBox
 * @Desc   : This class has been modifed to after watching thom's video on CardBox to fit in tutorail 7 requirements
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CardGame
{
    public class Card : ICloneable, IComparable
    {
        #region FEILDS & Attributes

        protected Suit mySuit;
        public Suit Suit
        {
            get { return mySuit; } // return suit
            set { mySuit = value; } // set the suit
        }
        protected Rank myRank;
        public Rank Rank
        {
            get { return myRank; }
            set { myRank = value; }
        }

        protected int myValue;
        public int CardValue
        {
            set { myValue = value; }
            get { return myValue; }
        }

        protected bool faceUp = false;

        public bool FaceUp
        {
            get { return faceUp; }
            set { faceUp = value; }
        }

        private string image; // card image

        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        #endregion

        #region Constructors 

        /// <summary>
        /// Card constructor. initialized default card.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="suit"></param>
        public Card(Rank rank = Rank.Ace, Suit suit = Suit.Hearts)
        {   // set rank, suit
            this.myRank = rank;
            this.mySuit = suit;

            // set default card value
            this.myValue = (int)rank;
        }
        #endregion

        #region RELATIONAL OPERATORS
        public static bool operator ==(Card left, Card right)
        {
            return (left.CardValue == right.CardValue);
        }
        public static bool operator !=(Card left, Card right)
        {
            return (left.CardValue != right.CardValue);
        }
        public static bool operator <(Card left, Card right)
        {
            return (left.CardValue < right.CardValue);
        }
        public static bool operator >(Card left, Card right)
        {
            return (left.CardValue > right.CardValue);
        }
        public static bool operator <=(Card left, Card right)
        {
            return (left.CardValue <= right.CardValue);
        }
        public static bool operator >=(Card left, Card right)
        {
            return (left.CardValue >= right.CardValue);
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Card specific comparision method used for sorting cards. Helps IEnumerable interface for card specific methods
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public virtual int CompareTo(object obj)
        {
            // is the argument null?
            if (obj == null)
            {
                throw new ArgumentNullException("Unable to compare a card to a null object.");
            }
            // convert the argument to a card
            Card compareCard = obj as Card;
            // if the conversion worked
            if (compareCard != null)
            {
                int thisSort = this.myValue * 10 + (int)this.mySuit;
                int compareCardSort = compareCard.myValue * 10 + (int)compareCard.mySuit;
                return (thisSort.CompareTo(compareCardSort));
            }
            else
            {
                throw new ArgumentException("Object being compared cannot be converted toa  Card.");
            }

        }
        /// <summary>
        /// Copy of Card
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        /// <summary>
        /// Card class ToString Overriden
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string cardString;     // holds the playing card name.
            // if the card is faceup 
            if (faceUp)
            {
                cardString = myRank.ToString() + " of " + mySuit.ToString();
            }
            else
            {
                cardString = "Face Down";
            }
            return cardString;
        }
        /// <summary>
        /// Compairing different card objects with each other with card value
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (this.CardValue == ((Card)obj).CardValue);
        }
        /// <summary>
        /// Unique value of each card calculated based on its state
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.myValue * 100 + (int)this.mySuit * 10 + ((this.faceUp) ? 1 : 0);
        }
        /// <summary>
        /// gets image for card given string name made my rank and suit
        /// </summary>
        /// <returns></returns>
        public Image GetCardImage()
        {
            string imageName;     // the name of image for the back of a card
            Image cardImage;      // holds the image

            if (!faceUp)
            {
                imageName = "Back";    // sets it to the image name for the back of a card
            }
            else
            {
                imageName = myRank.ToString() + "_of_" + mySuit.ToString(); // enumerations are handy
            }
            // set the image firl to cardimage from the resourse
            cardImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;

            return cardImage;
        }
        #endregion

    }
}