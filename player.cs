using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Player
    {
        public string name{get; set;}
        public List<Card> hand = new List<Card>();


        public Player(string n)
        {
            name = n;
        }
        public void Hit(Deck deck)
        {
            hand.Add(deck.deal());
        }
        public override string ToString()
        {
            string str = "";
            foreach (Card card in hand)
            {
                str += card.val + "\n";
            }
            return str;
        }
    }
}