using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Player : BasePlayer
    {
        // Ask if user want another card
        public override bool WantCard()// budet otlichatjsja
        {
            //Console.WriteLine()- jauta vai velas karti
            //Console.ReadLine()- nolasa atbildi
            //ja atbilde ir "Y" vai "Yes", tad atgriež true, citādi false
            Console.Write("Another card?");
            string answer = Console.ReadLine().ToLower();
            //return answer == "y"|| answer == "yes";
            if (answer == "y" || answer == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public override void GiveCard(Card card)
        {
            base.GiveCard(card);
            Console.WriteLine("Card received: {0}", card.GetTitle());
        }
    }
}

