using System;
using System.Collections.Generic;
using System.Text;

namespace Rat_a_Tat_Cat
{
    // This is the base interface for all the cards in the game. Each card must have both a name 
    // and a value and implement a method that flips over the card. 
    interface ICard
    {
        public string Name { get; }
        public int Value { get; }
        public string Flip();

        //Maybe move to game play class
        public void Deal();
    }
}
