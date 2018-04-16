using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    // this class will be Game setup class for game screen
    public class DurakGame
    {
        private void InitializeDurakGame()
        {
            // call all other setup methods to initialize game
            this.SetUpPlayerInformation();
            this.SetUpPlayerHand();
            this.InitializeDeck((int) Deck.Size.Small);
          
        }
        private void SetUpPlayerInformation()
        {
            // set player name()
            // set player Image()
            // set player score()
           
        }

        private void InitializeDeck(int DeckSize)
        {
            // gets deck size from playing options page
            // and initializes deck on left deckviewer() with trum card in horizontal position
        }
        
        private void SetUpPlayerHand()
        {
            // sets up players(AI/Human) hand gives cards from deck

            // For current human player cards are given in lower deckviwer hand
            // for Ai player cards are given face down in upper deckviewer in small size according to deck

        }



    }
}
