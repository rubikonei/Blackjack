using System;
using System.Collections.Generic;

namespace BlackjackGame
{
    public class Player
    {
        public List<Card> Cards { get; set; }
        public int Points { get; set; }
        public bool IsEnough { get; set; }
        public int RoundsWon { get; set; }
        public PointsCounter Counter { get; set; }
        public Player()
        {
            Cards = new List<Card>();
            Counter = new PointsCounter(Cards);
        }
        public virtual void TakeCard(Card card)
        {
            if (!IsEnough)
            {
                Cards.Add(card);
                Points = Counter.CountPoints();
                if (Points >= Rules.MaxPoints)
                {
                    IsEnough = true;
                }
            }
        }
        public override string ToString()
        {
            string result = "";
            foreach (Card card in Cards)
            {
                result += String.Format("{0} {1}; ", card.Suit.ToString(), card.Dignity.ToString());
            }
            return String.Format("Cards: {0}Points: {1}", result, Points);
        }
    }
}
