/* PlayDurak.cs
 * Group 9 (Nathan Williams, Jonathan Hermans, Karence Ma, Qasim Iqbal)
 * Date: 27/4/18
 * Description: The form which all the games content will take place on
 */

using System.Collections.Generic;
using System.Windows.Forms;
using CardGame;
namespace Game
{
    public partial class PlayDurak : Form
    {

        /// <summary>
        /// An enum used to represent which game screen the player is currently looking at
        /// </summary>
        public enum Screen
        {
            MainMenu = 0,
            Instructions,
            Playing,
            PlayOptions,
            GameResults
        }

        static MainMenu menu;
        static pgPlayOptions playOptions;
        static InstructionsPage instructionPage;

        public PlayDurak()
        {
            InitializeComponent();

            //Instantiate screens/panels and add them to the form
            menu = new MainMenu();
            playOptions = new pgPlayOptions();
            instructionPage = new InstructionsPage();

            this.Controls.Add(menu);
            this.Controls.Add(playOptions);
            this.Controls.Add(instructionPage);

            menu.Visible = true;
            playOptions.Visible = false;
            instructionPage.Visible = false;

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
                case Screen.PlayOptions:
                    SetScreenVisible(this.Controls, playOptions);
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
