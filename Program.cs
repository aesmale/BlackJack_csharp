using System;

namespace Blackjack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            // Console.WriteLine(myDeck);
            myDeck.shuffle();
            Player player1 = new Player("Joe");
            Player dealer = new Player("dealer");
            // Console.WriteLine(player1.name);
            // Console.WriteLine(dealer.name);
            // Console.WriteLine(myDeck);
            player1.Hit(myDeck);
            player1.Hit(myDeck);
            dealer.Hit(myDeck);
            dealer.Hit(myDeck);
            // Console.WriteLine(player1.hand);
            int player_total = 0;
            int dealer_total = 0;
            Console.WriteLine("Player Cards: ");
            foreach (var card in player1.hand)
            {
                Console.Write(card.val + ", ");
                player_total += card.numVal;
                
            }
            foreach (var card in dealer.hand)
            {
                dealer_total += card.numVal;
                
            }
            while(player_total < 21)
            {
                Console.WriteLine("player your current total is: " + player_total);
                Console.WriteLine("Would you like to hit or stay?");
                string response = Console.ReadLine();
                if (response == "hit")
                {
                    player1.Hit(myDeck);
                    player_total = 0;
                    foreach (var card in player1.hand)
                    {
                        player_total += card.numVal;
                    }
                }
                else
                {
                    break;
                }
            }
            if(player_total > 21)
            {
                Console.WriteLine("Player total: " + player_total);
                Console.WriteLine("Player BUSTED");
                return;
            }
            while (dealer_total < 15)
            {

                dealer.Hit(myDeck);
                dealer_total = 0;
                foreach(var card in dealer.hand)
                {
                    dealer_total += card.numVal;
                }
            }
            if (dealer_total > 21)
            {
                Console.WriteLine("Dealer busts, you win!");
                Console.WriteLine("Player total: " + player_total);
                Console.WriteLine("Dealer total: " + dealer_total);
            }
            
            else if (dealer_total > player_total)
            {
                Console.WriteLine("Dealer is winner!");
                Console.WriteLine("Player total: " + player_total);
                Console.WriteLine("Dealer total: " + dealer_total);

            }
            
            else if (player_total > dealer_total)
            {
                Console.WriteLine("Player is winner!");
                Console.WriteLine("Player total: " + player_total);
                Console.WriteLine("Dealer total: " + dealer_total);
            }
            
            else
            {
                Console.WriteLine("draw");
                Console.WriteLine("Player total: " + player_total);
                Console.WriteLine("Dealer total: " + dealer_total);
            }
            
        }
    }
}
