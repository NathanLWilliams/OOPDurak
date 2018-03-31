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
        static StatisticsPage statsPage; 

        public PlayDurak()
        {
            InitializeComponent();

            //Instantiate screens/panels and add them to the form
            menu = new MainMenu();
            playOptions = new pgPlayOptions();
            statsPage = new StatisticsPage();
            this.Controls.Add(menu);
            this.Controls.Add(statsPage);

            this.Controls.Add(playOptions);
            menu.Visible = false;
            statsPage.Visible = true;
            //playOptions.Visible = true;
           // SetScreen(Screen.Statistics);
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
                    menu.Visible = true;
                    this.AcceptButton = (Button)menu.Controls["start"];
                    this.CancelButton = (Button)menu.Controls["exit"];
                    break;
                case Screen.Instructions:
                    break;
                case Screen.Statistics:
                    playOptions.Visible = true;
                    break;
                case Screen.Playing:
                    break;
                case Screen.PlayOptions:
                    break;
                case Screen.GameResults:
                    break;
                default:
                    break;
            }
        }

    }
}
