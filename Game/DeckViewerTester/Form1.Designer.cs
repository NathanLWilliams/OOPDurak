namespace DeckViewerTester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRemoveCard = new System.Windows.Forms.Button();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.deckViewer1 = new Game.DeckViewer();
            this.numCardToRemove = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numCardToRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveCard
            // 
            this.btnRemoveCard.Location = new System.Drawing.Point(369, 365);
            this.btnRemoveCard.Name = "btnRemoveCard";
            this.btnRemoveCard.Size = new System.Drawing.Size(138, 23);
            this.btnRemoveCard.TabIndex = 5;
            this.btnRemoveCard.Text = "Remove Card At:";
            this.btnRemoveCard.UseVisualStyleBackColor = true;
            this.btnRemoveCard.Click += new System.EventHandler(this.btnRemoveCard_Click);
            // 
            // btnAddCard
            // 
            this.btnAddCard.Location = new System.Drawing.Point(288, 365);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(75, 23);
            this.btnAddCard.TabIndex = 4;
            this.btnAddCard.Text = "Add Card";
            this.btnAddCard.UseVisualStyleBackColor = true;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // deckViewer1
            // 
            this.deckViewer1.BackColor = System.Drawing.Color.Lime;
            this.deckViewer1.Location = new System.Drawing.Point(64, 55);
            this.deckViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deckViewer1.Name = "deckViewer1";
            this.deckViewer1.Size = new System.Drawing.Size(750, 276);
            this.deckViewer1.TabIndex = 7;
            // 
            // numCardToRemove
            // 
            this.numCardToRemove.Location = new System.Drawing.Point(522, 368);
            this.numCardToRemove.Name = "numCardToRemove";
            this.numCardToRemove.Size = new System.Drawing.Size(120, 20);
            this.numCardToRemove.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 505);
            this.Controls.Add(this.numCardToRemove);
            this.Controls.Add(this.deckViewer1);
            this.Controls.Add(this.btnRemoveCard);
            this.Controls.Add(this.btnAddCard);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numCardToRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRemoveCard;
        private System.Windows.Forms.Button btnAddCard;
        private Game.DeckViewer deckViewer1;
        private System.Windows.Forms.NumericUpDown numCardToRemove;
    }
}

