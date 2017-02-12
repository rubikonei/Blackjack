using System;
using System.Linq;

namespace BlackjackGame
{
    public class Dealer : Player
    {
        public CardDeck CardDeck { get; set; }
        public Dealer()
        {
            CardDeck = new CardDeck();
        }
        public Card GiveCard()
        {
            Random r = new Random();
            int cardIndex = r.Next(0, CardDeck.Deck.Count);
            Card card = CardDeck.Deck.ElementAt(cardIndex);
            CardDeck.Deck.RemoveAt(cardIndex);
            return card;
        }
        public override void TakeCard(Card card)
        {
            base.TakeCard(card);
            if (Points >= Rules.DealerMinPoints)
            {
                IsEnough = true;
            }
        }
    }
}
