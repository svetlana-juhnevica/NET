using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deck
    {
        // kāršu komplekta kartis
        List<Card> Cards;
        //Creates a new, empty list of cards (List<Card>). Fills list with all 52 cards (4 suits and 13 ranks)
        public Deck()
        {
            string[] suits = { "H", "C", "S", "D" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "K", "Q", "J" };
            Cards = new List<Card>();
            //Cards.Add(new Card("2", "H")); tak nado bilo bi 52 strochki dlja kazhdoj karti
           // Cards.Add(new Card("3", "H"));
           foreach(string s in suits)
            {
                foreach(string r in ranks)
                {
                    Cards.Add(new Card(r, s));
                }
            }
        }

        // Randomly orders (shuffles) the list of cards
        public void Shuffle()
        {
            Random rand = new Random();
            Cards = Cards.OrderBy(c => rand.Next()).ToList();// raspologaem v randomnom porjadke
        }
        //Takes the last card from the list. Removes it from the list. Returns it.
        public Card GetCard()
        {
            Card card = Cards.Last(); //Card card = Cards[Cards.Count - 1];
            Cards.Remove(card);
            return card;
        }
    }
}
