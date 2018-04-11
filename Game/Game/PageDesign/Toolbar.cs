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
        private PictureBox backButton;
        private PictureBox settingsButton;

        public Toolbar()
        {
            this.backButton = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();

            // 
            // backButton
            // 
            //Found here: http://www.free-icons-download.net/green-back-button-icon-65921/
            this.backButton.Image = Properties.Resources.goback;
            this.backButton.SizeMode = PictureBoxSizeMode.StretchImage;

            this.backButton.Location = new System.Drawing.Point(10, 5);
            this.backButton.Size = new System.Drawing.Size(53, 50);
            this.backButton.TabIndex = 0;
            this.backButton.TabStop = false;
            this.backButton.Click += Back_Click;
            // 
            // settingsButton
            // 
            //Found here: https://www.freeiconspng.com/img/19352
            this.settingsButton.BackColor = Color.LightGreen;
            this.settingsButton.Image = Properties.Resources.menu;
            this.settingsButton.SizeMode = PictureBoxSizeMode.StretchImage;
            this.settingsButton.Location = new System.Drawing.Point(75, 5);
            this.settingsButton.Size = new System.Drawing.Size(53, 50);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.TabStop = false;
            this.settingsButton.Click += Settings_Click;
            this.settingsButton.Visible = false;

            this.BackColor = Color.Goldenrod;
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.backButton);
            this.Dock = DockStyle.Fill;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            
        }

        private void Back_Click(object sender, EventArgs e)
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
