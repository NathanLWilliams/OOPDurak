﻿using System.Windows.Forms;

namespace Game
{
    public partial class PlayDurak : Form
    {
        //BUGS:

        //TODO: Maybe add some static font sizes or buttons sizes which are shared and consistent between each layout/state

        //Separate the different sets of controls/layouts into panels so we can easily loop through in code to set visible or invisible

        public enum Screen
        {
            MainMenu = 0,
            Instructions,
            Statistics,
            Playing,
            PlayOptions,
            GameResults
        }

        public static Screen currentScreen = Screen.MainMenu;

        static MainMenu menu;
        static pgPlayOptions playOptions;
        static StatisticsPage stats;
        static DurakPage durakPage;
        static InstructionsPage instructionsPage;
        static Win winPage;

        public PlayDurak()
        {
            InitializeComponent();

            //Instantiate screens/panels and add them to the form
            menu = new MainMenu();
            playOptions = new pgPlayOptions();
            stats = new StatisticsPage();
            durakPage = new DurakPage();
            instructionsPage = new InstructionsPage();
            winPage = new Win();

            this.tableLayoutPanel1.Controls.Add(menu);
            this.tableLayoutPanel1.Controls.Add(playOptions);
            this.tableLayoutPanel1.Controls.Add(stats);
            this.tableLayoutPanel1.Controls.Add(durakPage);
            this.tableLayoutPanel1.Controls.Add(instructionsPage);
            this.tableLayoutPanel1.Controls.Add(winPage);

            this.tableLayoutPanel1.SetRow(menu, 1);
            this.tableLayoutPanel1.SetRow(playOptions, 1);
            this.tableLayoutPanel1.SetRow(stats, 1);
            this.tableLayoutPanel1.SetRow(durakPage, 1);
            this.tableLayoutPanel1.SetRow(instructionsPage, 1);
            this.tableLayoutPanel1.SetRow(winPage, 1);

            menu.Visible = false;
            playOptions.Visible = false;
            stats.Visible = false;
            durakPage.Visible = false;
            instructionsPage.Visible = false;
            winPage.Visible = false;

            SetScreen(Screen.MainMenu);
            //this.deckViewer1.AddCards(new CardGame.Deck(CardGame.Deck.Size.Small), 5);
        }

        /// <summary>
        /// Used to change any information that is needed for a change in the screen, ex: Form size
        /// along with setting the related panel of controls to visible
        /// </summary>
        /// <param name="screen"></param>
        public void SetScreen(Screen screen)
        {
            menu.Visible = false;
            playOptions.Visible = false;
            stats.Visible = false;
            durakPage.Visible = false;
            instructionsPage.Visible = false;
            winPage.Visible = false;
            
            switch (screen)
            {
                case Screen.MainMenu:
                    menu.Visible = true;
                    this.AcceptButton = (Button)menu.Controls["start"];
                    this.CancelButton = (Button)menu.Controls["exit"];
                    break;
                case Screen.Instructions:
                    menu.Visible = false;
                    instructionsPage.Visible = true;
                    break;
                case Screen.Statistics:
                    menu.Visible = false;
                    stats.Visible = true;
                    break;
                case Screen.Playing:
                    playOptions.Visible = false;
                    durakPage.Visible = true;
                    break;
                case Screen.PlayOptions:
                    menu.Visible = false;
                    playOptions.Visible = true;
                    break;
                case Screen.GameResults:
                    durakPage.Visible = false;
                    winPage.Visible = false;
                    break;
                default:
                    break;
            }
            PlayDurak.currentScreen = screen;
        }
    }
}
