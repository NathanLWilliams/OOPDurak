using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class DurakPage : Panel
    {
        //Static Object properties
        private static System.Drawing.Size STANDARD_CARD_SIZE = new System.Drawing.Size(139, 211);


        // objects declaration
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Hand.DeckViewer deckViewer3;
        private Hand.DeckViewer deckViewer4;
        private Hand.DeckViewer deckViewer2;
        private Hand.DeckViewer deckViewer1;
        private Hand.DeckViewer deckViewer5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;

        /// <summary>
        /// Durak form
        /// </summary>
        public DurakPage()
        {

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DurakPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deckViewer3 = new Hand.DeckViewer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.deckViewer4 = new Hand.DeckViewer();
            this.panel6 = new System.Windows.Forms.Panel();
            this.deckViewer2 = new Hand.DeckViewer();
            this.panel7 = new System.Windows.Forms.Panel();
            this.deckViewer1 = new Hand.DeckViewer();
            this.panel8 = new System.Windows.Forms.Panel();
            this.deckViewer5 = new Hand.DeckViewer();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 56);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(564, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 85);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.deckViewer3);
            this.panel3.Location = new System.Drawing.Point(205, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 243);
            this.panel3.TabIndex = 6;
            // 
            // deckViewer3
            // 
            this.deckViewer3.BackColor = System.Drawing.Color.Lime;
            this.deckViewer3.Location = new System.Drawing.Point(0, 0);
            this.deckViewer3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deckViewer3.Name = "deckViewer3";
            this.deckViewer3.Size = new System.Drawing.Size(816, 241);
            this.deckViewer3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.deckViewer4);
            this.panel5.Location = new System.Drawing.Point(1054, 268);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(130, 243);
            this.panel5.TabIndex = 7;
            // 
            // deckViewer4
            // 
            this.deckViewer4.BackColor = System.Drawing.Color.Lime;
            this.deckViewer4.Location = new System.Drawing.Point(4, 2);
            this.deckViewer4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deckViewer4.Name = "deckViewer4";
            this.deckViewer4.Size = new System.Drawing.Size(124, 239);
            this.deckViewer4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.deckViewer2);
            this.panel6.Location = new System.Drawing.Point(-3, 268);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(181, 243);
            this.panel6.TabIndex = 8;
            // 
            // deckViewer2
            // 
            this.deckViewer2.BackColor = System.Drawing.Color.Lime;
            this.deckViewer2.Location = new System.Drawing.Point(2, 2);
            this.deckViewer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deckViewer2.Name = "deckViewer2";
            this.deckViewer2.Size = new System.Drawing.Size(177, 239);
            this.deckViewer2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.deckViewer1);
            this.panel7.Location = new System.Drawing.Point(-3, 535);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1187, 133);
            this.panel7.TabIndex = 7;
            // 
            // deckViewer1
            // 
            this.deckViewer1.BackColor = System.Drawing.Color.Lime;
            this.deckViewer1.Location = new System.Drawing.Point(0, 2);
            this.deckViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deckViewer1.Name = "deckViewer1";
            this.deckViewer1.Size = new System.Drawing.Size(1185, 222);
            this.deckViewer1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.deckViewer5);
            this.panel8.Location = new System.Drawing.Point(3, 88);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(137, 47);
            this.panel8.TabIndex = 7;
            // 
            // deckViewer5
            // 
            this.deckViewer5.BackColor = System.Drawing.Color.Lime;
            this.deckViewer5.Location = new System.Drawing.Point(2, 0);
            this.deckViewer5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deckViewer5.Name = "deckViewer5";
            this.deckViewer5.Size = new System.Drawing.Size(133, 45);
            this.deckViewer5.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.pictureBox2);
            this.panel9.Controls.Add(this.panel8);
            this.panel9.Location = new System.Drawing.Point(540, 106);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(143, 138);
            this.panel9.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(21, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 85);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(762, 32);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(61, 50);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(862, 32);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 50);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // DurakDeck
            // 

            this.BackgroundImage = Properties.Resources.mainMenuBackgroundCenter;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DurakDeck";
            this.Text = "DurakDeck";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

            // ready game stuff
            ReadyGameDecks();

        }

        private void ReadyGameDecks()
        {
            CardBoxControl.CardBox cardbox = new CardBoxControl.CardBox();
            cardbox.Size = STANDARD_CARD_SIZE;
            this.deckViewer1.AddCard(cardbox);
            //deckViewer2.AddCard();
        }

    }

   
}
