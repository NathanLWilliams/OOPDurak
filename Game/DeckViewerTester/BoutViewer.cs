using CardBoxControl;
using CardGame;
using Game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckViewerTester
{
    public class BoutViewer : DeckViewer
    {
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
                if(draggedCard.Parent.GetType() == typeof(DeckViewer))
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
                    DeckViewer toPanel = sender as DeckViewer;

                    if (toPanel != null && fromPanel != null)
                    {
                        if (toPanel != fromPanel)
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


            }


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
