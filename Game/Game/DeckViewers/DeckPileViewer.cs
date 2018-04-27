using CardBoxControl;
using CardGame;
using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class DeckPileViewer : DeckViewer
    {

        public DeckPileViewer() : base()
        {
            Deck deck = new Deck(Deck.Size.Medium, true);
            this.DrawCards(deck, deck.Count);
            this.AllowDrop = false;
        }
        public DeckPileViewer(Deck deck) : base(deck)
        {
        }
        public override void AdjustCards()
        {
            if(isChanged)
            {
                UpdateCardBoxes(false);
                // Determine the number of cards/controls in the panel.
                int myCount = this.Controls.Count;
                // If there are any cards in the panel
                if (myCount > 0)
                {
                    // Determine how wide one card/control is.
                    int cardWidth = this.Controls[0].Width;
                    // Determine where the lefthand edge of a card/ control placed
                    // in the middle of the panel should be
                    int startPoint = (this.Width - cardWidth) / 2;
                    // An offset for the remaining cards
                    int offset = 0;

                    // If there are more than one cards/controls in the panel
                    if (myCount > 1)
                    {
                        // Determine what the offset should be for each card based onthe
                        // space available and the number of card/controls
                        offset = (this.Width - cardWidth - 50) / (myCount - 1);
                        // If the offset is bigger than the card/control width, i.e.there is lots of room,
                        // set the offset to the card width. The cards/controls willnot overlap at all.
                        if (offset > cardWidth)
                            offset = cardWidth;
                        // Determine width of all the cards/controls
                        int allCardsWidth = (myCount - 1) * offset + cardWidth;
                        // Set the start point to where the lefthand edge of the "first" card should be.
                        startPoint = (this.Width - allCardsWidth) / 2;
                    }
                    // Aligning the cards: Note that I align them in reserve order from how they
                    // are stored in the controls collection. This is so that cardson the left
                    // appear underneath cards to the right. This allows the user to see the rank
                    // and suit more easily.
                    // Align the "first" card (which is the last control in the collection) 
                    this.Controls[myCount - 1].Left = startPoint;
                    // for each of the remaining controls, in reverse order.
                    for (int index = myCount - 2; index >= 0; index--)
                    {
                        // Align the current card
                        this.Controls[index].Left = this.Controls[index + 1].Left + offset;
                    }
                }
                isChanged = false;
            }
        }
    }
}
