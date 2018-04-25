﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardGame
{
    public class Hand : Cards
    {

        //Instance attribute- should be card collection
        Cards playerHand = new Cards();
        private int numberOfCardsInHand = 0;
        //default constructor for cards
        public Hand(ref Cards cardCollection, int cardsToTake)
        {
            for (int i = 0; i < cardsToTake; i++)
            {
                playerHand.Add(cardCollection[i]);
            }
        }
        //default constructor for cards
        public Hand(Cards cardCollection)
        {
            foreach (Card card in cardCollection)
            {
                playerHand.Add(card);
            }
        }
        //default constructor
        //public Hand(ref Cards cardCollection, int cardsToTake)
        //{
        //    for (int i = 0; i < cardsToTake; i++)
        //    {
        //        playerHand.Add(cardCollection[i]);
        //    }
        //}

        //parameterized constructor

        public Hand(Hand newHand)
        {
            playerHand = newHand;
        }

        //clone method
        //public object Clone()
        //{
        //    Hand newHand = new Hand(playerHand.Clone() as Cards);
        //    return newHand;
        //}

        //Add Card to player hands method
        public void AddCard(Card card)
        {
            playerHand.Add(card);
            //keep track of how many cards are in hand
            numberOfCardsInHand = playerHand.Count;
        }

        //Add Many Cards to Hand- during end of round

        public void RefillCards(Cards cards)
        {
           
            for (int i=0; i < cards.Count; i++)
            {//as long as cards in player's hand less than 6
                if (playerHand.Count < 6)
                {
                    playerHand.Add(cards[i]);
                }
               
            }
            //keeping track of the number of cards in hand
            numberOfCardsInHand = playerHand.Count;
        }

        // Remove a card from hand
        public void RemoveCard(Card card)
        {
            playerHand.Remove(card);
            //keeping track of the number of cards in hand
            numberOfCardsInHand = playerHand.Count;
        }
    }
}