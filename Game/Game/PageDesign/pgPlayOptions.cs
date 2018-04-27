/* pgPlayOptions.cs
 * Group 9 (Nathan Williams, Jonathan Hermans, Karence Ma, Qasim Iqbal)
 * Date: 27/4/18
 * Description: A class for the panel which allows the player to select options for the durak game
 */

using CardGame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{

    public class pgPlayOptions : Panel
    {
        private DurakPage durakPage;

        private PictureBox pbBackScreen;
        private Label lblTitle;
        private PictureBox pbSmallDeck;
        private Label lblPromptDeckSize;
        private Label lblPromptGameMode;
        private GroupBox gbGameMode;
        private Label lblOtherOptions;
        private PictureBox pbMediumDeck;
        private PictureBox pbLargeDeck;
        private RadioButton rdNormalMode;
        private RadioButton rdNewbieMode;
        private Button btPlay;
        private CheckBox checkBox1;

        public pgPlayOptions()
        {
            //changeBorderStyle();
            this.pbBackScreen = new PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbSmallDeck = new System.Windows.Forms.PictureBox();
            this.lblPromptDeckSize = new System.Windows.Forms.Label();
            this.lblPromptGameMode = new System.Windows.Forms.Label();
            this.gbGameMode = new System.Windows.Forms.GroupBox();
            this.lblOtherOptions = new System.Windows.Forms.Label();
            this.pbMediumDeck = new System.Windows.Forms.PictureBox();
            this.pbLargeDeck = new System.Windows.Forms.PictureBox();
            this.rdNewbieMode = new System.Windows.Forms.RadioButton();
            this.rdNormalMode = new System.Windows.Forms.RadioButton();
            this.btPlay = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmallDeck)).BeginInit();
            this.gbGameMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMediumDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLargeDeck)).BeginInit();
            this.SuspendLayout();
            //
            // BackScreenPictureBox
            //
            this.pbBackScreen.BackColor = System.Drawing.Color.Transparent;
            this.pbBackScreen.Image = Properties.Resources.goback;
            this.pbBackScreen.Location = new System.Drawing.Point(35,40);
            this.pbBackScreen.Name = "pbBackScreen";
            this.pbBackScreen.Size = new System.Drawing.Size(88, 83);
            this.pbBackScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackScreen.TabIndex = 4;
            this.pbBackScreen.TabStop = false;
            this.pbBackScreen.Click += PbBackScreen_Click;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1160, 101);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Play Options";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.BackColor = Color.Transparent;

            // 
            // pbSmallDeck
            // 
            this.pbSmallDeck.Location = new System.Drawing.Point(226, 193);
            this.pbSmallDeck.Name = "pbSmallDeck";
            this.pbSmallDeck.Size = new System.Drawing.Size(168, 168);
            this.pbSmallDeck.TabIndex = 1;
            this.pbSmallDeck.TabStop = false;
            this.pbSmallDeck.Image = Properties.Resources.small_deck;
            this.pbSmallDeck.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbSmallDeck.Click += PbDeckSize_Click;
            this.pbSmallDeck.Tag = Deck.Size.Small;
            // 
            // lblPromptDeckSize
            // 
            this.lblPromptDeckSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromptDeckSize.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblPromptDeckSize.Location = new System.Drawing.Point(12, 146);
            this.lblPromptDeckSize.Name = "lblPromptDeckSize";
            this.lblPromptDeckSize.Size = new System.Drawing.Size(1160, 32);
            this.lblPromptDeckSize.TabIndex = 4;
            this.lblPromptDeckSize.Text = "Select a deck size";
            this.lblPromptDeckSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPromptDeckSize.BackColor = Color.Transparent;

            // 
            // lblPromptGameMode
            // 
            this.lblPromptGameMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromptGameMode.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblPromptGameMode.Location = new System.Drawing.Point(12, 391);
            this.lblPromptGameMode.Name = "lblPromptGameMode";
            this.lblPromptGameMode.Size = new System.Drawing.Size(1160, 32);
            this.lblPromptGameMode.TabIndex = 5;
            this.lblPromptGameMode.Text = "Select Game Mode";
            this.lblPromptGameMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPromptGameMode.BackColor = Color.Transparent;

            // 
            // gbGameMode
            // 
            this.gbGameMode.Controls.Add(this.rdNormalMode);
            this.gbGameMode.Controls.Add(this.rdNewbieMode);
            this.gbGameMode.Location = new System.Drawing.Point(226, 439);
            this.gbGameMode.Name = "gbGameMode";
            this.gbGameMode.Size = new System.Drawing.Size(674, 55);
            this.gbGameMode.TabIndex = 6;
            this.gbGameMode.TabStop = false;
            this.gbGameMode.Text = "Game Mode";
            this.gbGameMode.BackColor = Color.LimeGreen;
            // 
            // lblOtherOptions
            // 
            this.lblOtherOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherOptions.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblOtherOptions.Location = new System.Drawing.Point(12, 519);
            this.lblOtherOptions.Name = "lblOtherOptions";
            this.lblOtherOptions.Size = new System.Drawing.Size(1160, 32);
            this.lblOtherOptions.TabIndex = 7;
            this.lblOtherOptions.Text = "Other options";
            this.lblOtherOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOtherOptions.BackColor = Color.Transparent;
            // 
            // pbMediumDeck
            // 
            this.pbMediumDeck.Location = new System.Drawing.Point(490, 193);
            this.pbMediumDeck.Name = "pbMediumDeck";
            this.pbMediumDeck.Size = new System.Drawing.Size(168, 168);
            this.pbMediumDeck.TabIndex = 8;
            this.pbMediumDeck.TabStop = false;
            this.pbMediumDeck.Image = Properties.Resources.medium_deck;
            this.pbMediumDeck.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbMediumDeck.Click += PbDeckSize_Click;
            this.pbMediumDeck.Tag = Deck.Size.Medium;

            // 
            // pbLargeDeck
            // 
            this.pbLargeDeck.Location = new System.Drawing.Point(732, 193);
            this.pbLargeDeck.Name = "pbLargeDeck";
            this.pbLargeDeck.Size = new System.Drawing.Size(168, 168);
            this.pbLargeDeck.TabIndex = 9;
            this.pbLargeDeck.TabStop = false;
            this.pbLargeDeck.Image = Properties.Resources.large_deck;
            this.pbLargeDeck.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbLargeDeck.Click += PbDeckSize_Click;
            this.pbLargeDeck.Tag = Deck.Size.Large;

            // 
            // rdNewbieMode
            // 
            this.rdNewbieMode.AutoSize = true;
            this.rdNewbieMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNewbieMode.Location = new System.Drawing.Point(108, 19);
            this.rdNewbieMode.Name = "rdNewbieMode";
            this.rdNewbieMode.Size = new System.Drawing.Size(79, 24);
            this.rdNewbieMode.TabIndex = 0;
            this.rdNewbieMode.TabStop = true;
            this.rdNewbieMode.Text = "Newbie";
            this.rdNewbieMode.UseVisualStyleBackColor = true;
            // 
            // rdNormalMode
            // 
            this.rdNormalMode.AutoSize = true;
            this.rdNormalMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNormalMode.Location = new System.Drawing.Point(442, 19);
            this.rdNormalMode.Name = "rdNormalMode";
            this.rdNormalMode.Size = new System.Drawing.Size(77, 24);
            this.rdNormalMode.TabIndex = 1;
            this.rdNormalMode.TabStop = true;
            this.rdNormalMode.Text = "Normal";
            this.rdNormalMode.UseVisualStyleBackColor = true;
            // 
            // btPlay
            // 
            this.btPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlay.ForeColor = System.Drawing.Color.Black;
            this.btPlay.Location = new System.Drawing.Point(450, 625);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(280, 80);
            this.btPlay.TabIndex = 10;
            this.btPlay.Text = "Play";
            this.btPlay.BackColor = Color.LimeGreen;
            this.btPlay.Click += BtPlay_Click;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(490, 574);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(193, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Log Game to Text File?";
            this.checkBox1.BackColor = Color.Transparent;
            this.checkBox1.ForeColor = Color.LimeGreen;
           
            // 
            // Panel PlayOptions
            // 
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pbBackScreen);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.pbLargeDeck);
            this.Controls.Add(this.pbMediumDeck);
            this.Controls.Add(this.lblOtherOptions);
            this.Controls.Add(this.gbGameMode);
            this.Controls.Add(this.lblPromptGameMode);
            this.Controls.Add(this.lblPromptDeckSize);
            this.Controls.Add(this.pbSmallDeck);
            this.Controls.Add(this.lblTitle);
            this.Name = "pnlPlayOptions";
            this.BackgroundImage = Properties.Resources.mainMenuCombinedBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Dock = DockStyle.Fill;
           
            ((System.ComponentModel.ISupportInitialize)(this.pbSmallDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLargeDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMediumDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Goes back to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbBackScreen_Click(object sender, EventArgs e)
        {
            //Goto Main Menu options
            if (this.Parent is Form)
                (this.Parent as PlayDurak).SetScreen(PlayDurak.Screen.MainMenu);
            this.Visible = false;
        }

        /// <summary>
        /// Makes the currently selected picturebox (deck size) highlight
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbDeckSize_Click(object sender, EventArgs e)
        {
            PictureBox pbDeckSelected = sender as PictureBox;

            if (pbDeckSelected.BorderStyle == BorderStyle.Fixed3D)
                pbDeckSelected.BorderStyle = BorderStyle.None;
            else
                pbDeckSelected.BorderStyle = BorderStyle.Fixed3D;

            foreach (PictureBox pbDeckSize in Controls.OfType<PictureBox>())
            {
                if(pbDeckSize.Name != pbDeckSelected.Name)
                    pbDeckSize.BorderStyle = BorderStyle.None;
            }
        }

        /// <summary>
        /// Starts a game of durak
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtPlay_Click(object sender, EventArgs e)
        {
            if (IsDeckSizeSelected())
            {
                durakPage = new DurakPage(GetHumanPlayer(), GetEnemyPlayer(), GetPlayerSelectedDeck());
                this.Parent.Controls.Add(durakPage);
                PlayDurak.SetScreenVisible(this.Parent.Controls, durakPage);
            }
            else
            {
                MessageBox.Show("Error! Deck size must be selected");
            }

        }

        /// <summary>
        /// Returns a new deck object based on the selected deck size
        /// </summary>
        /// <returns></returns>
        private Deck GetPlayerSelectedDeck()
        {
            Deck gameDeck = new Deck(Deck.Size.Medium); // by defualt its medium
            foreach (PictureBox pbDeckSize in Controls.OfType<PictureBox>())
            {
                // border style tells us if box is selected
                if (pbDeckSize.BorderStyle == BorderStyle.Fixed3D)
                {   
                    gameDeck = new Deck((Deck.Size)pbDeckSize.Tag, true);
                    gameDeck.Shuffle();
                }
            }
            
            return gameDeck;
        }

        /// <summary>
        /// Returns a new default enemy player
        /// </summary>
        /// <returns></returns>
        private AiPlayer GetEnemyPlayer()
        {
            AiPlayer enemyPlayer = new AiPlayer();
            enemyPlayer.Image = Properties.Resources.robot;
            enemyPlayer.Name = "Computer";

            return enemyPlayer;
        }

        /// <summary>
        /// Returns a new default human player
        /// </summary>
        /// <returns></returns>
        private HumanPlayer GetHumanPlayer()
        {
            HumanPlayer myPlayer = new HumanPlayer();
            myPlayer.Image = Properties.Resources.user;
            myPlayer.Name = "John Wick"; // maybe add text box in play options page to get these name like values
           
            return myPlayer;
        }

        /// <summary>
        /// Checks if a deck size is selected
        /// </summary>
        /// <returns>If a deck size if selected or not</returns>
        private bool IsDeckSizeSelected()
        {
            bool isDeckSizeSelected = false;
            foreach (PictureBox pbDeckSize in Controls.OfType<PictureBox>())
            {
                // border style tells us if box is selected
                if (pbDeckSize.BorderStyle == BorderStyle.Fixed3D)
                {
                    isDeckSizeSelected = true;
                }
            }
            return isDeckSizeSelected;
        }

    }

}

