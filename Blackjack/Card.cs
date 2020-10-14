using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Card
    {
        // kārts rangs-2,3,....10,J,Q,K,A
        string Rank;
            //kārts masts-H (hearts), D(diamonds),C(clubs),S (spades)
            string Suit;
        //Returns card's title (e.g. "Kārava 10'or "Diamond 10"or "D10")
        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }
        public string GetTitle()
            {
            string title = "";
            switch (Suit)
            {
                case "C":
                    title += "Kreica ";
                    break;
                case "S":
                    title += "Pīķa ";
                    break;
                case "D":
                    title += "Kārava ";
                    break;
                case "H":
                    title += "Erca ";
                    break;
            }
            title += Rank;
            return title;

            }
        
    //Returns cardš value (11 for Ace, 10 for face cards, numeric value for others)
    public int GetPoints()
    {
        switch (Rank)
        {
            case "A":
                return 11;
            case "K":
            case "Q":
            case "J":
                return 10;
            default:
                return int.Parse(Rank);
        }
    }

        }
        }
    

