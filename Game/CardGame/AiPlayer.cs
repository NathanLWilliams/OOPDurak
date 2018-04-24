using DeckViewerTester;
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

        //TODO: Make this integer and enum
        /// <summary>
        /// Returns an integer representing what the AiPlayer plans to do next
        /// </summary>
        /// <param name="cards">The cards in the current bout</param>
        /// <returns>The chosen action</returns>
        public int ChooseAction(BoutViewer bout)
        {
            //Hold a temporary card for the best card to play currently
            Card tempCard = null;
            int action = 0; //defaults to pass

            //Loop through the bout viewer cards and the AiPlayer's hand
            /*foreach(Card c in a deck viewer) //TODO: Figure out how to refer to the deckViewer (maybe instantiate it in Player?)
            {
                //Find the lowest playable card and store it as the temporary card
                if (bout.canPlaceCard(c) && (c.Rank < tempCard.Rank || tempCard == null))
                {
                    tempCard = c;
                    action = 1; //play card
                }
            }

            
            if(action == 0)
            {
                //The AI passes
                //TODO: Figure out how to call DurakPage.EndBout();
            }
            else if (action == 1)
            {
                //The AI plays a card
                
                //Add a clone of the card to the bout

                //Remove the card from the AI deck
            }*/

            return action;
        }

        public void Pass()
        {

        }
    }
}
