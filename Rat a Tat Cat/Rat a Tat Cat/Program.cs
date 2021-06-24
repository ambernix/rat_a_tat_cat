using System;

namespace Rat_a_Tat_Cat
{
    class Program
    {
        // Here in the program, we instantiate a new object of the Game class and give the names
        // of the players for this game. A deck and an empty discard pile is created when this
        // happens. Then the setup method is run, which shuffles the deck. Then all the
        // functionality is turned over to the Play method where all the game play occurs.
        static void Main(string[] args)
        {
            
            Game game = new Game("Amber", "Kayla");
            ICard testCard = new PeekPowerCard();
            PlayerDisplay testDisplay = new PlayerDisplay(testCard, game.Player2);
            //game.Setup();
            //game.Play();
        }
    }
}
