using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardGame;
using CardBoxControl;
using System.Drawing;

namespace Game
{
    public class DurakPage : Panel
    {
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private DeckViewer deckViewer4;
        private DeckViewer deckViewer3;
        private DeckViewer deckViewer2;
        private DeckViewer deckViewer1;

        //private CardBox dragCard;

        private const int POP = 25;

        /// <summary>
        /// Durak form
        /// </summary>
        public DurakPage()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DurakPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.deckViewer3 = new DeckViewer();
            this.deckViewer2 = new DeckViewer();
            this.deckViewer1 = new DeckViewer();
            this.deckViewer4 = new DeckViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 28);
            this.pictureBox1.Name = "pbGameMenu";
            this.pictureBox1.Size = new System.Drawing.Size(88, 88);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Image = Properties.Resources.menu_lime_t;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.BackColor = Color.Transparent;

            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(-3, 667);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 95);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(862, 32);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 50);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(762, 32);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(61, 50);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(564, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.BackColor = System.Drawing.Color.AliceBlue;

            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.deckViewer4);
            this.panel9.Controls.Add(this.pictureBox2);
            this.panel9.Location = new System.Drawing.Point(467, 28);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(292, 160);
            this.panel9.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(97, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // deckViewer3
            // 
            this.deckViewer3.BackColor = System.Drawing.Color.Lime;
            this.deckViewer3.Location = new System.Drawing.Point(215, 211);
            this.deckViewer3.Margin = new System.Windows.Forms.Padding(2);
            this.deckViewer3.Name = "deckViewer3";
            this.deckViewer3.Size = new System.Drawing.Size(967, 287);
            this.deckViewer3.TabIndex = 9;
            // 
            // deckViewer2
            // 
            this.deckViewer2.BackColor = System.Drawing.Color.Lime;
            this.deckViewer2.Location = new System.Drawing.Point(11, 211);
            this.deckViewer2.Margin = new System.Windows.Forms.Padding(2);
            this.deckViewer2.Name = "deckViewer2";
            this.deckViewer2.Size = new System.Drawing.Size(200, 287);
            this.deckViewer2.TabIndex = 10;
            // 
            // deckViewer1
            // 
            this.deckViewer1.BackColor = System.Drawing.Color.Lime;
            this.deckViewer1.Location = new System.Drawing.Point(11, 502);
            this.deckViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.deckViewer1.Name = "deckViewer1";
            this.deckViewer1.Size = new System.Drawing.Size(1171, 167);
            this.deckViewer1.TabIndex = 11;
            this.deckViewer1.AddCards(new Deck(Deck.Size.Small),5);
            // 
            // deckViewer4
            // 
            this.deckViewer4.BackColor = System.Drawing.Color.Lime;
            this.deckViewer4.Location = new System.Drawing.Point(0, 92);
            this.deckViewer4.Margin = new System.Windows.Forms.Padding(2);
            this.deckViewer4.Name = "deckViewer4";
            this.deckViewer4.Size = new System.Drawing.Size(292, 66);
            this.deckViewer4.TabIndex = 10;
            // 
            // DurakDeck
            // 
            this.BackgroundImage = Properties.Resources.mainMenuBackgroundCenter;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.deckViewer1);
            this.Controls.Add(this.deckViewer2);
            this.Controls.Add(this.deckViewer3);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DurakDeck";
            this.Text = "DurakDeck";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);


        }

        //    private Control activeControl;
        //    private Point previousLocation;
        //    private void DragCard_MouseDown(object sender, MouseEventArgs e)
        //    {
        //        dragCard = sender as CardBox;
        //        if (dragCard != null)
        //        {
        //            DoDragDrop(dragCard, DragDropEffects.Move);
        //        }
        //        activeControl = sender as Control;
        //        previousLocation = e.Location;
        //        Cursor = Cursors.Hand;
        //    }


            //        RealignCards(deckViewer2);
            //        //this.deckViewer1.Controls.Add(cardBoxList);  //(new Deck(Deck.Size.Small), 5);

            //        //    add card to right place
            //        deckViewer3.AllowDrop = true;
            //        deckViewer2.AllowDrop = true;

            //        deckViewer3.DragEnter += DeckViewer3_DragEnter;
            //        deckViewer3.DragDrop += DeckViewer3_DragDrop;
            //    }

            //    private void DragCard_Click(object sender, EventArgs e)
            //    {
            //        CardBox aCardBox = sender as CardBox;
            //        if (aCardBox.Parent == deckViewer3)
            //        {
            //            deckViewer3.Controls.Remove(aCardBox);
            //            deckViewer2.Controls.Add(aCardBox);
            //        }

            //    }

            //    private void DeckViewer3_DragDrop(object sender, DragEventArgs e)
            //    {
            //        if (dragCard != null)
            //        {
            //            Panel thisPanel = sender as Panel;

            //            Panel fromPanel = dragCard.Parent as Panel;
            //            if (thisPanel != null && fromPanel != null)
            //            {
            //                if (thisPanel != fromPanel)
            //                {
            //                    thisPanel.Controls.Add(dragCard);
            //                    fromPanel.Controls.Remove(dragCard);
            //                }
            //                foreach (CardBox cardbox in thisPanel.Controls)
            //                {
            //                    cardbox.FaceUp = true;
            //                }
            //                RealignCards(thisPanel);
            //                RealignCards(fromPanel);


            //            }
            //        }
            //    }

            //    private void DeckViewer3_DragEnter(object sender, DragEventArgs e)
            //    {
            //        e.Effect = DragDropEffects.Move;
            //    }


            //    private void DragCard_DragDrop(object sender, DragEventArgs e)
            //    {
            //        CardBox aCardBox = sender as CardBox;
            //        if (aCardBox != null)
            //        {
            //            DeckViewer3_DragDrop(aCardBox.Parent, e);
            //        }
            //    }

            //    private void DragCard_DragEnter(object sender, DragEventArgs e)
            //    {
            //        CardBox aCardBox = sender as CardBox;
            //        if (aCardBox != null)
            //        {
            //            DeckViewer3_DragEnter(aCardBox.Parent, e);
            //        }
            //    }

            //    /// <summary>
            //    /// Repositions the cards in a panel so that they are evenly distributed
            //    //in the area available.
            //    /// </summary>
            //    /// <param name="panelHand"></param>
            //    private void RealignCards(Panel panelHand)
            //    {
            //        // Determine the number of cards/controls in the panel.
            //        int myCount = panelHand.Controls.Count;
            //        // If there are any cards in the panel
            //        if (myCount > 0)
            //        {
            //            // Determine how wide one card/control is.
            //            int cardWidth = panelHand.Controls[0].Width;
            //            // Determine where the lefthand edge of a card/ control placed
            //            // in the middle of the panel should be
            //            int startPoint = (panelHand.Width - cardWidth) / 2;
            //            // An offset for the remaining cards
            //            int offset = 0;

            //            // If there are more than one cards/controls in the panel
            //            if (myCount > 1)
            //            {
            //                // Determine what the offset should be for each card based onthe
            //                // space available and the number of card/controls
            //                offset = (panelHand.Width - cardWidth - 2 * POP) / (myCount - 1);
            //                // If the offset is bigger than the card/control width, i.e.there is lots of room,
            //                // set the offset to the card width. The cards/controls willnot overlap at all.
            //                if (offset > cardWidth)
            //                    offset = cardWidth;
            //                // Determine width of all the cards/controls
            //                int allCardsWidth = (myCount - 1) * offset + cardWidth;
            //                // Set the start point to where the lefthand edge of the "first" card should be.
            //                startPoint = (panelHand.Width - allCardsWidth) / 2;
            //            }
            //            // Aligning the cards: Note that I align them in reserve order from how they
            //            // are stored in the controls collection. This is so that cardson the left
            //            // appear underneath cards to the right. This allows the user to see the rank
            //            // and suit more easily.
            //            // Align the "first" card (which is the last control in the collection) 
            //            panelHand.Controls[myCount - 1].Top = POP;
            //            System.Diagnostics.Debug.Write(panelHand.Controls[myCount - 1].Top.ToString() + "\n");
            //            panelHand.Controls[myCount - 1].Left = startPoint;
            //            // for each of the remaining controls, in reverse order.
            //            for (int index = myCount - 2; index >= 0; index--)
            //            {
            //                // Align the current card
            //                panelHand.Controls[index].Top = POP;
            //                panelHand.Controls[index].Left = panelHand.Controls[index +
            //                1].Left + offset;
            //            }
            //        }
            //    }
            //}
        }
}




