using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class StatisticsPage : Panel
    {
        public StatisticsPage()
        {
            this.pbBackScreen = new PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDTimePlayed = new System.Windows.Forms.Label();
            this.lblPTotalGamesPlayed = new System.Windows.Forms.Label();
            this.lblDTotalWins = new System.Windows.Forms.Label();
            this.lblDTotalGames = new System.Windows.Forms.Label();
            this.lblPTimePlayed = new System.Windows.Forms.Label();
            this.lblPTotalWins = new System.Windows.Forms.Label();
            this.game = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            // BackScreenPictureBox
            //
            this.pbBackScreen.BackColor = System.Drawing.Color.Transparent;
            this.pbBackScreen.Image = Properties.Resources.goback;
            this.pbBackScreen.Location = new System.Drawing.Point(32, 30);
            this.pbBackScreen.Name = "pbBackScreen";
            this.pbBackScreen.Size = new System.Drawing.Size(88, 83);
            this.pbBackScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackScreen.TabIndex = 4;
            this.pbBackScreen.TabStop = false;
            this.pbBackScreen.Click += PbBackScreen_Click;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Cooper Black", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTitle.Location = new System.Drawing.Point(30, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1124, 78);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Games Stats";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.game,
                this.Status,
                this.Date,
                this.TimeTaken});
            this.dataGridView1.Location = new System.Drawing.Point(41, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 409);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblDTimePlayed);
            this.panel1.Controls.Add(this.lblPTotalGamesPlayed);
            this.panel1.Controls.Add(this.lblDTotalWins);
            this.panel1.Controls.Add(this.lblDTotalGames);
            this.panel1.Controls.Add(this.lblPTimePlayed);
            this.panel1.Controls.Add(this.lblPTotalWins);
            this.panel1.Location = new System.Drawing.Point(41, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 184);
            this.panel1.TabIndex = 2;
            // 
            // lblDTimePlayed
            // 
            this.lblDTimePlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTimePlayed.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDTimePlayed.Location = new System.Drawing.Point(753, 34);
            this.lblDTimePlayed.Name = "lblDTimePlayed";
            this.lblDTimePlayed.Size = new System.Drawing.Size(192, 23);
            this.lblDTimePlayed.TabIndex = 7;
            this.lblDTimePlayed.Text = "2 day 11hr 55min";
            // 
            // lblPTotalGamesPlayed
            // 
            this.lblPTotalGamesPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTotalGamesPlayed.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPTotalGamesPlayed.Location = new System.Drawing.Point(19, 97);
            this.lblPTotalGamesPlayed.Name = "lblPTotalGamesPlayed";
            this.lblPTotalGamesPlayed.Size = new System.Drawing.Size(100, 23);
            this.lblPTotalGamesPlayed.TabIndex = 4;
            this.lblPTotalGamesPlayed.Text = "Games Played :";
            // 
            // lblDTotalWins
            // 
            this.lblDTotalWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTotalWins.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDTotalWins.Location = new System.Drawing.Point(174, 34);
            this.lblDTotalWins.Name = "lblDTotalWins";
            this.lblDTotalWins.Size = new System.Drawing.Size(100, 23);
            this.lblDTotalWins.TabIndex = 3;
            this.lblDTotalWins.Text = "44";
            // 
            // lblDTotalGames
            // 
            this.lblDTotalGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTotalGames.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDTotalGames.Location = new System.Drawing.Point(174, 97);
            this.lblDTotalGames.Name = "lblDTotalGames";
            this.lblDTotalGames.Size = new System.Drawing.Size(100, 23);
            this.lblDTotalGames.TabIndex = 2;
            this.lblDTotalGames.Text = "151";
            // 
            // lblPTimePlayed
            // 
            this.lblPTimePlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTimePlayed.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPTimePlayed.Location = new System.Drawing.Point(536, 34);
            this.lblPTimePlayed.Name = "lblPTimePlayed";
            this.lblPTimePlayed.Size = new System.Drawing.Size(175, 23);
            this.lblPTimePlayed.TabIndex = 1;
            this.lblPTimePlayed.Text = "Total Time Played :";
            // 
            // lblPTotalWins
            // 
            this.lblPTotalWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTotalWins.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPTotalWins.Location = new System.Drawing.Point(19, 34);
            this.lblPTotalWins.Name = "lblPTotalWins";
            this.lblPTotalWins.Size = new System.Drawing.Size(100, 23);
            this.lblPTotalWins.TabIndex = 0;
            this.lblPTotalWins.Text = "Total Wins : ";
            // 
            // game
            // 
            this.game.HeaderText = "Game Type";
            this.game.Name = "game";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // TimeTaken
            // 
            this.TimeTaken.HeaderText = "TimeTaken";
            this.TimeTaken.Name = "TimeTaken";
            // 
            // Statspage
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pbBackScreen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Statspage";
            this.Text = "Statspage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

            this.Name = "pnlStatisticsPage";
            this.BackgroundImage = Properties.Resources.mainMenuCombinedBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Goes back to the main menu screen upon pressing a button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbBackScreen_Click(object sender, EventArgs e)
        {
            //Goto Main Menu options
            if (this.Parent is Form)
                (this.Parent as PlayDurak).SetScreen(PlayDurak.Screen.MainMenu);
        }

        private PictureBox pbBackScreen;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDTimePlayed;
        private System.Windows.Forms.Label lblPTotalGamesPlayed;
        private System.Windows.Forms.Label lblDTotalWins;
        private System.Windows.Forms.Label lblDTotalGames;
        private System.Windows.Forms.Label lblPTimePlayed;
        private System.Windows.Forms.Label lblPTotalWins;
        private System.Windows.Forms.DataGridViewTextBoxColumn game;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeTaken;

    }
}
