/* AiPlayer.cs
 * Group 9 (Nathan Williams, Jonathan Hermans, Karence Ma, Qasim Iqbal)
 * Date: 26/4/18
 * Description: A class for AI Players.
 */
using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// <summary>
    /// AI player class inherits from the abstract player class
    /// </summary>
    public class AiPlayer : Player
    {

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
                    if(object.ReferenceEquals(tempCard, null)) // tempCard is currently null, so any card will work
                    {
                        tempCard = c;
                    }
                    else if(c.Rank < tempCard.Rank) //A tempCard is being stored, so see if this one is better
                    {
                        tempCard = c;
                    }
                }
            }
            
            return tempCard;
        }
    }
}
