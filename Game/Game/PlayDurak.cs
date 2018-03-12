using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class PlayDurak : Form
    {
        //BUGS:

        //TODO: Maybe add some static font sizes or buttons sizes which are shared and consistent between each layout/state

        //Separate the different sets of controls/layouts into panels so we can easily loop through in code to set visible or invisible
        public static TableLayoutPanel mainMenuPanel;

        public enum GameState
        {
            MainMenu,
            Playing,
            PlayOptions,
            Instructions,
            GameResult
        }

        public PlayDurak()
        {
            InitializeComponent();
            GenerateMainMenu();
            SetState(GameState.MainMenu);
        }

        /// <summary>
        /// Sets the game's state, which changes the layout and can be used for decision making in code
        /// </summary>
        /// <param name="state">The state to set the game to</param>
        public void SetState(GameState state)
        {
            //Each case in this switch statement should set the state's related 
            //controls visible and changes any other properties required

            mainMenuPanel.Visible = false;

            switch(state)
            {
                case GameState.MainMenu:
                    mainMenuPanel.Visible = true;
                    this.Size = new Size(1200, 800);
                    break;
            }
        }

        /// <summary>
        /// Instantiate and setup the controls related to the main menu game state
        /// </summary>
        public void GenerateMainMenu()
        {
            mainMenuPanel = new TableLayoutPanel();
            mainMenuPanel.ColumnCount = 1;
            mainMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainMenuPanel.RowCount = 2;
            mainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            mainMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));

            Panel mainContent = new Panel();
            Panel statistics = new Panel();

            //Variables
            const int BUTTON_WIDTH = 300;
            const int BUTTON_HEIGHT = 80;
            const int BUTTON_VERTICAL_SPACING = 25; //The vertical spacing between each button in the menu
            const int BUTTON_HORIZONTAL_SPACING = 0; //The horizontal spacing between each button in the menu
            const int BUTTON_INITIAL_X = 450; //The x position of the first button in the menu
            const int BUTTON_INITIAL_Y = 375; //The y position of the first button in the menu

            string[] buttonText = new string[] { "Start", "Instructions", "Exit" };
            
            //Generate the big title
            Label lblTitle = new Label();
            lblTitle.Text = "Play Durak";
            lblTitle.Font = new Font("Arial", 64, FontStyle.Bold);
            lblTitle.Location = new Point(this.Width/2 - lblTitle.Width, 150);
            lblTitle.ForeColor = Color.LimeGreen;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            mainContent.Controls.Add(lblTitle);

            //Instantiate the controls
            mainContent.Controls.AddRange(GetButtonMenu(buttonText, 
                new Size(BUTTON_WIDTH, BUTTON_HEIGHT), 
                new Point(BUTTON_INITIAL_X, BUTTON_INITIAL_Y), 
                BUTTON_VERTICAL_SPACING, BUTTON_HORIZONTAL_SPACING,
                new Font("Arial", 24, FontStyle.Regular),
                Color.LimeGreen));
            mainContent.BackgroundImage = Properties.Resources.mainMenuCombinedBackground;
            mainContent.BackgroundImageLayout = ImageLayout.Stretch;
            mainContent.Dock = DockStyle.Fill;
            statistics.Dock = DockStyle.Fill;

            Label winsLabel = new Label();
            winsLabel.Text = "Wins: ";
            winsLabel.AutoSize = true;
            winsLabel.Location = new Point(10, 10);
            statistics.Controls.Add(winsLabel);

            mainMenuPanel.Controls.Add(statistics, 0, 0);
            mainMenuPanel.Controls.Add(mainContent, 0, 1);
            this.Controls.Add(mainMenuPanel);

        }

        /// <summary>
        /// Instantiates and returns a list of buttons organized in a simple menu-like format
        /// </summary>
        /// <param name="buttonText">A string array of each buttons text</param>
        /// <param name="buttonSize">The size of the buttons</param>
        /// <param name="buttonLocation">The location of the first button</param>
        /// <param name="verticalSpacing">The vertical spacing between each button</param>
        /// <param name="horizontalSpacing">The horizontal spacing between each button</param>
        /// <returns>An array of buttons</returns>
        public static Button[] GetButtonMenu(string[] buttonText, Size buttonSize, Point buttonLocation, int verticalSpacing=25, int horizontalSpacing=25, Font font = default(Font), Color backgroundColor = default(Color), FlatStyle style = FlatStyle.Popup)
        {
            Button[] menuOptions = new Button[buttonText.Length];
            for (int i = 0; i < buttonText.Length; i++)
            {
                Button btnTemp = new Button();
                btnTemp.Text = buttonText[i];
                btnTemp.BackColor = backgroundColor;
                btnTemp.FlatStyle = style;

                //Determine if either axis of spacing is used, and if so make sure to include the button width or height
                int width = horizontalSpacing == 0 ? 0 : buttonSize.Width;
                int height = verticalSpacing == 0 ? 0 : buttonSize.Height;

                //Set the position with spacing
                btnTemp.Location = new Point
                    (buttonLocation.X + (horizontalSpacing + width) * i, 
                    buttonLocation.Y + (verticalSpacing + height) * i);

                btnTemp.Font = font;

                btnTemp.Size = buttonSize;
                menuOptions[i] = btnTemp;
            }
            return menuOptions;
        }
    }
}
