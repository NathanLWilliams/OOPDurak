using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Hand
    {
        // Field
        private int size;

        public static int DEFUALT_DECK_SIZE = 52;
        public IEnumerable<Card> cards;

        public int Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        public void Initialize(int cardCount)
        {

        }
        public Card DrawCard()
        { 
            return cards.First(); // just making it return something for now
        }
        public Hand(int cardNum = 52) // 52 for now make variable later
        {
            Initialize(cardNum);
        }
    }
}
