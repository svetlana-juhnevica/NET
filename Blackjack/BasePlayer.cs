using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    abstract class BasePlayer
    {
        List<Card> Cards;

        public BasePlayer()
        {
            Cards = new List<Card>();
        }
        // Returns player’s cards in hand
        public List<Card> GetCards()
        {
            return Cards;
        }

        // Counts total points of player’s cards. If total points is over 21 and player has ‘Ace’, remove 10 points for each Ace until points <=21 or there are no more aces.
        public int CountPoints()
        {
           
            //int points = 0;
           // foreach(Card c in Cards)
           //c.GetPoints()
           //TODO: ji virs 21 un ir duzis, tad samazina while
            // return points:
             int points = 0;
            int aceCount = 0;
            foreach(Card c in Cards)
            {
                points += c.GetPoints();
                // ja kārts ir 11p vērta -> dūzis
                if(c.GetPoints() == 11)
                {
                    aceCount++;
                }
            }
            while(points > 21 && aceCount > 0)// ja punkti ir virs 21, tad par katru dūzi noņem 10p līdz punktu skaits ir zem 21
            {
                points -= 10;
                aceCount--;

            }
                return points;
        }

        // Returns true if player’s points is over 21, otherwise - false
        public bool IsGameCompleted()
        {

            //return, CountPoints(), 21
            /* if(CountPoints() > 21)
             {
                 return true;
             }
             else
             {
                 return false;
                 }
            */
            return CountPoints() > 21;

        }

        // Player receives a new card from the deck. Adds card to player’s hand.
        public virtual void GiveCard(Card card)
        {
            
            Cards.Add(card);
        }

        // Checks if player wants another card
         public abstract bool WantCard();
       
      
    }
    }

