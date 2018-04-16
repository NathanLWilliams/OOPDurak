/*
 * CardBox.cs
 * @Author : Qasim Iqbal
 * @since  : March 03, 2018
 * @see    : https://www.youtube.com/watch?v=gK6bJ9IudW8&t=87s Thom MacDonald's Youtube Video on CardBox
 */
namespace CardBoxControl
{
    partial class CardBox
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbCardDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCardDisplay
            // 
            this.pbCardDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCardDisplay.Location = new System.Drawing.Point(0, 0);
            this.pbCardDisplay.Name = "pbCardDisplay";
            this.pbCardDisplay.Size = new System.Drawing.Size(173, 264);
            this.pbCardDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCardDisplay.TabIndex = 0;
            this.pbCardDisplay.TabStop = false;
            this.pbCardDisplay.Click += new System.EventHandler(this.pbCardDisplay_Click);
            
            this.pbCardDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCardDisplay_MouseDown);
            this.pbCardDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbCardDisplay_MouseMove);
            //this.pbCardDisplay.DragDrop  +=  PbCardDisplay_DragDrop;
            //this.pbCardDisplay.DragEnter += PbCardDisplay_DragEnter;
            // 
            // CardBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbCardDisplay);
            this.Name = "CardBox";
            this.Size = new System.Drawing.Size(173, 264);
            this.Load += new System.EventHandler(this.CardBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCardDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbCardDisplay;
    }
}
