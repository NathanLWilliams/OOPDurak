using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckViewerTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            deckViewer1.AddCard();
        }

        private void btnRemoveCard_Click(object sender, EventArgs e)
        {
            deckViewer1.RemoveCard((int)numCardToRemove.Value);
        }
    }
}
