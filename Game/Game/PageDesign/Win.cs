/* Win.cs
 * Group 9 (Nathan Williams, Jonathan Hermans, Karence Ma, Qasim Iqbal)
 * Date: 27/4/18
 * Description: A panel to be added and displayed on the form when a durak game ends, it displays the games result
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    class Win : Panel
    {
        
        public Win()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblStatuts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblStatuts
            // 
            this.lblStatuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatuts.Location = new System.Drawing.Point(2, 9);
            this.lblStatuts.Name = "lblStatuts";
            this.lblStatuts.Size = new System.Drawing.Size(429, 141);
            this.lblStatuts.TabIndex = 3;
            this.lblStatuts.Text = "";
            this.lblStatuts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientSize = new System.Drawing.Size(433, 228);
            this.Controls.Add(this.lblStatuts);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

         //setting the context of the label from other forms
        public string LabelText
        {
            get
            {
                return this.lblStatuts.Text;
            }
            set
            {

                this.lblStatuts.Text = value;
            }
        }
        
         private void button3_Click(object sender, EventArgs e)
        {
            //exit the program
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Goto Main Menu
            if (this.Parent.Parent is Form)
                (this.Parent.Parent as PlayDurak).SetScreen(PlayDurak.Screen.MainMenu);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblStatuts;
    }
}
