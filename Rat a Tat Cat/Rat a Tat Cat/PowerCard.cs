using System;
using System.Collections.Generic;
using System.Text;

namespace Rat_a_Tat_Cat
{
    class PowerCard: ICard
    {
        // These are the power cards for the game. They will have varying names (Peek, Swap,
        // Draw Two) but their value will always be 0.
        public string Name { get; protected set; }

        public int Value { get; } = 0;
        public string Flip()
        {
            return $"Your card is {Name}.";
        }

        public void Deal()
        {
            
        }
    }
}
