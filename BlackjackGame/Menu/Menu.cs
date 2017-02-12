using System;

namespace BlackjackGame
{
    public class Menu
    {
        private Game game = new Game();
        public void Show()
        {
            game.CardsDistribution();
            while (!game.player.IsEnough || !game.dealer.IsEnough)
            {
                Console.Clear();
                Console.WriteLine("Answers: click 'Y' - YES, 'N' - NO");
                Console.WriteLine("Player: {0}", game.player);
                Console.WriteLine("Dealer: {0}", game.dealer);
                if (game.player.IsEnough == false)
                {
                    Console.WriteLine("Would you like to take card?");
                    string answerToTakeNextCard = Console.ReadLine();
                    switch (answerToTakeNextCard.ToLower())
                    {
                        case "y":
                            game.player.IsEnough = false;
                            break;
                        case "n":
                            game.player.IsEnough = true;
                            break;
                        default:
                            Console.WriteLine("Неизвестная комманда");
                            break;
                    }
                }
                game.Circle();
            }
            Console.Clear();
            Console.WriteLine("Answers: click 'Y' - YES, 'N' - NO");
            Console.WriteLine("Player: {0}", game.player);
            Console.WriteLine("Dealer: {0}", game.dealer);
            Console.WriteLine("Rounds Won: Player: {0}, Dealer: {1}", game.player.RoundsWon, game.dealer.RoundsWon);
            Console.WriteLine("Next Round?");
            string answerToPlayNextRound = Console.ReadLine();
            switch (answerToPlayNextRound.ToLower())
            {
                case "y":
                    game.Reset();
                    Show();
                    break;
                case "n":
                    Console.Clear();
                    Console.WriteLine("Rounds Won: Player: {0}, Dealer: {1}", game.player.RoundsWon, game.dealer.RoundsWon);
                    break;
                default:
                    Console.WriteLine("Неизвестная комманда");
                    break;
            }
        }
    }
}
