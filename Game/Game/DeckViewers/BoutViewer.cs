/* BoutViewer.cs
 * Group 9 (Nathan Williams, Jonathan Hermans, Karence Ma, Qasim Iqbal)
 * Date: 26/4/18
 * Description: A subclass of DeckViewer, this is used to represent the bout which players will place their cards into
 */

using CardBoxControl;
using CardGame;
using Game;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Game
{

    /// <summary>
    /// BoutViewer is a class which inherits from DeckViewer
    /// </summary>
    public class BoutViewer : DeckViewer
    {
        // Constants and Variables
        public static int MAXIMUM_CARDS_IN_BOUT = 12;
        private int cardCountAtBoutStart = 6;
        // An event flag for added cards
        public event EventHandler CardAdded;

        /// <summary>
        /// Gets a count of cards and sets the card count
        /// </summary>
        public int CardCountAtBoutStart
        {
            get { return cardCountAtBoutStart; }
            set { cardCountAtBoutStart = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        public BoutViewer() : base()
        {

        }

        /// <summary>
        /// Method which adds a deck
        /// </summary>
        /// <param name="deck"></param>
        public void AddDeck(Deck deck)
        {
            this.DrawCards(deck, deck.Count);
        }

        /// <summary>
        /// Method which adds a card
        /// </summary>
        /// <param name="c"></param>
        /// <param name="adjust"></param>
        /// <param name="willTriggerTurn"></param>
        public void AddCard(Card c, bool willTriggerTurn = false)
        {
            //Console.WriteLine("ADDED CARD");
            base.AddCard(c);

            // An if structure which determines whether the argument willTriggerTurn is true
            if(willTriggerTurn)
                CardAdded(this, new EventArgs());
        }

        /// <summary>
        /// Method which determines whether the card was 'dragged'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        public override void DeckViewer_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(CardBox)) != null)
            {
                // An logic structure which determines whether its a player card
                if(this.isFull() == false)
                {
                    CardBox draggedCard = (CardBox)e.Data.GetData(typeof(CardBox));
                    if (draggedCard.Parent.GetType() == typeof(DeckViewer) && (string)draggedCard.Parent.Tag != "enemyDeck")
                        e.Effect = DragDropEffects.Move;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
                
            }
        }

        /// <summary>
        /// Method which determines whether the card was 'dropped' 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void DeckViewer_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(CardBox)) != null && this.isFull() == false)
            {

                CardBox draggedCard = (CardBox)e.Data.GetData(typeof(CardBox));


                // A logic structure which determines which panels to move the card to
                if (draggedCard != null && draggedCard.Parent.GetType() == typeof(DeckViewer))
                {
                    DeckViewer fromPanel = draggedCard.Parent as DeckViewer;
                    BoutViewer toPanel = sender as BoutViewer;

                    if (toPanel != null && fromPanel != null)
                    {
                        if (toPanel != fromPanel)
                        {
                            if(toPanel.canPlaceCard(draggedCard.Card))
                            {
                                fromPanel.RemoveCard(draggedCard.Card);
                                toPanel.AddCard(draggedCard.Card, true);
                            }
                        }
                    }

                }

            }


        }

        /// <summary>
        /// Checks whether cards can still be added to this bout viewer
        /// </summary>
        /// <returns>Whether the maximum number of cards allowed in the bout has been reached</returns>
        public bool isFull()
        {
            bool full = false;

            // A logic structure which determines whether the maximum number of cards was reached
            if(this.cards.Count >= BoutViewer.MAXIMUM_CARDS_IN_BOUT || this.cards.Count / 2 >= this.cardCountAtBoutStart)
            {
                full = true;
            }
            return full;
        }
        /// <summary>
        /// Determines whether either an attacker or defender can place a card in the bout
        /// </summary>
        /// <param name="c">The card to put in the bout</param>
        /// <param name="isAttacker">Whether this is an attacking or defending move</param>
        /// <returns></returns>
        public bool canPlaceCard(Card c)
        {
            bool canPlace = false;
            if(DurakPage.isPlayerAttacking == DurakPage.isPlayerTurn)
            {
                //No cards in bout currently, attacker can play any card
                if(this.cards.Count == 0)
                {
                    canPlace = true;
                }
                else
                {
                    //There are cards in the bout currently, check if there
                    //is the passed card matches any of their ranks
                    foreach (Card boutCard in this.cards)
                    {
                        if (c.Rank == boutCard.Rank)
                        {
                            //A matching rank is found, the card can be played
                            canPlace = true;
                        }
                    }
                }
            }
            else
            {
                if (this.cards.Count != 0) //Defender is never able to go first
                {
                    //There are cards in the bout for the defender to defend against

                    //Get the last card played
                    Card lastCard = this.cards[this.cards.Count - 1];
                    c.FaceUp = true;
                    //Check if the passed card is of a matching suit and higher rank, trumps are handled slightly differently

                    if(c.Suit == lastCard.Suit)
                    {
                        if(c.Rank == Rank.Ace)
                        {
                            if(lastCard.Rank != Rank.Ace)
                            {
                                canPlace = true;
                            }
                        }
                        else if(lastCard.Rank != Rank.Ace && c.Rank > lastCard.Rank)
                        {
                            canPlace = true;
                        }
                    }
                    else if(c.Suit == Card.trump) //last card is not trump, but card to play is
                    {
                        canPlace = true;
                    }

                }
                
            }
            
            return canPlace;
        }

        /// <summary>
        /// Updates the cardboxes using the UpdateCardBoxes method and sets their positions
        /// </summary>
        public override void AdjustCards()
        {
            if(isChanged)
            {
                UpdateCardBoxes(false);
                
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    int cardYOffset = 0;
                    if (DurakPage.isPlayerAttacking)
                    {
                        cardYOffset = i % 2 == 0 ? 80 : -80;
                    }
                    else
                    {
                        cardYOffset = i % 2 == 0 ? -80 : 80;
                    }

                    double widthDivider = (2 + this.Controls.Count / 3);
                    int firstCardX = this.Size.Width / 2 - (this.Controls[0].Width * (int)Math.Floor((double)this.Controls.Count / 2)) / 2;
                    int nextCardX = firstCardX + this.Controls[0].Width * (int)Math.Floor((double)i / 2);
                    (this.Controls[i] as CardBox).FaceUp = true;
                    this.Controls[i].Location = new Point(nextCardX - this.Controls[0].Width / 2, this.Size.Height / 2 - this.Controls[i].Height / 2 + cardYOffset);
                    this.Controls[i].BringToFront();
                }

                isChanged = false;

            }
            
        }
    }
}
