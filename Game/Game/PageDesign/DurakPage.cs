using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardGame;
using CardBoxControl;
using System.Drawing;
using DeckViewerTester;

namespace Game
{
    public class DurakPage : Panel
    {
        private Label lbMyPlayerName;
        private Label lbMyPlayerScore;
        private Label lbMyPlayerHandCount;
        private Label lbEnemyPlayerName;
        private Label lbEnemyPlayerScore;
        private Label lbEnemyPlayerHandCount;
        
        private System.Windows.Forms.Panel panel1;
        private PictureBox pbMenuOptions;
        private System.Windows.Forms.PictureBox pbMyPlayerImage;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pbEnemyPlayerImage;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private DeckViewer enemyDeckViewer;
        private DeckViewer boutDeckViewer;
        private DeckViewer drawDeckViewer;
        private DeckViewer playerDeckViewer;

        //private CardBox dragCard;

        private const int POP = 25;

        public DurakPage()
        {
            Initialize(); // calls the form controls load method
        }
        // might change AiPlayer class name to enemyPlayer
        public DurakPage(HumanPlayer humanPlayer, AiPlayer aiPlayer, Deck deck)
        {
            Initialize();
            SetUpPlayers(humanPlayer, aiPlayer, deck);
            InitializeDeck(deck);

        }

        /// <summary>
        /// Durak form
        /// </summary>
        private void Initialize()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DurakPage));
            this.lbMyPlayerName = new Label();
            this.lbMyPlayerScore = new Label() ;
            this.lbEnemyPlayerName = new Label();
            this.lbEnemyPlayerScore = new Label();
            this.lbEnemyPlayerHandCount = new Label();
            this.lbMyPlayerHandCount = new Label();
            this.pbMenuOptions = new PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbMyPlayerImage = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pbEnemyPlayerImage = new System.Windows.Forms.PictureBox();
            this.boutDeckViewer = new BoutViewer();
            //this.drawDeckViewer = new DeckPileViewer();
            this.playerDeckViewer = new DeckViewer();
            this.enemyDeckViewer = new DeckViewer();
            this.enemyDeckViewer.AllowDrop = false;
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyPlayerImage)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyPlayerImage)).BeginInit();
            this.SuspendLayout();
            //
            // MenuOptonPictureBox
            //
            this.pbMenuOptions.BackColor = System.Drawing.Color.Transparent;
            this.pbMenuOptions.Image = Properties.Resources.menu_lime_t;
            this.pbMenuOptions.Location = new System.Drawing.Point(11, 28);
            this.pbMenuOptions.Name = "pbMenuOptions";
            this.pbMenuOptions.Size = new System.Drawing.Size(88, 83);
            this.pbMenuOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenuOptions.TabIndex = 4;
            this.pbMenuOptions.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pbMyPlayerImage);
            this.panel1.Location = new System.Drawing.Point(-3, 667);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 95);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(920, 32);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 50);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Image = Properties.Resources.surrender;
            this.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(820, 32);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(61, 50);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Image = Properties.Resources.skip;
            this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // pictureBox3
            // 
            this.pbMyPlayerImage.Location = new System.Drawing.Point(564, 7);
            this.pbMyPlayerImage.Name = "pictureBox3";
            this.pbMyPlayerImage.Size = new System.Drawing.Size(100, 85);
            this.pbMyPlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMyPlayerImage.TabIndex = 10;
            this.pbMyPlayerImage.TabStop = false;
            this.pbMyPlayerImage.BackColor = System.Drawing.Color.AliceBlue;

            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.enemyDeckViewer);
            this.panel9.Controls.Add(this.pbEnemyPlayerImage);
            this.panel9.Location = new System.Drawing.Point(467, 28);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(292, 160);
            this.panel9.TabIndex = 7;
            // 
            // pbEnemyPlyerImage
            // 
            this.pbEnemyPlayerImage.Location = new System.Drawing.Point(97, 3);
            this.pbEnemyPlayerImage.Name = "pictureBox2";
            this.pbEnemyPlayerImage.Size = new System.Drawing.Size(100, 85);
            this.pbEnemyPlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemyPlayerImage.TabIndex = 9;
            this.pbEnemyPlayerImage.TabStop = false;
            // 
            // lbMyPlayerName
            // 
            this.lbMyPlayerName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMyPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMyPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbMyPlayerName.Location = new System.Drawing.Point(458, 676);
            this.lbMyPlayerName.Name = "lbMyPlayerName";
            this.lbMyPlayerName.Size = new System.Drawing.Size(100, 23);
            this.lbMyPlayerName.TabIndex = 13;
            this.lbMyPlayerName.Text = " ";
            this.lbMyPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMyPlayerHandCount
            // 
            this.lbMyPlayerHandCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMyPlayerHandCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMyPlayerHandCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbMyPlayerHandCount.Location = new System.Drawing.Point(672, 676);
            this.lbMyPlayerHandCount.Name = "lbMyPlayerHandCount";
            this.lbMyPlayerHandCount.Size = new System.Drawing.Size(100, 23);
            this.lbMyPlayerHandCount.TabIndex = 13;
            this.lbMyPlayerHandCount.Text = "6";
            this.lbMyPlayerHandCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMyPlayerScore
            // 
            this.lbMyPlayerScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMyPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMyPlayerScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbMyPlayerScore.Location = new System.Drawing.Point(458, 700);
            this.lbMyPlayerScore.Name = "lbPlayerScore";
            this.lbMyPlayerScore.Size = new System.Drawing.Size(100, 23);
            this.lbMyPlayerScore.TabIndex = 14;
            this.lbMyPlayerScore.Text = " ";
            this.lbMyPlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEnemyPlayerName
            // 
            this.lbEnemyPlayerName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEnemyPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnemyPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbEnemyPlayerName.Location = new System.Drawing.Point(465, 30);
            this.lbEnemyPlayerName.Name = "lbEnemyPlayerName";
            this.lbEnemyPlayerName.Size = new System.Drawing.Size(88, 23);
            this.lbEnemyPlayerName.TabIndex = 14;
            this.lbEnemyPlayerName.Text = "Computer";
            this.lbEnemyPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbEnemyPlayerHandCount.Click += LbEnemyPlayerHandCount_Click;
            // 
            // 
            // lbEnemyPlayerHandCount
            // 
            this.lbEnemyPlayerHandCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEnemyPlayerHandCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnemyPlayerHandCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbEnemyPlayerHandCount.Location = new System.Drawing.Point(670, 30);
            this.lbEnemyPlayerHandCount.Name = "lbEnemyPlayerHandCount";
            this.lbEnemyPlayerHandCount.Size = new System.Drawing.Size(88, 23);
            this.lbEnemyPlayerHandCount.TabIndex = 14;
            this.lbEnemyPlayerHandCount.Text = "8";
            this.lbEnemyPlayerHandCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEnememyPlayerScore
            // 
            this.lbEnemyPlayerScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEnemyPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnemyPlayerScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbEnemyPlayerScore.Location = new System.Drawing.Point(465, 55);
            this.lbEnemyPlayerScore.Name = "lbEnemyPlayerScore";
            this.lbEnemyPlayerScore.Size = new System.Drawing.Size(88, 23);
            this.lbEnemyPlayerScore.TabIndex = 15;
            this.lbEnemyPlayerScore.Text = " ";
            this.lbEnemyPlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // boutDeckViewer
            // 
            this.boutDeckViewer.BackColor = System.Drawing.Color.Lime;
            this.boutDeckViewer.Location = new System.Drawing.Point(215, 211);
            this.boutDeckViewer.Margin = new System.Windows.Forms.Padding(2);
            this.boutDeckViewer.Name = "deckViewer3";
            this.boutDeckViewer.Size = new System.Drawing.Size(967, 287);
            this.boutDeckViewer.TabIndex = 9;
            // 
            // drawDeckViewr
            // 
            //this.drawDeckViewer.BackColor = System.Drawing.Color.Lime;
            //this.drawDeckViewer.Location = new System.Drawing.Point(11, 211);
            //this.drawDeckViewer.Margin = new System.Windows.Forms.Padding(2);
            //this.drawDeckViewer.Name = "deckViewer2";
            //this.drawDeckViewer.Size = new System.Drawing.Size(200, 287);
            //this.drawDeckViewer.TabIndex = 10;
            // 
            // deckViewer1
            // 
            this.playerDeckViewer.BackColor = System.Drawing.Color.Lime;
            this.playerDeckViewer.Location = new System.Drawing.Point(11, 502);
            this.playerDeckViewer.Margin = new System.Windows.Forms.Padding(2);
            this.playerDeckViewer.Name = "deckViewer1";
            this.playerDeckViewer.Size = new System.Drawing.Size(1171, 167);
            this.playerDeckViewer.TabIndex = 11;
            //TODO: Instantiate the deck separately using Settings.deckSize
            //this.playerDeckViewer.AddCards(new Deck(Deck.Size.Medium, true, true, Suit.Clubs), 6);
            // 
            // deckViewer4
            // 
            this.enemyDeckViewer.BackColor = System.Drawing.Color.Lime;
            this.enemyDeckViewer.Location = new System.Drawing.Point(0, 92);
            this.enemyDeckViewer.Margin = new System.Windows.Forms.Padding(2);
            this.enemyDeckViewer.Name = "deckViewer4";
            this.enemyDeckViewer.Size = new System.Drawing.Size(292, 66);
            this.enemyDeckViewer.TabIndex = 10;
            // 
            // DurakDeck
            // 
            this.BackgroundImage = Properties.Resources.mainMenuBackgroundCenter;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.lbEnemyPlayerName);
            this.Controls.Add(this.lbEnemyPlayerScore);
            this.Controls.Add(this.lbMyPlayerName);
            this.Controls.Add(this.lbMyPlayerScore);
            this.Controls.Add(this.lbMyPlayerHandCount);
            this.Controls.Add(this.lbEnemyPlayerHandCount);

            this.Controls.Add(this.playerDeckViewer);
            
            this.Controls.Add(this.boutDeckViewer);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbMenuOptions);
            this.Name = "pnlDurakPage";
            this.Text = "DurakDeck";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyPlayerImage)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyPlayerImage)).EndInit();
            this.ResumeLayout(false);
            //SetUpPlayer();
        }

        private void LbEnemyPlayerHandCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show(drawDeckViewer.Controls.Count.ToString());
        }

        private void InitializeDeck(Deck deck)
        {
            drawDeckViewer = new DeckPileViewer(deck);
            // drawDeckViewer.AddCards(deck, deck.Count); // also in DeckPile viewer class need to make adjustments for TrumpCard to show horizontally and do something with deck
            this.drawDeckViewer.BackColor = System.Drawing.Color.Lime;
            this.drawDeckViewer.Location = new System.Drawing.Point(11, 211);
            this.drawDeckViewer.Margin = new System.Windows.Forms.Padding(2);
            this.drawDeckViewer.Name = "deckViewer2";
            this.drawDeckViewer.Size = new System.Drawing.Size(200, 287);
            this.drawDeckViewer.TabIndex = 10;
            this.Controls.Add(this.drawDeckViewer);
        }
        private void SetUpPlayers(HumanPlayer myPlayer, AiPlayer enemyPlayer, Deck deck)
        {
           // set up enemplayer object
            pbEnemyPlayerImage.Image = enemyPlayer.Image;
            lbEnemyPlayerName.Text = enemyPlayer.Name;
            lbEnemyPlayerScore.Text = enemyPlayer.Score.ToString();

            enemyDeckViewer.AddCards(deck, 6);

            playerDeckViewer.AddCards(deck, 6);
         
            // set up myPlayer object
            pbMyPlayerImage.Image = myPlayer.Image;
            lbMyPlayerName.Text = myPlayer.Name;
            lbMyPlayerScore.Text = myPlayer.Score.ToString();
        }


    }
}




