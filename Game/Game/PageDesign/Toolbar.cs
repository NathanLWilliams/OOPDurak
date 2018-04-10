using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class Toolbar : Panel
    {
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;

        public Toolbar()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += PictureBox1_Click;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(75, 5);
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += PictureBox2_Click;
            // 
            // panel1
            // 
            this.BackColor = Color.Black;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Dock = DockStyle.Fill;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (this.Parent.Parent is PlayDurak)
            {
                switch(PlayDurak.currentScreen)
                {
                    case PlayDurak.Screen.Playing:
                        (this.Parent.Parent as PlayDurak).SetScreen(PlayDurak.Screen.PlayOptions);
                        break;
                    case PlayDurak.Screen.GameResults:
                        (this.Parent.Parent as PlayDurak).SetScreen(PlayDurak.Screen.MainMenu);
                        break;
                    case PlayDurak.Screen.Instructions:
                        (this.Parent.Parent as PlayDurak).SetScreen(PlayDurak.Screen.MainMenu);
                        break;
                    case PlayDurak.Screen.PlayOptions:
                        (this.Parent.Parent as PlayDurak).SetScreen(PlayDurak.Screen.MainMenu);
                        break;
                    case PlayDurak.Screen.Statistics:
                        (this.Parent.Parent as PlayDurak).SetScreen(PlayDurak.Screen.MainMenu);
                        break;
                }
            }
        }
    }
}
