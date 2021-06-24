using System;
using System.Collections.Generic;
using System.Text;

namespace Rat_a_Tat_Cat
{
    // This is the Peek version of the power card. It will allow the player to look at 
    // one of the cards in their hand.
    class PeekPowerCard : PowerCard
    {
        public PeekPowerCard()
        {
            Name = "Peek";
        }
        public string Peek()
        {
            return Flip();
        }
    }
}
