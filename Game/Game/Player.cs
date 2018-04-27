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

        //The displayed name of the player
        private string name;

        /// <summary>
        /// A property for the name of a player
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //The displayed image of the player
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
