/*
 * CardBox.cs
 * @Author : Qasim Iqbal
 * @since  : March 03, 2018
 * @see    : https://www.youtube.com/watch?v=gK6bJ9IudW8&t=87s Thom MacDonald's Youtube Video on CardBox
 * @see    : Images used for cards were royalty free from http://acbl.mybigcommerce.com/52-playing-cards/, and https://code.google.com/archive/p/vector-playing-cards/
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using CardGame;

namespace CardBoxControl
{
    /// <summary>
    /// A control to use in a window forms application that displays a playing card.
    /// </summary>
    public partial class CardBox : UserControl
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

        /// <summary>
        /// The amount the card size increases upon mouse over
        /// </summary>
        private const float CARD_POP_SIZE = 1.1f;

        //for tracking where to place the card when popping the card forward or back upon mouse over
        private int lastZIndex = 0;

        private bool isEnlarged = false;
        private Size smallSize;
        private Size bigSize;
        private Point previousLocation;

        #endregion
        #region Constructor
        public CardBox() : this(new Card(), false, Orientation.Vertical)
        {
            InitializeComponent();
        }

        public CardBox(Card card, bool canGrow = false, Orientation orientation = Orientation.Vertical)
        {
            InitializeComponent();
            myOrentaion = orientation;
            myCard = card; // set the underlying card

            if (canGrow)
            {
                this.pbCardDisplay.MouseLeave += new System.EventHandler(this.pbCardDisplay_MouseLeave);
                this.pbCardDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbCardDisplay_MouseMove);
            }
            this.pbCardDisplay.MouseClick += new MouseEventHandler(this.pbCardDisplay_MouseDown);
        }
        #endregion

        #region Events and Event Hanlder
        private void CardBox_Load(object sender, EventArgs e)
        {
            UpdateCardImage(); // update card image();
            this.smallSize = this.Size;
            this.bigSize = new Size((int)(this.Size.Width * CARD_POP_SIZE), (int)(this.Size.Height * CARD_POP_SIZE));
            this.previousLocation = this.Location;
        }


        private void pbCardDisplay_MouseLeave(object sender, EventArgs e)
        {
            Shrink();
        }
        private void pbCardDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            double widthDivider = (2 + this.Parent.Controls.Count / 3);

            //Grow if the visible portion of the card is being moused over
            if (this.Parent.PointToClient(Cursor.Position).X < this.previousLocation.X + (int)(smallSize.Width / widthDivider)
                || this.Name == "lastCardInView")
            {
                Grow();
            }
            else
            {
                Shrink();
            }

        }

        private void Shrink()
        {
            if (this.isEnlarged)
            {
                this.Parent.Controls.SetChildIndex(this, lastZIndex);
                this.Location = new Point(this.Location.X + (bigSize.Width - smallSize.Width) / 2, this.Location.Y + (bigSize.Height - smallSize.Height) / 2);
                this.Size = smallSize;
                this.isEnlarged = false;
                //this.Parent.Refresh();
            }
        }
        private void Grow()
        {
            if (this.isEnlarged == false)
            {
                lastZIndex = this.Parent.Controls.GetChildIndex(this);
                this.Size = bigSize;
                this.previousLocation = this.Location;
                this.Location = new Point(this.Location.X - (bigSize.Width - smallSize.Width) / 2, this.Location.Y - (bigSize.Height - smallSize.Height) / 2);
                this.BringToFront();
                this.isEnlarged = true;
                //this.Parent.Refresh();
            }
        }

        public event EventHandler CardClicked;
        private void pbCardDisplay_Click(object sender, EventArgs e)
        {
            // bubble event to parent
            if (this.CardClicked != null)
            {
                this.CardClicked(this, e);
            }
        }

        private void pbCardDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            this.DoDragDrop(new DataObject(DataFormats.Text, this.Card.GetHashCode()), DragDropEffects.Move);
            System.Console.WriteLine("MouseDown");
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
