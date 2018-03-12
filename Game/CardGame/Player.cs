using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public abstract class Player
    {
        // fields and properties
        private Hand myHand;

        public Hand MyHand
        {
            get { return myHand; }
            set { myHand = value; }
        }
        public enum PlayerStatus
        {

        }
        public virtual Card PlayCard(Card card)
        {
            return card;
        }
        public void Pass()
        {

        }

    }
}
