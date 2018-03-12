using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CardGame
{
    public class Card
    {
        public readonly Rank rank;
        public readonly Suit suit;

        private bool faceUp;

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

        public Card()
        {

        }
        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }






    }
}
