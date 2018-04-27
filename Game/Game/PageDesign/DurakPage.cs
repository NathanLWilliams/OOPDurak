/* DurakPage.cs
 * Group 9 (Nathan Williams, Jonathan Hermans, Karence Ma, Qasim Iqbal)
 * Date: 27/4/18
 * Description: A class for the actual durak game panel, represents a durak game
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardGame;
using CardBoxControl;
using System.Drawing;
using Game;

namespace Game
{
    public class DurakPage : Panel
    {
        private Label lbMyPlayerName;
        private Label lbMyPlayerHandCount;
        private Label lbEnemyPlayerName;
        private Label lbEnemyPlayerHandCount;
        
        private System.Windows.Forms.Panel panel1;
        private PictureBox pbMenuOptions;
        private System.Windows.Forms.PictureBox pbMyPlayerImage;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pbEnemyPlayerImage;
        private System.Windows.Forms.PictureBox pbSkipButton;
        private Label lblCurrentTurn;
        private DeckViewer enemyDeckViewer;
        private BoutViewer boutDeckViewer;
        private DeckPileViewer drawDeckViewer;
        private DeckViewer playerDeckViewer;

        private CardBox cdbTrumpCard;
        private Panel pnlGameMenu;
        private Button btnCancel;
        private Button btnReturnMainMenu;

        private AiPlayer enemyPlayer;
        private HumanPlayer humanPlayer;
        public static bool isPlayerAttacking;
        public static bool isPlayerTurn;

        private const int POP = 25;
        private const int CARD_MIN_BEFORE_REFILL = 6;
        private const int CARDS_DEALT_AT_START = 6;

        public DurakPage()
        {
            Initialize(); // calls the form controls load method
        }

        public DurakPage(HumanPlayer humanPlayer, AiPlayer aiPlayer, Deck deck)
        {
            Initialize();
            SetupTrumpCard(deck);
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
            this.lbEnemyPlayerName = new Label();
            this.lbEnemyPlayerHandCount = new Label();
            this.lbMyPlayerHandCount = new Label();
            this.pbMenuOptions = new PictureBox();
            this.lblCurrentTurn = new Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSkipButton = new System.Windows.Forms.PictureBox();
            this.pbMyPlayerImage = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pbEnemyPlayerImage = new System.Windows.Forms.PictureBox();
            this.boutDeckViewer = new BoutViewer();
            this.pnlGameMenu = new Panel();
            this.btnCancel = new Button();
            this.btnReturnMainMenu = new Button();

            //this.drawDeckViewer = new DeckPileViewer();
            this.playerDeckViewer = new DeckViewer();
            this.enemyDeckViewer = new DeckViewer(true);
            this.enemyDeckViewer.Tag = "enemyDeck";
            this.enemyDeckViewer.AllowDrop = false;
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkipButton)).BeginInit();
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
            // deckViewer1
            // 
            this.playerDeckViewer.BackColor = System.Drawing.Color.Lime;
            this.playerDeckViewer.Location = new System.Drawing.Point(11, 502);
            this.playerDeckViewer.Margin = new System.Windows.Forms.Padding(2);
            this.playerDeckViewer.Name = "deckViewer1";
            this.playerDeckViewer.Size = new System.Drawing.Size(1171, 167);
            this.playerDeckViewer.TabIndex = 11;
            this.playerDeckViewer.ControlAdded += UpdatePlayersHandCount;
            this.playerDeckViewer.ControlRemoved += UpdatePlayersHandCount;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbSkipButton);
            this.panel1.Controls.Add(this.pbMyPlayerImage);
            this.panel1.Location = new System.Drawing.Point(this.playerDeckViewer.Location.X, 667);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(this.playerDeckViewer.Size.Width, 120);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pbSkipButton.Location = new System.Drawing.Point(820, 32);
            this.pbSkipButton.Name = "pictureBox4";
            this.pbSkipButton.Size = new System.Drawing.Size(61, 50);
            this.pbSkipButton.TabIndex = 11;
            this.pbSkipButton.TabStop = false;
            this.pbSkipButton.Image = Properties.Resources.skip;
            this.pbSkipButton.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbSkipButton.Click += pbSkipButton_Click;
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
            // pnlGameMenu
            // 
            this.pnlGameMenu.BackgroundImage = Properties.Resources.menu_shade;
            this.pnlGameMenu.Controls.Add(this.btnCancel);
            this.pnlGameMenu.Controls.Add(this.btnReturnMainMenu);
            this.pnlGameMenu.Location = new System.Drawing.Point(-3, -1);
            this.pnlGameMenu.Name = "pnlGameMenu";
            this.pnlGameMenu.Size = new System.Drawing.Size(1187, 760);
            this.pnlGameMenu.TabIndex = 14;
            this.pnlGameMenu.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Lime;
            this.btnCancel.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(385, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(438, 87);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += BtnCancel_Click;
            // 
            // btnReturnMainMenu
            // 
            this.btnReturnMainMenu.BackColor = System.Drawing.Color.Lime;
            this.btnReturnMainMenu.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMainMenu.Location = new System.Drawing.Point(385, 250);
            this.btnReturnMainMenu.Name = "btnReturnMainMenu";
            this.btnReturnMainMenu.Size = new System.Drawing.Size(438, 87);
            this.btnReturnMainMenu.TabIndex = 0;
            this.btnReturnMainMenu.Text = "Return to Main Menu";
            this.btnReturnMainMenu.UseVisualStyleBackColor = false;
            this.btnReturnMainMenu.Click += BtnReturnMainMenu_Click;
            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrentTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTurn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblCurrentTurn.Location = new System.Drawing.Point(762, 676);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(100, 23);
            this.lblCurrentTurn.TabIndex = 13;
            this.lblCurrentTurn.Text = "Attacker";
            this.lblCurrentTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


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
            this.lbMyPlayerHandCount.Text = playerDeckViewer.Controls.Count.ToString();
            this.lbMyPlayerHandCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
 
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
            this.lbEnemyPlayerHandCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boutDeckViewer
            // 
            this.boutDeckViewer.BackColor = System.Drawing.Color.Lime;
            this.boutDeckViewer.Location = new System.Drawing.Point(215, 211);
            this.boutDeckViewer.Margin = new System.Windows.Forms.Padding(2);
            this.boutDeckViewer.Name = "deckViewer3";
            this.boutDeckViewer.Size = new System.Drawing.Size(967, 287);
            this.boutDeckViewer.TabIndex = 9;
            this.boutDeckViewer.CardAdded += OnNextTurn;
            // 
            // deckViewer4
            // 
            this.enemyDeckViewer.BackColor = System.Drawing.Color.Lime;
            this.enemyDeckViewer.Location = new System.Drawing.Point(0, 92);
            this.enemyDeckViewer.Margin = new System.Windows.Forms.Padding(2);
            this.enemyDeckViewer.Name = "deckViewer4";
            this.enemyDeckViewer.Size = new System.Drawing.Size(292, 66);
            this.enemyDeckViewer.TabIndex = 10;
            this.enemyDeckViewer.ControlAdded += UpdatePlayersHandCount;
            this.enemyDeckViewer.ControlRemoved += UpdatePlayersHandCount;
            // 
            // DurakDeck
            // 
            this.BackgroundImage = Properties.Resources.mainMenuBackgroundCenter;
            this.Dock = DockStyle.Fill;
            this.ClientSize = new System.Drawing.Size(1184, 761);

            this.Controls.Add(this.lbEnemyPlayerName);
            this.Controls.Add(this.lbMyPlayerName);
            this.Controls.Add(this.lbMyPlayerHandCount);
            this.Controls.Add(this.lbEnemyPlayerHandCount);
            this.Controls.Add(this.lblCurrentTurn);

            this.Controls.Add(this.playerDeckViewer);
            
            this.Controls.Add(this.boutDeckViewer);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbMenuOptions);
            this.Name = "pnlDurakPage";
            this.Text = "DurakDeck";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkipButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyPlayerImage)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyPlayerImage)).EndInit();
            this.ResumeLayout(false);
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.pnlGameMenu.Visible = false;
        }

        private void BtnReturnMainMenu_Click(object sender, EventArgs e)
        {
            if (this.Parent is Form)
                (this.Parent as PlayDurak).SetScreen(PlayDurak.Screen.MainMenu);
            this.Dispose();

        }

        private void PbMenuOptions_Click(object sender, EventArgs e)
        {
            this.pnlGameMenu.Visible = true;
            this.Controls["pnlGameMenu"].BringToFront();
        }

        /// <summary>
        /// Manually ends a bout upon skip button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbSkipButton_Click(object sender, EventArgs e)
        {
            EndBout();

            //Update cards if needed
            this.boutDeckViewer.SetChanged();
            this.boutDeckViewer.AdjustCards();
            this.drawDeckViewer.AdjustCards();
            this.playerDeckViewer.AdjustCards();
            this.enemyDeckViewer.AdjustCards();
        }

        /// <summary>
        /// Updates hand count labels to reflect the number of cards in the
        /// players hands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdatePlayersHandCount(object sender, ControlEventArgs e)
        {
            lbMyPlayerHandCount.Text = playerDeckViewer.Controls.Count.ToString();
            lbEnemyPlayerHandCount.Text = enemyDeckViewer.Controls.Count.ToString();
        }

        /// <summary>
        /// Processes the AI and human player's turn. Called when a card is added to the BoutDeckViewer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNextTurn(object sender, EventArgs e)
        {
            NextTurn();
            if (boutDeckViewer.isFull())
            {
                EndBout();
            }

            //Update cards if needed
            this.boutDeckViewer.AdjustCards();
            this.drawDeckViewer.AdjustCards();
            this.playerDeckViewer.AdjustCards();
            this.enemyDeckViewer.AdjustCards();
        }

        /// <summary>
        /// Starts the next turns logic
        /// </summary>
        public void NextTurn()
        {
            //Check if it's the player's turn or the Ai's turn
            if (isPlayerTurn)
            {
                //Make it the AI player's turn
                isPlayerTurn = false;
                (boutDeckViewer as BoutViewer).AllowDrop = false;

                //Since nothing currently triggers the AiPlayer's turn, recursively call
                //this event handler in order to activate the AiPlayer's turn
                NextTurn();
            }
            else
            {
                //The AI chooses what card to play
                Card cardToPlay = enemyPlayer.ChooseAction(enemyDeckViewer, boutDeckViewer);

                //Confirm the AI actually chose a card, and not the default null card
                if (object.ReferenceEquals(cardToPlay, null))
                {
                    //The AI is unable to play any cards, so he loses the Bout
                    EndBout();
                }
                else
                {
                    //The AI plays a card
                    boutDeckViewer.AddCard((Card)cardToPlay.Clone(), false);
                    enemyDeckViewer.RemoveCard(cardToPlay);
                }

                //Make it the human player's turn
                isPlayerTurn = true;
                (boutDeckViewer as BoutViewer).AllowDrop = true;
            }
        }

        /// <summary>
        /// Determines what happens to the bout cards after a bout has ended
        /// </summary>
        public void DistributeBoutCards()
        {
            if (isPlayerTurn == isPlayerAttacking) //The current player is attacking
            {
                boutDeckViewer.Reset();
            }
            else if (isPlayerTurn) //Is human player and is defending
            {
                this.playerDeckViewer.DrawCards(boutDeckViewer.GetCards());
            }
            else //Is AI and is defending
            {
                this.enemyDeckViewer.DrawCards(boutDeckViewer.GetCards());
            }
        }

        /// <summary>
        /// Ends the bout by switching the roles of the attacker and defender, distributing cards to the loser,
        /// and clearing the cards from the bout
        /// </summary>
        public void EndBout()
        {

            //Distribute or reset the cards in the bout
            DistributeBoutCards();
            //Calls a method to refill the player and AI hand to 6 cards minimum
            RefillCards();
            boutDeckViewer.CardCountAtBoutStart = isPlayerAttacking ? enemyDeckViewer.GetCards().Count : playerDeckViewer.GetCards().Count;

            //Check if the games end conditions are fulfilled
            DetermineGameEnd();

            //Switch roles of attacker and defender
            SwitchRoles();

            //The AI is going to attack
            if (isPlayerAttacking == false)
            {
                //The user can't trigger the AI's turn since it's the first
                //card placed in the bout, therefore OnNextTurn is not triggered
                //therefore, trigger it here.
                NextTurn();
            }
            
        }

        /// <summary>
        /// Switch the roles of attacker and defender
        /// </summary>
        public void SwitchRoles()
        {
            isPlayerAttacking = isPlayerAttacking ? false : true;
            isPlayerTurn = isPlayerAttacking;
            lblCurrentTurn.Text = isPlayerAttacking ? "Attacker" : "Defender";
        }

        /// <summary>
        /// Checks if the game should be ended and who is the winner
        /// </summary>
        public void DetermineGameEnd()
        {
            Win result = new Win(); 
            if (drawDeckViewer.Controls.Count == 0)
            {
                 if (playerDeckViewer.Controls.Count == 0 && enemyDeckViewer.Controls.Count == 0)
                {
                    //It's a tie!
                    this.Parent.Controls.Add(result);
                    result.LabelText = "Tie Game";
                    
                    if (this.Parent is PlayDurak)  
                    PlayDurak.SetScreenVisible(this.Parent.Controls, result);
                    
                      
                }
                else if (playerDeckViewer.Controls.Count == 0)
                {
                    //The human player wins!
                    this.Parent.Controls.Add(result);
                    result.LabelText = "You Win !!";
                    
                    if (this.Parent is PlayDurak)
                        PlayDurak.SetScreenVisible(this.Parent.Controls, result);
                }
                else
                {
                    //The AI wins!
                     this.Parent.Controls.Add(result);
                    result.LabelText = "You are the Durak!";
                    if (this.Parent is PlayDurak)
                        PlayDurak.SetScreenVisible(this.Parent.Controls, result);
                }
            }
        }

        /// <summary>
        /// Refills the player and AIs hands to be at least the minimum number of cards at the end of a bout
        /// </summary>
        public void RefillCards()
        {
            //Refill the AIs cards
            while (enemyDeckViewer.GetCards().Count < CARD_MIN_BEFORE_REFILL && drawDeckViewer.GetCards().Count > 0)
            {
                enemyDeckViewer.AddCard(drawDeckViewer.TakeCard(drawDeckViewer.GetCards().Count - 1));
            }

            //Refill the players cards
            while (playerDeckViewer.GetCards().Count < CARD_MIN_BEFORE_REFILL && drawDeckViewer.GetCards().Count > 0)
            {
                playerDeckViewer.AddCard(drawDeckViewer.TakeCard(drawDeckViewer.GetCards().Count - 1));
            }
        }

        /// <summary>
        /// Initializes the deck object which players will draw from
        /// </summary>
        /// <param name="deck"></param>
        private void InitializeDeck(Deck deck)
        {
            drawDeckViewer = new DeckPileViewer(deck);
            this.drawDeckViewer.BackColor = System.Drawing.Color.Lime;
            this.drawDeckViewer.Location = new System.Drawing.Point(11, 211);
            this.drawDeckViewer.Margin = new System.Windows.Forms.Padding(2);
            this.drawDeckViewer.Name = "deckViewer2";
            this.drawDeckViewer.Size = new System.Drawing.Size(200, 287);
            this.drawDeckViewer.TabIndex = 10;
            
            this.Controls.Add(this.drawDeckViewer);

            //Update the cards if needed
            this.boutDeckViewer.AdjustCards();
            this.drawDeckViewer.AdjustCards();
            this.playerDeckViewer.AdjustCards();
            this.enemyDeckViewer.AdjustCards();

        }

        /// <summary>
        /// Sets up the players which will be in the game
        /// </summary>
        /// <param name="myPlayer">The human player to set</param>
        /// <param name="enemyPlayer">The AI player to set</param>
        /// <param name="deck">The deck which they'll draw from to get their initial cards</param>
        private void SetUpPlayers(HumanPlayer myPlayer, AiPlayer enemyPlayer, Deck deck)
        {
            this.enemyPlayer = enemyPlayer;
            this.humanPlayer = myPlayer;

            //Player gets to start first
            isPlayerAttacking = true;
            isPlayerTurn = true;

           // set up enemplayer object
            pbEnemyPlayerImage.Image = enemyPlayer.Image;
            lbEnemyPlayerName.Text = enemyPlayer.Name;

            //Deal their initial cards
            enemyDeckViewer.DrawCards(deck, CARDS_DEALT_AT_START);
            playerDeckViewer.DrawCards(deck, CARDS_DEALT_AT_START);
         
            // set up myPlayer object
            pbMyPlayerImage.Image = myPlayer.Image;
            lbMyPlayerName.Text = myPlayer.Name;

            lbMyPlayerHandCount.Text = playerDeckViewer.Controls.Count.ToString();
        }

        /// <summary>
        /// Sets up the trump card and it's related cardbox
        /// </summary>
        /// <param name="deck"></param>
        private void SetupTrumpCard(Deck deck)
        {
            Random randomNumber = new Random();
            
            Card cardChosen = new Card(deck[randomNumber.Next(deck.Count)].GetHashCode());
            cdbTrumpCard = new CardBox(cardChosen,false,Orientation.Horizontal);
            cdbTrumpCard.Name = "cdbTrumpCard";
            cdbTrumpCard.FaceUp = true;
            cdbTrumpCard.Size = new Size(87, 141);
            cdbTrumpCard.Location = new Point(55, 380);
            Card.trump = cdbTrumpCard.Card.Suit;
            this.Controls.Add(this.cdbTrumpCard);
            this.Controls["cdbTrumpCard"].BringToFront();

        }
        public void canPlaceCard()
        {
            bool isAttacker = true;
            if (isAttacker) //you are attacking first
            {
                //determine playable cards when the bout is empty
                if (boutDeckViewer.GetCards().Count == 0)
                {
                    //all cards should be playable,  highlight all the cards
                    foreach (Control cardControl in playerDeckViewer.Controls)
                    {

                        if (cardControl is CardBox)
                        {
                            //cardControl.Paint += CardControl_Paint;
                            (cardControl as CardBox).FaceUp = true;
                        }
                    }

                }
                else
                {
                    //There are cards in the bout currently, check if there
                    //is the passed card matches any of their ranks
                    foreach (Card boutCard in boutDeckViewer.GetCards())
                    {
                        //check each card to see if it's playable
                        //all cards should be playable,  highlight all the cards
                        foreach (Control cardControl in playerDeckViewer.Controls)
                        {

                            if (cardControl is CardBox)
                                if ((cardControl as CardBox).Rank == boutCard.Rank)
                                    (cardControl as CardBox).FaceUp = true;
                                else
                                    (cardControl as CardBox).FaceUp = false;

                        }

                    }
                }

            }
            else
            {

                if (boutDeckViewer.GetCards().Count != 0) //bout deck is never empty as a defender
                {
                    //There are cards in the bout for the defender to defend against

                    //TODO:assign the lastCard to be the last card played in the bout
                    CardBox lastCard = (CardBox)boutDeckViewer.Controls[boutDeckViewer.Controls.Count - 1];
                    //Check if the passed card is of a matching suit and higher rank, trumps are handled slightly differently

                    //check each card to see if it's playable
                    //all cards should be playable,  highlight all the cards
                    foreach (Control cardControl in playerDeckViewer.Controls)
                    {

                        if (cardControl is CardBox)
                        {
                            if ((cardControl as CardBox).Suit == lastCard.Suit)
                            {
                                if ((cardControl as CardBox).Rank == Rank.Ace)
                                {
                                    if (lastCard.Rank != Rank.Ace)
                                    {
                                        (cardControl as CardBox).FaceUp = true;
                                    }
                                }
                                else if (lastCard.Rank != Rank.Ace && (cardControl as CardBox).Rank > lastCard.Rank)
                                {
                                    (cardControl as CardBox).FaceUp = true;
                                }
                            }
                            else if ((cardControl as CardBox).Suit == Card.trump) //last card is not trump, but card to play is
                            {
                                (cardControl as CardBox).FaceUp = true;

                            }
                        }
                    }
                }

            }



        }
    }
}




