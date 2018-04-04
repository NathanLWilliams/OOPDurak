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
                this.button1 = new System.Windows.Forms.Button();
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
                // button1
                // 
                this.button1.Location = new System.Drawing.Point(563, 321);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(201, 45);
                this.button1.TabIndex = 1;
                this.button1.Text = "Close";
                this.button1.UseVisualStyleBackColor = true;
                // 
                // tbInstructions
                // 
                this.tbInstructions.Controls.Add(this.tbRules);
                this.tbInstructions.Controls.Add(this.tbAttacker);
                this.tbInstructions.Controls.Add(this.tbDefense);
                this.tbInstructions.Controls.Add(this.tbVideo);
                this.tbInstructions.Location = new System.Drawing.Point(30, 13);
                this.tbInstructions.Name = "tbInstructions";
                this.tbInstructions.SelectedIndex = 0;
                this.tbInstructions.Size = new System.Drawing.Size(718, 302);
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
                this.lblDefendDescript.Location = new System.Drawing.Point(3, 63);
                this.lblDefendDescript.Name = "lblDefendDescript";
                this.lblDefendDescript.Size = new System.Drawing.Size(692, 201);
                this.lblDefendDescript.TabIndex = 2;
                this.lblDefendDescript.Text = "Description goes here";
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
                this.lblAttackDescrip.Size = new System.Drawing.Size(692, 228);
                this.lblAttackDescrip.TabIndex = 3;
                this.lblAttackDescrip.Text = "Description goes here";
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
                this.lblRulesDescription.Location = new System.Drawing.Point(9, 45);
                this.lblRulesDescription.Name = "lblRulesDescription";
                this.lblRulesDescription.Size = new System.Drawing.Size(692, 218);
                this.lblRulesDescription.TabIndex = 4;
                this.lblRulesDescription.Text = "Description goes here";
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
            
                this.ClientSize = new System.Drawing.Size(760, 366);
                this.Controls.Add(this.tbInstructions);
                this.Controls.Add(this.button1);
                this.Text = "Tutorial";
                this.tbInstructions.ResumeLayout(false);
                this.tbRules.ResumeLayout(false);
                this.tbAttacker.ResumeLayout(false);
                this.tbDefense.ResumeLayout(false);
                this.ResumeLayout(false);

            this.Dock = DockStyle.Fill;


            }

        
       private System.Windows.Forms.Button button1;
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
    }
    
}
