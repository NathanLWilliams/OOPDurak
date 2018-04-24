using DeckViewerTester;
using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class AiPlayer : Player
    {
        /*public Card chooseAction (int action)
        {
            Card card = new Card();
            return card;
        }

        private int action;

        public int Action
        {
            get { return action; }
            set { action = value; }
        }*/

        /// <summary>
        /// Returns a Card representing what the AiPlayer plans to play,
        /// if null he is unable to play
        /// </summary>
        /// <param name="cards">The cards in the current bout</param>
        /// <returns>The chosen card</returns>
        public Card ChooseAction(DeckViewer AiPlayerDeck, BoutViewer bout)
        {
            //Hold a temporary card for the best card to play currently
            Card tempCard = null;

            //Loop through the bout viewer cards and the AiPlayer's hand
            foreach(Card c in AiPlayerDeck.GetCards())
            {
                //Find the lowest playable card and store it as the temporary card
                if (bout.canPlaceCard(c))
                {
                    if(object.ReferenceEquals(tempCard, null))
                    {
                        tempCard = c;
                    }
                    else if(c.Rank < tempCard.Rank)
                    {
                        tempCard = c;
                    }
                }
            }
            
            return tempCard;
        }

        public void Pass()
        {

        }
    }
}
