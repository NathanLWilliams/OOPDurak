using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    class InstructionsPage : Panel

    {
        public InstructionsPage()
        {
            this.pbBackScreen = new PictureBox();
            this.tbInstructions = new System.Windows.Forms.TabControl();
            this.tbRules = new System.Windows.Forms.TabPage();
            this.tbAttacker = new System.Windows.Forms.TabPage();
            this.tbDefense = new System.Windows.Forms.TabPage();
            this.lblDefend = new System.Windows.Forms.Label();
            this.lblDefendDescript = new System.Windows.Forms.Label();
            this.lblAttack = new System.Windows.Forms.Label();
            this.lblAttackDescrip = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblRulesDescription = new System.Windows.Forms.Label();
            this.tbVideo = new System.Windows.Forms.TabPage();
            this.tbInstructions.SuspendLayout();
            this.tbRules.SuspendLayout();
            this.tbAttacker.SuspendLayout();
            this.tbDefense.SuspendLayout();
            this.SuspendLayout();
            //
            // BackScreenPictureBox
            //
            this.pbBackScreen.BackColor = System.Drawing.Color.Transparent;
            this.pbBackScreen.Image = Properties.Resources.goback;
            this.pbBackScreen.Location = new System.Drawing.Point(35, 40);
            this.pbBackScreen.Name = "pbBackScreen";
            this.pbBackScreen.Size = new System.Drawing.Size(88, 83);
            this.pbBackScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackScreen.TabIndex = 4;
            this.pbBackScreen.TabStop = false;
            this.pbBackScreen.Click += PbBackScreen_Click;

            // 
            // tbInstructions
            // 
            this.tbInstructions.Controls.Add(this.tbRules);
            this.tbInstructions.Controls.Add(this.tbAttacker);
            this.tbInstructions.Controls.Add(this.tbDefense);
            this.tbInstructions.Controls.Add(this.tbVideo);
            this.tbInstructions.Location = new System.Drawing.Point(150, 40);
            this.tbInstructions.Name = "tbInstructions";
            this.tbInstructions.SelectedIndex = 0;
            this.tbInstructions.Size = new System.Drawing.Size(1000, 500);
            this.tbInstructions.TabIndex = 1;
            // 
            // tbRules
            // 
            this.tbRules.Controls.Add(this.lblRulesDescription);
            this.tbRules.Controls.Add(this.lblRules);
            this.tbRules.Location = new System.Drawing.Point(4, 22);
            this.tbRules.Name = "tbRules";
            this.tbRules.Padding = new System.Windows.Forms.Padding(3);
            this.tbRules.Size = new System.Drawing.Size(710, 276);
            this.tbRules.TabIndex = 0;
            this.tbRules.Text = "General Rules";
            this.tbRules.UseVisualStyleBackColor = true;
            // 
            // tbAttacker
            // 
            this.tbAttacker.Controls.Add(this.lblAttackDescrip);
            this.tbAttacker.Controls.Add(this.lblAttack);
            this.tbAttacker.Location = new System.Drawing.Point(4, 22);
            this.tbAttacker.Name = "tbAttacker";
            this.tbAttacker.Padding = new System.Windows.Forms.Padding(3);
            this.tbAttacker.Size = new System.Drawing.Size(710, 276);
            this.tbAttacker.TabIndex = 1;
            this.tbAttacker.Text = "Attacker";
            this.tbAttacker.UseVisualStyleBackColor = true;
            // 
            // tbDefense
            // 
            this.tbDefense.Controls.Add(this.lblDefendDescript);
            this.tbDefense.Controls.Add(this.lblDefend);
            this.tbDefense.Location = new System.Drawing.Point(4, 22);
            this.tbDefense.Name = "tbDefense";
            this.tbDefense.Size = new System.Drawing.Size(710, 276);
            this.tbDefense.TabIndex = 2;
            this.tbDefense.Text = "Defense";
            this.tbDefense.UseVisualStyleBackColor = true;
            // 
            // lblDefend
            // 
            this.lblDefend.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefend.Location = new System.Drawing.Point(3, 12);
            this.lblDefend.Name = "lblDefend";
            this.lblDefend.Size = new System.Drawing.Size(231, 42);
            this.lblDefend.TabIndex = 1;
            this.lblDefend.Text = "HOW TO Defend";

            // 
            // lblDefendDescript
            // 
            this.lblDefendDescript.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefendDescript.Location = new System.Drawing.Point(3, 63);
            this.lblDefendDescript.Name = "lblDefendDescript";
            this.lblDefendDescript.Size = new System.Drawing.Size(692, 201);
            this.lblDefendDescript.TabIndex = 2;
            this.lblDefendDescript.Text = "The Defender must defend against the attacker's attack.  "
                                            +"To do this, the defender must place a higher face value card of the same suit as the attacking card.  "
                                            +"If the defender does not have a higher face value card of the same suit, the only other option for a successful defense is to play a trump card. "
                                            +"The face value of the trump card does not matter.  However, if the attacker attacks with a card of the trump suit, then the defender must defend with a higher face value card as the trump suit has been nullified.  "
                                            +"If the defender successfully defends the attacker's attack then the round is over and the cards in the main bout is discarded.  ";
            // 
            // lblAttack
            // 
            this.lblAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttack.Location = new System.Drawing.Point(3, 3);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(389, 42);
            this.lblAttack.TabIndex = 1;
            this.lblAttack.Text = "HOW TO ATTACK";
            // 
            // lblAttackDescrip
            // 
            this.lblAttackDescrip.Location = new System.Drawing.Point(3, 45);
            this.lblAttackDescrip.Name = "lblAttackDescrip";
            this.lblAttackDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttackDescrip.Size = new System.Drawing.Size(692, 228);
            this.lblAttackDescrip.TabIndex = 3;
            this.lblAttackDescrip.Text = "The goal of the attacker is to select a card in which the defender can not beat.  "
                                            +"If the attack is successful the cards in the main bout are placed into the defender's hand.  "
                                            +"If the defender is able to defend, the attacker can perform another attack, IF he has a card of the same face value of any cards in the main bout.  "
                                            +"The attacker may attack up to a maximum of six times.  The round ends if the attacker can't or chooses not to attack again. ";
            // 
            // lblRules
            // 
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(3, 3);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(389, 42);
            this.lblRules.TabIndex = 2;
            this.lblRules.Text = "General Rules";
            // 
            // lblRulesDescription
            // 
            this.lblRulesDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesDescription.Location = new System.Drawing.Point(9, 45);
            this.lblRulesDescription.Name = "lblRulesDescription";
            this.lblRulesDescription.Size = new System.Drawing.Size(692, 218);
            this.lblRulesDescription.TabIndex = 4;
            this.lblRulesDescription.Text = "The Goal of Durak is to be the person remaining with cards in their hand.  The first person to have an empty hand is called Durak,"+" which is the loser.  There are two roles, the players take (The attacker and Defender). "
                                            +"The person who begins the game with the lowest trump card is the attacker while the other player is the defender. "
                                            +"The attacker goes first and plays a card , the defender must be able to defend the attack or else the played card goes into the defenders hand.  "
                                            +"Once the attacker can not attack again or the defender can't defend then the round is finshed and the roles are switched,  "
                                            +"If the players hand has less than six cards then they must draw cards from the deck until they have six.  "
                                            +"If they have more than six cards at the end of the round, then there is no need to draw more cards.  "
                                            +"The game continues until the deck is empty which symbolizes the final set of rounds in which the person to lose all the cards in their hand "
                                            +"is declared the Durak.";
            // 
            // tbVideo
            // 
            this.tbVideo.Location = new System.Drawing.Point(4, 22);
            this.tbVideo.Name = "tbVideo";
            this.tbVideo.Size = new System.Drawing.Size(710, 276);
            this.tbVideo.TabIndex = 3;
            this.tbVideo.Text = "Video Demo";
            this.tbVideo.UseVisualStyleBackColor = true;
            // 
            // Tutorial
            // 

            this.Name = "pnlInstructionPage";
            this.ClientSize = new System.Drawing.Size(760, 366);
            this.Controls.Add(this.pbBackScreen);
            this.Controls.Add(this.tbInstructions);
            this.BackgroundImage = Properties.Resources.mainMenuCombinedBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Text = "Tutorial";
            this.tbInstructions.ResumeLayout(false);
            this.tbRules.ResumeLayout(false);
            this.tbAttacker.ResumeLayout(false);
            this.tbDefense.ResumeLayout(false);
            this.ResumeLayout(false);

            this.Dock = DockStyle.Fill;

        }

        /// <summary>
        /// Click handler for the back picturebox button, 
        /// sends the user back to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbBackScreen_Click(object sender, EventArgs e)
        {
            //Goto Main Menu options
            if (this.Parent is Form)
                (this.Parent as PlayDurak).SetScreen(PlayDurak.Screen.MainMenu);
        }

       private System.Windows.Forms.TabControl tbInstructions;
       private System.Windows.Forms.TabPage tbRules;
       private System.Windows.Forms.TabPage tbAttacker;
       private System.Windows.Forms.TabPage tbDefense;
       private System.Windows.Forms.Label lblDefendDescript;
       private System.Windows.Forms.Label lblDefend;
       private System.Windows.Forms.Label lblAttackDescrip;
       private System.Windows.Forms.Label lblAttack;
       private System.Windows.Forms.Label lblRulesDescription;
       private System.Windows.Forms.Label lblRules;
       private System.Windows.Forms.TabPage tbVideo;
       private PictureBox pbBackScreen;
    }
    
}
