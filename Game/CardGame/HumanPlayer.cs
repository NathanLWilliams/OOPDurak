using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class HumanPlayer : Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public override Card PlayCard(Card card)
        {
            return base.PlayCard(card);
        }

    }
}
