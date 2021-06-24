using System;
using System.Collections.Generic;
using System.Text;

namespace Rat_a_Tat_Cat
{
    class Game
    {
        public Game(string player1, string player2)
        {
            Player1.Name = player1;
            Player2.Name = player2;
        }
        public Player Player1 { get; } = new Player();
        public Player Player2 { get; } = new Player();
        public Deck GameDeck { get; set; } = new Deck();
        public Discard GameDiscardPile { get; set; } = new Discard();


        public void Setup()
        {
            GameDeck.Shuffle();
            for (int i = 1; i <= 4; i++)
            {
                Player1.hand.Add(i, GameDeck.CurrentDeck.Pop());
                Player2.hand.Add(i, GameDeck.CurrentDeck.Pop());
            }
        }

        public void Play()
        {
            int choice = 0;
            int playerTurn = 1;
            while(choice != 4)
            {
                choice++;
                if (playerTurn % 2 == 1)
                {
                    Player1.Turn();
                }
                else
                {
                    Player2.Turn();
                }
                playerTurn++;
            }
        }
        
    }
}
