using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Game
    {
        Dealer Dealer; //3 īpašības
        Player Player;
        Deck Deck;



 public void StartNewGame()
        {
            // Create players - dealer and player.
          Dealer= new Dealer();
          Player = new Player();
            // Create a new card deck. Shuffle it.
            Deck = new Deck();
            Deck.Shuffle();

            // Take two cards from the deck and give it to player.
            Console.WriteLine("Player receives cards: ");
            Player.GiveCard(Deck.GetCard());
            Player.GiveCard(Deck.GetCard());
            // Take two cards from the deck and give it to dealer.
            
            Dealer.GiveCard(Deck.GetCard());
            Dealer.GiveCard(Deck.GetCard());
        }

        // Give player a new card from the deck while his points are not over 21 and he wants another card.
        //while(...) Player.CountPoints() Player.WantCard()
        // If player’s points are over 21, player loses, otherwise - dealer’s turn.
        // Give dealer a new card from the deck while his points are not over 21 and he wants another card.
        //while(...) Dealer.CountPoints() Dealer.WantCard()
        // Output points for both players.
        //Console.WriteLine() Player.CountPoints() DealerCountPoints()
        // If dealer’s points are over 21, player wins, otherwise check who was closer to 21.
        public void Loop()
        {
            Console.WriteLine("Player turn: ");
            //kamēr nav virs 21 un kamer velas papildu karti
            while (!Player.IsGameCompleted() && Player.WantCard())
            {
                //piešķiram jaunu karti no karšu kavas
                Player.GiveCard(Deck.GetCard());
            }
            //ja spēlētajam ir virs 21 -> spelētājs zaudē
            if (Player.IsGameCompleted())
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("Dealer turn: ");
                // kamēr dilerim nav virs 21 un kamer velas karti
                while (!Dealer.IsGameCompleted() && Dealer.WantCard())
                {
                    //piešķiram jaunu karti no karšu kavas
                    Dealer.GiveCard(Deck.GetCard());
                }
                int playerPoints = Player.CountPoints();
                int dealerPoints = Dealer.CountPoints();
                Console.WriteLine("Your points: {0}", playerPoints);
                Console.WriteLine("Dealer points: {0}", dealerPoints);

                if (dealerPoints > 21 || playerPoints > dealerPoints)
                {
                    Console.WriteLine("You win!");
                }
                else if (dealerPoints > playerPoints)
                {
                    Console.WriteLine("Dealer wins!");
                }
                else
                {
                    Console.WriteLine("No winner!");
                }
            }
        }

    }
}
