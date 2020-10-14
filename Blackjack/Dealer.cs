using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Dealer : BasePlayer
    {
        //If dealer has at least 17 points, return false, otherwise- true
        public override bool WantCard()
        {
           // CountPoints(), 17
            return CountPoints() < 17;// budet otlichatjsa ot ost igrokov
        }
    
    
    }
}
