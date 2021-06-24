using System;
using System.Collections.Generic;
using System.Text;

namespace Rat_a_Tat_Cat
{
    // These are the point cards for the game. They will have varying values (0-9), but their 
    // name will always be "Point".
    class PointCard : ICard
    {
        public PointCard(int value)
        {
            Value = value;
        }
        public string Name { get; } = "Point";
        public int Value { get; }

        public string Flip()
        {
            return $"Your card is {Value}.";
        }

        public void Deal()
        {

        }
    }
}
