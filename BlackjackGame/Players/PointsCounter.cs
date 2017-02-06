using System.Collections.Generic;

namespace BlackjackGame
{
    public class PointsCounter
    {
        private List<Card> cards;
        private Dictionary<Dignity, int> cardsPoints;
        public PointsCounter(List<Card> cards)
        {
            InitializeCardsPoints();
            this.cards = cards;
        }
        public int CountPoints()
        {
            int result = 0;
            foreach (Card card in cards)
            {
                result += cardsPoints[card.Dignity];
            }
            if (result > 21)
            {
                cardsPoints[Dignity.Ace] = 1;
                result = 0;
                foreach (Card card in cards)
                {
                    result += cardsPoints[card.Dignity];
                }
                return result;
            }
            else
            {
                return result;
            }
        }
        private void InitializeCardsPoints()
        {
            cardsPoints = new Dictionary<Dignity, int>();
            cardsPoints.Add(Dignity.Two, 2);
            cardsPoints.Add(Dignity.Three, 3);
            cardsPoints.Add(Dignity.Four, 4);
            cardsPoints.Add(Dignity.Five, 5);
            cardsPoints.Add(Dignity.Six, 6);
            cardsPoints.Add(Dignity.Seven, 7);
            cardsPoints.Add(Dignity.Eight, 8);
            cardsPoints.Add(Dignity.Nine, 9);
            cardsPoints.Add(Dignity.Ten, 10);
            cardsPoints.Add(Dignity.Jack, 10);
            cardsPoints.Add(Dignity.Queen, 10);
            cardsPoints.Add(Dignity.King, 10);
            cardsPoints.Add(Dignity.Ace, 11);
        }
    }
}
