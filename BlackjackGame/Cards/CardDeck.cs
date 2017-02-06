using System;
using System.Collections.Generic;

namespace BlackjackGame
{
    public class CardDeck
    {
        public List<Card> Deck { get; set; }
        public CardDeck()
        {
            InitializeDeck();
        }
        private void InitializeDeck()
        {
            Deck = new List<Card>();
            Array suits = Enum.GetValues(typeof(Suit));
            Array dignities = Enum.GetValues(typeof(Dignity));
            foreach (Suit suit in suits)
            {
                foreach (Dignity dignity in dignities)
                {
                    Deck.Add(new Card(suit, dignity));
                }
            }
        }
    }
}
