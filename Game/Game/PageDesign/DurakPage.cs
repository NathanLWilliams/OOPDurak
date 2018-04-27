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
        // might change AiPlayer class name to enemyPlayer
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
            // drawDeckViewr
            // 
            //this.drawDeckViewer.BackColor = System.Drawing.Color.Lime;
            //this.drawDeckViewer.Location = new System.Drawing.Point(11, 211);
            //this.drawDeckViewer.Margin = new System.Windows.Forms.Padding(2);
            //this.drawDeckViewer.Name = "deckViewer2";
            //this.drawDeckViewer.Size = new System.Drawing.Size(200, 287);
            //this.drawDeckViewer.TabIndex = 10;
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
                    result.LabelText = "Tie Game";
                    this.Parent.Controls.Add(result);
                    if (this.Parent is PlayDurak)  
                    PlayDurak.SetScreenVisible(this.Parent.Controls, result);
                    
                      
                }
                else if (playerDeckViewer.Controls.Count == 0)
                {
                    //The human player wins!
                    result.LabelText = "You Win !!";
                    this.Parent.Controls.Add(result);
                    if (this.Parent is PlayDurak)
                        PlayDurak.SetScreenVisible(this.Parent.Controls, result);
                }
                else
                {
                    //The AI wins!
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

        private void LbEnemyPlayerHandCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show(drawDeckViewer.Controls.Count.ToString());
        }

        private void InitializeDeck(Deck deck)
        {
            drawDeckViewer = new DeckPileViewer(deck);
            drawDeckViewer.DrawCards(new CardGame.Deck(Deck.Size.Large, true), 5);
            // drawDeckViewer.AddCards(deck, deck.Count); // also in DeckPile viewer class need to make adjustments for TrumpCard to show horizontally and do something with deck
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
        private void SetupTrumpCard(Deck deck)
        {
            Random randomNumber = new Random();
            
            Card cardChosen = new Card(deck[randomNumber.Next(deck.Count)].GetHashCode());
            cdbTrumpCard = new CardBox(cardChosen,false,Orientation.Horizontal);
            cdbTrumpCard.Name = "cdbTrumpCard";
            cdbTrumpCard.FaceUp = true;
            cdbTrumpCard.Size = new Size(87, 141);
            cdbTrumpCard.Location = new Point(55, 380);
            
            this.Controls.Add(this.cdbTrumpCard);
            this.Controls["cdbTrumpCard"].BringToFront();

        }

    }
}




