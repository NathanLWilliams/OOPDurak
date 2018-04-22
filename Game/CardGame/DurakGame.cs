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

          



            


           

            //bout panel will  be empty


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

            //deckViewer class displays one card where the suit will be the
            // trump card

            // and initializes deck on left deckviewer() with trum card in horizontal position
        }

        private void SetUpPlayerHand()
        {
            //player hand (player panel) will draw 6 cards from the deck and 
            // be facing up

            // AI hand (AI panel) will draw 6 cards from the deck and be facing down

            // For current human player cards are given in lower deckviwer hand
            // for Ai player cards are given face down in upper deckviewer in small size according to deck


        }

        private void GamePlay()
        {


            //Assigning Attack or Defender by compare trump cards in the AI hand and player Hand
            {
                //The person with the lowest trump card ( lower face value of the trump suit) is the attacker 

                //The other person is the defender
            }

            //The following proccess keeps goings until the deck reaches 0
            //Once the deck is empty no one draws cards at the end of the round and game finishes when one person
            // has an empty hand.

            //Attacker goes first
            {
                // pick a card from their hand and place it in the bout
                // end turn ( defenders move)
            }


            //Defender Turn
            {
                // he can only play a card that is the same suit and Higher face value as the attacker's card 
                //OR a trump card of any face value. (defend Succsess)

                //IF ATTACKER PLAYS A TRUMP CARD, THEN DEFENDER MUST PLAY A CARD OF THE SAME SUIT 
                // AND HIGHER VALUE 
            }

            //More Attack
            {
                // Attacker can attack again if he a card in his hand is the same face
                // value (can be different suit) as any card in the bout ( set to true)

                //if not set to false
                //        then delete/discard cards in bout panel
                //        end turn and draws cards from the deck into both player hand and AI hand
                //        if less than 6 (draw card to 6 )
                //        else if hands more than 6( do nothing and roles are switched)

                        
                        
             }

            //Two outcomes Defend Successful and Defend Unsuccessful
            //Defend Successful 
            {
                //Attacker's turn -see if they can attack again


            }


            //Defend Unsuccessful
            {
                //cards in bout panel gets added to the defenders hand and rounds ends.
                //draw cards from deck to 6 (if hand count is less than 6 else hand count > 6 do nothing)

                //roles are switched defender becomes attacker, 
                //attacker becomes defender

            }
        }

    }
}
