using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Rat_a_Tat_Cat
{
    class Deck
    {
        public Stack<ICard> CurrentDeck { get; set; } = new Stack<ICard>();
        public Deck()
        {
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PointCard card = new PointCard(i);
                    CurrentDeck.Push(card);
                }
            }

            for (int i = 0; i < 9; i++)
            {
                PointCard card = new PointCard(9);
                CurrentDeck.Push(card);
            }

            for (int i = 0; i < 3; i++)
            {
                PeekPowerCard peekCard = new PeekPowerCard();
                SwapPowerCard swapCard = new SwapPowerCard();
                DrawTwoPowerCard drawTwoCard = new DrawTwoPowerCard();
                CurrentDeck.Push(peekCard);
                CurrentDeck.Push(swapCard);
                CurrentDeck.Push(drawTwoCard);
            }
        }
        public void Shuffle()
        {
            ICard[] cardArray = CurrentDeck.ToArray();
            CurrentDeck.Clear();
            Random rnd = new Random();
            foreach (ICard card in cardArray.OrderBy(x => rnd.Next()))
            {
                CurrentDeck.Push(card);
            }
        }
        public ICard Deal()
        {
            ICard dealtCard = CurrentDeck.Pop();
            return dealtCard;
        }
        
    }
}
