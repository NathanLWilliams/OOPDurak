using System.Collections.Generic;
using System.Windows.Forms;
using CardGame;
namespace Game
{
    public partial class PlayDurak : Form
    {

        public enum Screen
        {
            MainMenu = 0,
            Instructions,
            Statistics,
            Playing,
            PlayOptions,
            GameResults
        }

        static MainMenu menu;
        static pgPlayOptions playOptions;
        static StatisticsPage stats;
        //static DurakPage durakPage;
        static InstructionsPage instructionPage;
        static Win winPage;

        public PlayDurak()
        {
            InitializeComponent();

            //Instantiate screens/panels and add them to the form
            menu = new MainMenu();
            playOptions = new pgPlayOptions();
            stats = new StatisticsPage();
            //durakPage = new DurakPage(); //- removed it from here as we need its instance after play options page sets game options
            instructionPage = new InstructionsPage();
            winPage = new Win();


            this.Controls.Add(menu);
            this.Controls.Add(playOptions);
            this.Controls.Add(stats);
            //this.Controls.Add(durakPage);
            this.Controls.Add(instructionPage);
            this.Controls.Add(winPage);

            menu.Visible = true;
            playOptions.Visible = false;
            stats.Visible = false;
            //durakPage.Visible = false;
            instructionPage.Visible = false;
            winPage.Visible = false;

        }

        /// <summary>
        /// Used to change any information that is needed for a change in the screen, ex: Form size
        /// along with setting the related panel of controls to visible
        /// </summary>
        /// <param name="screen"></param>
        public void SetScreen(Screen screen)
        {
            switch(screen)
            {
                case Screen.MainMenu:
                    SetScreenVisible(this.Controls,menu);
                    this.AcceptButton = (Button)menu.Controls["start"];
                    this.CancelButton = (Button)menu.Controls["exit"];
                    break;
                case Screen.Instructions:
                    SetScreenVisible(this.Controls, instructionPage);
                    break;
                case Screen.Statistics:
                    SetScreenVisible(this.Controls, stats);
                    break;
                case Screen.Playing:
                   // SetScreenVisible(this.Controls,;
                    break;
                case Screen.PlayOptions:
                    SetScreenVisible(this.Controls, playOptions);
                    break;
                case Screen.GameResults:
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Makes every screen invisible except the screen that is not suppose to be
        /// </summary>
        /// <param name="passedPanel"></param>
        public static void SetScreenVisible(Control.ControlCollection panelCollection ,Panel passedPanel)
        {
            

            foreach (Control panelItem in panelCollection)
            {
                if (panelItem is Panel)
                {
                    if(panelItem.Name == passedPanel.Name)
                    {
                        panelItem.Visible = true;
                    }
                    else
                    {
                        panelItem.Visible = false;
                    }
                }
            }
        }
    }
}
