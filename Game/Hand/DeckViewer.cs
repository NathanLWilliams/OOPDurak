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

namespace Hand
{
    public partial class DeckViewer : UserControl
    {
        public DeckViewer()
        {
            InitializeComponent();
            
            this.panel1.ControlAdded += AdjustCards;
            this.panel1.ControlRemoved += AdjustCards;
        }
        public void AddCard()
        {
            this.panel1.Controls.Add(new CardBox());
            
        }
        public void AddCard(CardBox myCardBox)
        {
            this.panel1.Controls.Add(myCardBox);
        }
        public void RemoveCard(int index)
        {
            this.panel1.Controls.RemoveAt(index);
        }
        public void AdjustCards(object source, ControlEventArgs args)
        {
            for(int i = 0; i < this.panel1.Controls.Count; i++)
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
            }
        }
    }
}
