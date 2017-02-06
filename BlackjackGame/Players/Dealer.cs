using System;
using System.Linq;

namespace BlackjackGame
{
    public class Dealer : Player
    {
        private CardDeck cardDeck;
        public Dealer()
        {
            cardDeck = new CardDeck();
        }
        public Card GiveCard()
        {
            Random r = new Random();
            int cardIndex = r.Next(0, cardDeck.Deck.Count);
            Card card = cardDeck.Deck.ElementAt(cardIndex);
            cardDeck.Deck.RemoveAt(cardIndex);
            return card;
        }
        public override void TakeCard(Card card)
        {
            base.TakeCard(card);
            if (Points >= 17)
            {
                IsEnough = true;
            }
        }
    }
}
