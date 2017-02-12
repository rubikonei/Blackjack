using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class Game
    {
        public Player player = new Player();
        public Dealer dealer = new Dealer();
        public void Reset()
        {
            player.IsEnough = false;
            player.Points = 0;
            player.Cards = new List<Card>();
            player.Counter = new PointsCounter(player.Cards);
            dealer.IsEnough = false;
            dealer.Points = 0;
            dealer.Cards = new List<Card>();
            dealer.Counter = new PointsCounter(dealer.Cards);
            dealer.CardDeck = new CardDeck();
        }
        public void CardsDistribution()
        {
            player.TakeCard(dealer.GiveCard());
            player.TakeCard(dealer.GiveCard());
            dealer.TakeCard(dealer.GiveCard());
            dealer.TakeCard(dealer.GiveCard());
            if (player.Points >= Rules.MaxPoints || dealer.Points >= Rules.MaxPoints)
            {
                player.IsEnough = true;
                dealer.IsEnough = true;
                WinnerDefinition(player, dealer);
            }
        }
        public void Circle()
        {
            if (!player.IsEnough)
            {
                player.TakeCard(dealer.GiveCard());
            }
            if (!dealer.IsEnough)
            {
                dealer.TakeCard(dealer.GiveCard());
            }
            if (player.Points >= Rules.MaxPoints || dealer.Points >= Rules.MaxPoints ||
                (player.IsEnough && dealer.IsEnough))
            {
                player.IsEnough = true;
                dealer.IsEnough = true;
                WinnerDefinition(player, dealer);
            }
        }
        private void WinnerDefinition(Player player, Dealer dealer)
        {
            if ((player.Points > Rules.MaxPoints && dealer.Points <= Rules.MaxPoints) || 
                (player.Points < dealer.Points && dealer.Points <= Rules.MaxPoints))
            {
                dealer.RoundsWon++;
            }
            else if ((dealer.Points > Rules.MaxPoints && player.Points <= Rules.MaxPoints) ||
                (dealer.Points < player.Points && player.Points <= Rules.MaxPoints))
            {
                player.RoundsWon++;
            }
            else
            {
                player.RoundsWon++;
                dealer.RoundsWon++;
            }
        }
    }
}
