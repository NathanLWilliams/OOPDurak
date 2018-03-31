/*
 * CardBox.cs
 * @Author : Qasim Iqbal
 * @since  : March 03, 2018
 * @see    : https://www.youtube.com/watch?v=gK6bJ9IudW8&t=87s Thom MacDonald's Youtube Video on CardBox
 * @see    : Images used for cards were royalty free from http://acbl.mybigcommerce.com/52-playing-cards/, and https://code.google.com/archive/p/vector-playing-cards/
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardGame;

namespace CardBoxControl
{
    /// <summary>
    /// A control to use in a window forms application that displays a playing card.
    /// </summary>
    public partial class CardBox: UserControl
    {
        #region FIELDS AND PROPERTIES

        private Card myCard;
        public Card Card
        {
            set
            {
                myCard = value;
            }
            get
            {
                return myCard;
            }
        }

        public Suit Suit
        {
            set
            {
                Card.Suit = value;
                UpdateCardImage();
            }
            get { return Card.Suit; }
        }
        public Rank Rank
        {
            set
            {

                Card.Rank = value;
                UpdateCardImage();

            }
            get { return Card.Rank; }
        }
        public bool FaceUp
        {
            set
            {
                if (myCard.FaceUp != value) // then card is flipping over
                {
                    myCard.FaceUp = value; // change cards flipped property
                    UpdateCardImage();

                    // if there is an event handle for cardflipped in cilent program
                    if (CardFlipped != null)
                        CardFlipped(this, new EventArgs()); // call it
                }

            }
            get { return Card.FaceUp; }
        }

        private Orientation myOrentaion;
        public Orientation CardOrientation
        {
            set
            {
                if (myOrentaion != value)
                {
                    myOrentaion = value;
                    this.Size = new Size(Size.Height, Size.Width);
                    // update card image
                    UpdateCardImage();

                }
            }
            get { return myOrentaion; }
        }

        #endregion
        #region Constructor
        public CardBox()
        {
            InitializeComponent();
            myOrentaion = Orientation.Vertical;
            myCard = new Card();
        }

        public CardBox(Card card, Orientation orientation = Orientation.Vertical)
        {
            InitializeComponent();
            myOrentaion = orientation;
            myCard = card; // set the underlying card
        }
        #endregion

        #region Events and Event Hanlder
        private void CardBox_Load(object sender, EventArgs e)
        {
            UpdateCardImage(); // update card image();
        }

        /// <summary>
        /// an event the client program can handle when the user clicks the control
        /// </summary>
        new public event EventHandler Click;
        /// <summary>
        /// Event for picture box click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbCardDisplay_Click(object sender, EventArgs e)
        {
            if (Click != null) // if there is client for clicking control in client program
                Click(this, e); // call it
        }
        /// <summary>
        /// an event that flips card when triggered
        /// </summary>
        public event EventHandler CardFlipped;


        #endregion
        #region Other methods
        /// <summary>
        /// returns image for the card, also manages orientation of image
        /// </summary>
        private void UpdateCardImage()
        {
            pbCardDisplay.Image = myCard.GetCardImage();

            if (myOrentaion == Orientation.Horizontal)
            {
                pbCardDisplay.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }
        public override string ToString()
        {
            return myCard.ToString();
        }


        #endregion


    }
}
