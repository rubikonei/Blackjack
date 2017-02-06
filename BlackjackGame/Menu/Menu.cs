using System;

namespace BlackjackGame
{
    public class Menu
    {
        Dealer dealer = new Dealer();
        Player player = new Player();
        public void Show()
        {
            player.TakeCard(dealer.GiveCard());
            player.TakeCard(dealer.GiveCard());
            dealer.TakeCard(dealer.GiveCard());
            dealer.TakeCard(dealer.GiveCard());
            while (!player.IsEnough || !dealer.IsEnough)
            {
                Console.Clear();
                Console.WriteLine("Answers: click 'Y' - YES, 'N' - NO");
                Console.WriteLine("Player: {0}", player);
                Console.WriteLine("Dealer: {0}", dealer);
                Console.WriteLine("Would you like to take card?");
                string answer = Console.ReadLine();
                switch (answer.ToLower())
                {
                    case "y":
                        player.TakeCard(dealer.GiveCard());
                        break;
                    case "n":
                        player.IsEnough = true;
                        break;
                    default:
                        Console.WriteLine("Неизвестная комманда");
                        break;
                }
                dealer.TakeCard(dealer.GiveCard());
            }
            Console.Clear();
            Console.WriteLine("Player: {0}", player);
            Console.WriteLine("Dealer: {0}", dealer);
            Console.WriteLine(winnerDefinition(player, dealer));
            Console.ReadKey();

        }
        private string winnerDefinition(Player player, Dealer dealer)
        {
            string result;
            if (player.Points > 21 && dealer.Points <= 21)
            {
                result = "The Winnet is Dealer";
            }
            else if (dealer.Points > 21 && player.Points <= 21)
            {
                result = "The Winner is Player";
            }
            else if (player.Points < dealer.Points && dealer.Points <= 21)
            {
                result = "The Winnet is Dealer";
            }
            else if (dealer.Points < player.Points && player.Points <= 21)
            {
                result = "The Winner is Player";
            }
            else
            {
                result = "No Winner";
            }
            return result;
        }
    }
}
