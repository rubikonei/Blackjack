namespace BlackjackGame
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Dignity Dignity { get; set; }
        public Card(Suit suit, Dignity dignity)
        {
            Suit = suit;
            Dignity = dignity;
        }
    }
}
