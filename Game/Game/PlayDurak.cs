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
        public static StatisticsPage page;

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
            page = new StatisticsPage();
            page.InitializeComponent();
            this.Controls.Add(page);
            page.Visible = true;

        }

    }

}
