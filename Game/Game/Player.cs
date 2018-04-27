/* Player.cs
 * Group 9 (Nathan Williams, Jonathan Hermans, Karence Ma, Qasim Iqbal)
 * Date: 26/4/18
 * Description: A class for all players.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    /// <summary>
    /// The player class is abstract and can be inherited (it is inherited by the AI & Human)
    /// </summary>
    public abstract class Player
    {

        // fields and properties
        private int myScore; // probably make seperate score class later

        /// <summary>
        /// A property for score
        /// </summary>
        public int Score
        {
            get { return myScore; }
            set { myScore = value; }
        }

        private Hand myHand;


        /// <summary>
        /// A property for the hand a player (human or AI) has
        /// </summary>
        public Hand MyHand
        {
            get { return myHand; }
            set { myHand = value; }
        }

        /// <summary>
        /// A property for the status of the player (human or AI)
        /// </summary>
        public enum PlayerStatus
        {

        }

        /// <summary>
        /// A property for the card of a player
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public virtual Card PlayCard(Card card)
        {
            return card;
        }

        private string name;

        /// <summary>
        /// A property for the name of a player
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Image image;

        /// <summary>
        /// A property for the players image
        /// </summary>
        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

    }
}
