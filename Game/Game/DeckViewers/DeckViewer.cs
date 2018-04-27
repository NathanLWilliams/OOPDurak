/* DeckViewer.cs
 * Group 9 (Nathan Williams, Jonathan Hermans, Karence Ma, Qasim Iqbal)
 * Date: 27/4/18
 * Description: A class for the panel which is designed to hold and display a players cards
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
using Game;
using CardBoxControl;

namespace Game
{
    public partial class DeckViewer : Panel
    {
        protected Cards cards;
        Size standardCardSize = new Size(87, 141);
        bool IsEnemyView = false;
        protected bool isChanged = false;

        public DeckViewer(bool isEnemy = false)
        {
            IsEnemyView = isEnemy;
            InitializeComponent();
            cards = new Cards();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(this.DeckViewer_DragEnter);
            this.DragDrop += new DragEventHandler(this.DeckViewer_DragDrop);
        }
        public DeckViewer(Deck deck, int numberOfCards) : this()
        {
            this.DrawCards(deck, numberOfCards);
        }
        public DeckViewer(Deck deck, bool isEnemy = false)
        {
            IsEnemyView = isEnemy;
            InitializeComponent();
            cards = new Cards();
            this.AllowDrop = true;

            this.DragEnter += new DragEventHandler(this.DeckViewer_DragEnter);
            this.DragDrop += new DragEventHandler(this.DeckViewer_DragDrop);
            this.DrawCards(deck, deck.Count);
            
        }

        /// <summary>
        /// Resets the cards in the deck viewer
        /// </summary>
        public void Reset()
        {
            this.cards.Clear();
            this.Controls.Clear();
            isChanged = true;
        }

        /// <summary>
        /// Draws cards from a deck and adds them to the deck viewer
        /// </summary>
        /// <param name="deck">The deck to draw from</param>
        /// <param name="numberOfCards">The number of cards to draw</param>
        public void DrawCards(Deck deck, int numberOfCards)
        {

            for (int i = 0; i < numberOfCards; i++)
            {
                Card card = deck.DrawCard();
                this.AddCard(card);
            }
        }

        /// <summary>
        /// Draws cards from a cards object and adds them to the deck viewer
        /// </summary>
        /// <param name="cards">The cards object to draw from</param>
        public void DrawCards(Cards cards)
        {
            for(int i = cards.Count - 1; i >= 0; i--)
            {
                this.AddCard((Card)cards[i].Clone());
                cards.RemoveAt(i);
            }
        }

        /// <summary>
        /// Returns the cards in the deck viewer
        /// </summary>
        /// <returns></returns>
        public Cards GetCards()
        {
            return this.cards;
        }

        /// <summary>
        /// Adds a card to this deck viewer
        /// </summary>
        /// <param name="card"></param>
        public virtual void AddCard(Card card)
        {
            cards.Add(card);
            isChanged = true;
        }

        /// <summary>
        /// Removes a card from this deckviewer by index
        /// </summary>
        /// <param name="index">The index of the card to remove</param>
        public void RemoveCard(int index)
        {
            cards.RemoveAt(index);
            isChanged = true;
        }

        /// <summary>
        /// Removes a card from this deckviewer by reference
        /// </summary>
        /// <param name="card">The card to remove</param>
        public void RemoveCard(Card card)
        {
            cards.Remove(card);
            isChanged = true;
        }

        /// <summary>
        /// Takes a card from this deck viewer and returns it
        /// </summary>
        /// <param name="index">The index of the card</param>
        /// <returns>The card taken</returns>
        public Card TakeCard(int index)
        {
            Card temp = (Card)cards[index].Clone();
            this.RemoveCard(index);
            return temp;
        }

        /// <summary>
        /// Clears and recreates the card boxes to ensure they reflect the cards object
        /// </summary>
        /// <param name="willCardsPop">If the cards will pop up when moused over</param>
        public void UpdateCardBoxes(bool willCardsPop)
        {
            this.Controls.Clear();

            for(int i = 0; i < this.cards.Count; i++)
            {
                if (IsEnemyView == true)
                {
                    standardCardSize = new Size(42, 70);
                    CardBox cardBox = new CardBox(cards[i]);
                    cardBox.Size = standardCardSize;
                    this.Controls.Add(cardBox);
                }
                else
                {
                    CardBox cardBox = new CardBox(cards[i], willCardsPop);
                    cardBox.Size = standardCardSize;
                    this.Controls.Add(cardBox);
                }

            }

            if (this.Controls.Count > 0)
                this.Controls[this.Controls.Count - 1].Name = "lastCardInView";
        }

        /// <summary>
        /// Updates the cardboxes using the UpdateCardBoxes method and sets their positions
        /// </summary>
        public virtual void AdjustCards()
        {
            if(isChanged)
            {
                UpdateCardBoxes(true);
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    double widthDivider = (2 + this.Controls.Count / 6);
                    int firstCardX = this.Size.Width / 2 - (this.Controls.Count + 1) * (int)(this.Controls[0].Width / widthDivider) / 2;
                    int nextCardX = firstCardX + (i + 1) * (int)(this.Controls[0].Width / widthDivider);
                    if (IsEnemyView == true)
                    {
                        (this.Controls[i] as CardBox).FaceUp = false;
                    }
                    else
                    {
                        (this.Controls[i] as CardBox).FaceUp = true;
                    }

                    this.Controls[i].Location = new Point(nextCardX - this.Controls[0].Width / 2, this.Size.Height / 2 - this.Controls[i].Height / 2);
                    this.Controls[i].BringToFront();
                }
                isChanged = false;
            }
        }

        /// <summary>
        /// Flags that the cards in this deck viewer have changed
        /// </summary>
        public void SetChanged()
        {
            this.isChanged = true;
        }

        public virtual void DeckViewer_DragEnter(object sender, DragEventArgs e)
        {
            /*if (e.Data.GetData(typeof(CardBox)) != null)
            {
                CardBox draggedCard = (CardBox)e.Data.GetData(typeof(CardBox));

                if (draggedCard.Parent.GetType() == typeof(DeckPileViewer))
                    e.Effect = DragDropEffects.Move;


            }*/
        }
        public virtual void DeckViewer_DragDrop(object sender, DragEventArgs e)
        {
            //Commented out temporarily as the cards in a hands are auto refilled currently when a bout ends
            /*if (e.Data.GetData(typeof(CardBox)) != null)
            {

                System.Console.WriteLine("DragDrop");
                //int cardHashCode = Convert.ToInt32(e.Data.GetData(DataFormats.Text).ToString());
                //Card draggedCard = new Card(cardHashCode);
                CardBox draggedCard = (CardBox)e.Data.GetData(typeof(CardBox));

                if (draggedCard != null && draggedCard.Parent.GetType() == typeof(DeckPileViewer))
                {
                    DeckViewer fromPanel = draggedCard.Parent as DeckPileViewer;
                    DeckViewer toPanel = sender as DeckViewer;

                    if (toPanel != null && fromPanel != null)
                    {
                        if (toPanel != fromPanel && this.cards.Count < 6)
                        {
                            fromPanel.RemoveCard(draggedCard.Card);
                            toPanel.AddCard(draggedCard.Card);
                        }
                    }

                }
                //this.AddCard(draggedCard);
                //Card newCard = (Card)draggedCard.Card.Clone();
                //(draggedCard.Parent as DeckViewer).RemoveCard(draggedCard.Card);
                //this.AddCard(newCard);


            }*/
        }
    }
}
