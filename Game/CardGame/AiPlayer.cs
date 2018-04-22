using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class AiPlayer : Player
    {
        public Card chooseAction (int action)
        {
            Card card = new Card();
            return card;
        }

        private int action;

        public int Action
        {
            get { return action; }
            set { action = value; }
        }

                public void Pass()
        {

        }
    }
}
