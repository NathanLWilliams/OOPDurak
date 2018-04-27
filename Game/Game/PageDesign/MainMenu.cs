/* MainMenu.cs
 * Group 9 (Nathan Williams, Jonathan Hermans, Karence Ma, Qasim Iqbal)
 * Date: 26/4/18
 * Description: Main menu controls are set here.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    // MainMenu inherits from the panel class (windows)
    public class MainMenu : Panel
    {
        static Size buttonSize = new Size(300, 80);
        static Font buttonFont = new Font("Arial", 24, FontStyle.Regular);
        static Color buttonColor = Color.LimeGreen;

        /// <summary>
        /// Main menu setup
        /// </summary>
        public MainMenu()
        {
            //Generate the big title
            Label lblTitle = new Label();
            lblTitle.Text = "Play Durak";
            lblTitle.Font = new Font("Arial", 64, FontStyle.Bold);
            lblTitle.ForeColor = Color.LimeGreen;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(-200, 150);
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblTitle);

            const int buttonStartY = 370;
            const int buttonX = -50;

            //Instantiate the controls
            Button start = new Button();
            start.Text = "Start";
            start.Size = buttonSize;
            start.Location = new Point(buttonX, buttonStartY);
            start.Font = buttonFont;
            start.BackColor = buttonColor;
            start.FlatStyle = FlatStyle.Popup;
            start.Click += Start_Click;
            start.TabIndex = 1;
            //start.Name = "start";
            start.AutoSize = true;
            start.TextAlign = ContentAlignment.MiddleCenter;
            start.Anchor = AnchorStyles.Top;
            this.Controls.Add(start);

            Button instructions = new Button();
            instructions.Text = "Instructions";
            instructions.Size = buttonSize;
            instructions.Location = new Point(buttonX, buttonStartY + 25 + buttonSize.Height);
            instructions.Font = buttonFont;
            instructions.BackColor = buttonColor;
            instructions.FlatStyle = FlatStyle.Popup;
            instructions.Click += Instructions_Click;
            instructions.TabIndex = 2;
            instructions.AutoSize = true;
            instructions.TextAlign = ContentAlignment.MiddleCenter;
            instructions.Anchor = AnchorStyles.Top;
            this.Controls.Add(instructions);

            Button statistics = new Button();
            statistics.Text = "Statistics";
            statistics.Size = buttonSize;
            statistics.Location = new Point(buttonX, buttonStartY + 50 + buttonSize.Height*2);
            statistics.Font = buttonFont;
            statistics.BackColor = buttonColor;
            statistics.FlatStyle = FlatStyle.Popup;
            statistics.Click += Statistics_Click;
            statistics.TabIndex = 3;
            statistics.AutoSize = true;
            statistics.TextAlign = ContentAlignment.MiddleCenter;
            statistics.Anchor = AnchorStyles.Top;
            this.Controls.Add(statistics);

            Button exit = new Button();
            exit.Text = "Exit";
            exit.Size = buttonSize;
            exit.Location = new Point(buttonX, buttonStartY + 75 + buttonSize.Height*3);
            exit.Font = buttonFont;
            exit.BackColor = buttonColor;
            exit.FlatStyle = FlatStyle.Popup;
            exit.Click += Exit_Click;
            exit.TabIndex = 4;
            exit.Name = "exit";
            exit.AutoSize = true;
            exit.TextAlign = ContentAlignment.MiddleCenter;
            exit.Anchor = AnchorStyles.Top;
            this.Controls.Add(exit);

            this.Name = "pnlMainMenu";
            this.BackgroundImage = Properties.Resources.mainMenuCombinedBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Click event handler for the exit button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            if(this.Parent is Form)
                System.Windows.Forms.Application.Exit();
        }

        /// <summary>
        /// Click event handler for the start button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {
            //Goto play options
            if(this.Parent is Form)
                (this.Parent as PlayDurak).SetScreen(PlayDurak.Screen.PlayOptions);
        }

        /// <summary>
        /// Click event handler for the statistics button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Statistics_Click(object sender, EventArgs e)
        {
            //Goto statistics
            if (this.Parent is Form)
                (this.Parent as PlayDurak).SetScreen(PlayDurak.Screen.Statistics);
        }

        /// <summary>
        /// Click event handler for the instructions button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Instructions_Click(object sender, EventArgs e)
        {
            //Goto instructions
            if (this.Parent is Form)
                (this.Parent as PlayDurak).SetScreen(PlayDurak.Screen.Instructions);
        }

    }
}
