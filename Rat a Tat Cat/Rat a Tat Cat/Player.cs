using System;
using System.Collections.Generic;
using System.Text;

namespace Rat_a_Tat_Cat
{
    class Player
    {
        public string Name { get; set; }

        public Dictionary<int, ICard> hand = new Dictionary<int, ICard>();

        public void Turn()
        {

        }
    }
}
