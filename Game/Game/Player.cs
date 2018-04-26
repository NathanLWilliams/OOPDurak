using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public abstract class Player
    {

        // fields and properties
        private int myScore; // probably make seperate score class later
        public int Score
        {
            get { return myScore; }
            set { myScore = value; }
        }

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

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Image image;

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

    }
}
