using System;
using System.Collections.Generic;

namespace BlackjackGame
{
    public class Player
    {
        public bool IsEnough { get; set; }
        protected List<Card> cards;
        protected PointsCounter counter;
        public int Points { get; protected set; }
        public Player()
        {
            cards = new List<Card>();
            counter = new PointsCounter(cards);
        }
        public virtual void TakeCard(Card card)
        {
            if (!IsEnough)
            {
                cards.Add(card);
                Points = counter.CountPoints();
                if (Points >= 21)
                {
                    IsEnough = true;
                }
            }
        }
        public override string ToString()
        {
            string result = "";
            foreach (Card card in cards)
            {
                result += String.Format("{0} {1}; ", card.Suit.ToString(), card.Dignity.ToString());
            }
            return String.Format("Cards: {0}Points: {1}", result, Points);
        }
    }
}
