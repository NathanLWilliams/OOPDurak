using CardBoxControl;
using CardGame;
using Game;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DeckViewerTester
{
    public class BoutViewer : DeckViewer
    {
        //TODO: Remove this. Tried to get the parent of BoutViewer (DurakPage) in order to get the isAttackerTurn variable there (so we don't need two of them),
        //yet for some reason I can't reference DurakPage with "(this.Parent as DurakPage).IsAttackerTurn"
        bool isAttackerTurn = true;
        public bool IsAttackerTurn
        {
            get { return isAttackerTurn; }
            set { isAttackerTurn = value; }
        }
        public BoutViewer() : base()
        {
        }
        public void AddDeck(Deck deck)
        {
            this.AddCards(deck, deck.Count);
        }
        public override void DeckViewer_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(CardBox)) != null && this.Controls.Count < 12)
            {
                CardBox draggedCard = (CardBox)e.Data.GetData(typeof(CardBox));
                if (draggedCard.Parent.GetType() == typeof(DeckViewer) && (string)draggedCard.Parent.Tag != "enemyDeck")
                    e.Effect = DragDropEffects.Move;
            }
        }
        public override void DeckViewer_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(CardBox)) != null && this.Controls.Count < 12)
            {

                System.Console.WriteLine("DragDrop");
                //int cardHashCode = Convert.ToInt32(e.Data.GetData(DataFormats.Text).ToString());
                //Card draggedCard = new Card(cardHashCode);
                CardBox draggedCard = (CardBox)e.Data.GetData(typeof(CardBox));

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
                                toPanel.AddCard(draggedCard.Card);
                            }
                        }
                    }

                }
                //this.AddCard(draggedCard);
                //Card newCard = (Card)draggedCard.Card.Clone();
                //(draggedCard.Parent as DeckViewer).RemoveCard(draggedCard.Card);
                //this.AddCard(newCard);


            }


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
            
            if(isAttackerTurn)
            {
                if(this.cards.Count == 0)
                {
                    canPlace = true;
                }
                else
                {
                    foreach (Card boutCard in this.cards)
                    {
                        if (c.Rank == boutCard.Rank)
                        {
                            canPlace = true;
                        }
                    }
                }
            }
            else
            {
                Card lastCard = this.cards[this.cards.Count - 1];
                
                //TODO: Confirm this is okay
                if ((c.Suit == lastCard.Suit && ((c.Rank > lastCard.Rank && lastCard.Rank != Rank.Ace) || c.Rank == Rank.Ace)) || (c.Suit == Card.trump && lastCard.Suit != Card.trump))
                {
                    canPlace = true;
                }
            }
            
            return canPlace;
        }
        public override void AdjustCards()
        {
            UpdateCardBoxes(false);
            for (int i = 0; i < this.Controls.Count; i++)
            {
                double widthDivider = (2 + this.Controls.Count / 3);
                int firstCardX = this.Size.Width / 2 - (this.Controls[0].Width * (int)Math.Floor((double)this.Controls.Count / 2))/2;
                int nextCardX = firstCardX + this.Controls[0].Width * (int)Math.Floor((double)i/2);
                int cardYOffset = i % 2 == 0 ? -80 : 80;

                (this.Controls[i] as CardBox).FaceUp = true;
                this.Controls[i].Location = new Point(nextCardX - this.Controls[0].Width / 2, this.Size.Height / 2 - this.Controls[i].Height / 2 + cardYOffset);
                this.Controls[i].BringToFront();
            }
        }
    }
}
