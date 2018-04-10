using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardBoxControl;
using CardGame;

namespace Game
{
    public partial class DeckViewer : Panel
    {
        Cards cards;
        Size standardCardSize = new Size(87, 141);

        public DeckViewer()
        {
            InitializeComponent();
            cards = new Cards();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(this.DeckViewer_DragEnter);
            this.DragDrop += new DragEventHandler(this.DeckViewer_DragDrop);
        }
        public DeckViewer(Deck deck, int numberOfCards) : this()
        {
            this.AddCards(deck, numberOfCards);
        }
        public void AddCards(Deck deck, int numberOfCards)
        {
            for (int i = 0; i < numberOfCards; i++)
            {
                Card card = deck.DrawCard();
                this.AddCard(card, false);
            }
            AdjustCards();
        }
        public void AddCard(Card card , bool adjust = true)
        {
            //this.panel1.Controls.Add(new CardBox(card));
            cards.Add(card);
            AdjustCards();
        }
        public void RemoveCard(int index)
        {
            cards.RemoveAt(index);
            AdjustCards();

        }
        public void RemoveCard(Card card)
        {
            cards.Remove(card);
            AdjustCards();
        }
        public Card TakeCard(int index)
        {
            Card temp = (Card)cards[index].Clone();
            this.RemoveCard(index);
            return temp;
        }
        public void UpdateCardBoxes()
        {
            this.Controls.Clear();

            foreach(Card c in cards)
            {
                CardBox cardBox = new CardBox(c, true);
                cardBox.Size = standardCardSize;
                this.Controls.Add(cardBox);
            }
            this.Controls[this.Controls.Count - 1].Name = "lastCardInView";
        }
        //public void AdjustCards(object source, EventArgs args)
        public void AdjustCards()
        {
            /*for(int i = 0; i < this.panel1.Controls.Count; i++)
            {
                (this.panel1.Controls[i] as CardBox).FaceUp = true;
                double widthDivider = (2 + this.panel1.Controls.Count/3);
                int farLeftCardX = this.Size.Width / 2 - (int)((i+1)/2) * (int)(this.panel1.Controls[0].Width / widthDivider);
                int farRightCardX = this.Size.Width / 2 + (int)((i+1)/2) * (int)(this.panel1.Controls[0].Width / widthDivider);

                if(this.panel1.Controls.Count % 2 == 0)
                {
                    farLeftCardX -= (int)(this.panel1.Controls[0].Width / widthDivider);
                    farRightCardX -= (int)(this.panel1.Controls[0].Width / widthDivider);
                }
                
                if (i % 2 == 0)
                {
                    this.panel1.Controls[i].Location = new Point(farLeftCardX - this.panel1.Controls[0].Width / 2, this.Size.Height / 2 - this.panel1.Controls[i].Height / 2);
                    
                }
                else
                {
                    this.panel1.Controls[i].Location = new Point(farRightCardX - this.panel1.Controls[0].Width / 2, this.Size.Height / 2 - this.panel1.Controls[i].Height / 2);
                    this.panel1.Controls[i].BringToFront();
                }
            }*/
            UpdateCardBoxes();
            for (int i = 0; i < this.Controls.Count; i++)
            {
                double widthDivider = (2 + this.Controls.Count / 3);
                int firstCardX = this.Size.Width/2 - (this.Controls.Count + 1) * (int)(this.Controls[0].Width / widthDivider) / 2;
                int nextCardX = firstCardX + (i + 1) * (int)(this.Controls[0].Width / widthDivider);

                (this.Controls[i] as CardBox).FaceUp = true;
                this.Controls[i].Location = new Point(nextCardX - this.Controls[0].Width / 2, this.Size.Height / 2 - this.Controls[i].Height / 2);
                this.Controls[i].BringToFront();
            }
        }
        public void DeckViewer_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetData(DataFormats.Text) != null)
                e.Effect = DragDropEffects.Move;
        }
        public void DeckViewer_DragDrop(object sender, DragEventArgs e)
        {
             
            if (e.Data.GetData(DataFormats.Text) != null)
            {
                //DeckViewer toPanel = sender as DeckViewer;
                //DeckViewer fromPanel = this;
                //if (fromPanel != null && toPanel != null)
                //{
                //    int cardHashCode = Convert.ToInt32(e.Data.GetData(DataFormats.Text).ToString());
                //    Card draggedCard = new Card(cardHashCode);
                //    var count = toPanel.Controls.Count;
                //    var count2 = fromPanel.Controls.Count;

                //    if (toPanel != fromPanel)
                //    {
                //        //fromPanel.RemoveCard() // how do we pass index to these cards
                //        fromPanel.RemoveCard();
                //        toPanel.AddCard(draggedCard);

                //    }
                //}
                if (e.Data.GetData(DataFormats.Text) != null)
                {
                    int cardHashCode = Convert.ToInt32(e.Data.GetData(DataFormats.Text).ToString());
                    Card draggedCard = new Card(cardHashCode);
                    this.AddCard(draggedCard);
                }

            }
        }
    }
}
