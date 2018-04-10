using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class MainMenu : Panel
    {
        static Size buttonSize = new Size(300, 80);
        static Font buttonFont = new Font("Arial", 24, FontStyle.Regular);
        static Color buttonColor = Color.LimeGreen;

        public MainMenu()
        {
            //Generate the big title
            Label lblTitle = new Label();
            lblTitle.Text = "Play Durak";
            lblTitle.Font = new Font("Arial", 64, FontStyle.Bold);
            lblTitle.ForeColor = Color.LimeGreen;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(350, 150);
            lblTitle.BackColor = Color.Transparent;
            this.Controls.Add(lblTitle);

            const int buttonStartY = 310;

            //Instantiate the controls
            Button start = new Button();
            start.Text = "Start";
            start.Size = buttonSize;
            start.Location = new Point(450, buttonStartY);
            start.Font = buttonFont;
            start.BackColor = buttonColor;
            start.FlatStyle = FlatStyle.Popup;
            start.Click += Start_Click;
            start.TabIndex = 1;
            start.Name = "start";
            this.Controls.Add(start);

            Button instructions = new Button();
            instructions.Text = "Instructions";
            instructions.Size = buttonSize;
            instructions.Location = new Point(450, buttonStartY + 25 + buttonSize.Height);
            instructions.Font = buttonFont;
            instructions.BackColor = buttonColor;
            instructions.FlatStyle = FlatStyle.Popup;
            instructions.Click += Instructions_Click;
            instructions.TabIndex = 2;
            this.Controls.Add(instructions);

            Button statistics = new Button();
            statistics.Text = "Statistics";
            statistics.Size = buttonSize;
            statistics.Location = new Point(450, buttonStartY + 50 + buttonSize.Height*2);
            statistics.Font = buttonFont;
            statistics.BackColor = buttonColor;
            statistics.FlatStyle = FlatStyle.Popup;
            statistics.Click += Statistics_Click;
            statistics.TabIndex = 3;
            this.Controls.Add(statistics);

            Button exit = new Button();
            exit.Text = "Exit";
            exit.Size = buttonSize;
            exit.Location = new Point(450, buttonStartY + 75 + buttonSize.Height*3);
            exit.Font = buttonFont;
            exit.BackColor = buttonColor;
            exit.FlatStyle = FlatStyle.Popup;
            exit.Click += Exit_Click;
            exit.TabIndex = 4;
            exit.Name = "exit";
            this.Controls.Add(exit);

            this.BackgroundImage = Properties.Resources.mainMenuCombinedBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Dock = DockStyle.Fill;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            if(this.Parent.Parent is Form)
                (this.Parent.Parent as Form).Close();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            //Goto play options
            if(this.Parent.Parent is Form)
                (this.Parent.Parent as PlayDurak).SetScreen(PlayDurak.Screen.PlayOptions);
        }
        private void Statistics_Click(object sender, EventArgs e)
        {
            //Goto statistics
            if (this.Parent.Parent is Form)
                (this.Parent.Parent as PlayDurak).SetScreen(PlayDurak.Screen.Statistics);
        }
        private void Instructions_Click(object sender, EventArgs e)
        {
            //Goto instructions
            if (this.Parent.Parent is Form)
                (this.Parent.Parent as PlayDurak).SetScreen(PlayDurak.Screen.Instructions);
        }

    }
}
