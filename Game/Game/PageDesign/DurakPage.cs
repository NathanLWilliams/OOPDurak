using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardGame;
using CardBoxControl;

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
        private Panel deckViewer3;
        private Panel deckViewer2;
        private DeckViewer deckViewer1;

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
            this.deckViewer3 = new Panel();
            this.deckViewer2 = new Panel();
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
            //this.pictureBox3.Click += PictureBox3_Click;
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

        //private void PictureBox3_Click(object sender, EventArgs e)
        //{
        //    //CardBox aCardBox = new CardBox(new Card());
        //    // add card to right place
        //    //deckViewer3.AllowDrop = true;
        //    //deckViewer2.AllowDrop = true;

        //    //deckViewer3.DragEnter += DeckViewer3_DragEnter;
        //    //deckViewer3.DragDrop += DeckViewer3_DragDrop;
        //}

        /*private void DragCard_Click(object sender, EventArgs e)
        {
            CardBox aCardBox = sender as CardBox;
            if(aCardBox.Parent == deckViewer3)
            {
                deckViewer3.Controls.Remove(aCardBox);
                deckViewer2.Controls.Add(aCardBox);
            }
        }*/

        /*private void DeckViewer3_DragDrop(object sender, DragEventArgs e)
        {
            if (dragCard != null)
            {
                Panel thisPanel = sender as Panel;
                Panel fromPanel = dragCard.Parent as Panel;
                if(thisPanel !=null && fromPanel !=null)
                {
                    if (thisPanel != fromPanel)
                    {
                        fromPanel.Controls.Remove(dragCard);
                        thisPanel.Controls.Add(dragCard);

                    }
                }
            }
        }*/

        /*private void DeckViewer3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }


        private void DragCard_DragDrop(object sender, DragEventArgs e)
        {
            CardBox aCardBox = sender as CardBox;
            if (aCardBox != null)
            {
                DeckViewer3_DragDrop(aCardBox.Parent, e);
            }
        }

        private void DragCard_DragEnter(object sender, DragEventArgs e)
        {
            CardBox aCardBox = sender as CardBox;
            if(aCardBox !=null)
            {
                DeckViewer3_DragEnter(aCardBox.Parent, e);
            }
        }

        private void DragCard_MouseDown(object sender, MouseEventArgs e)
        {
            dragCard = sender as CardBox;
            if (dragCard !=null)
            {
                DoDragDrop(dragCard, DragDropEffects.Move);
            }
        }*/


      

    }


}
