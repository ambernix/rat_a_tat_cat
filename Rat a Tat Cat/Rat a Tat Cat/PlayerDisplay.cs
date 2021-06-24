using System;
using System.Collections.Generic;
using System.Text;

namespace Rat_a_Tat_Cat
{
    // This displays for the current player what they are able to "see". The deck, discard pile,
    // and current hand is depicted. The only card value they can see is the last 
    // card discarded. Power cards cannot be taken from the discard pile, so if the card is a
    // power card, an X is shown. The display also tells the user which options they can pick for
    // this turn. The options are different depending on whether the discarded card is a point 
    // or a power card.
    class PlayerDisplay
    {
        public PlayerDisplay(ICard lastDiscardedCard, Player currentPlayer)
        {
            string discardDisplay;
            if (lastDiscardedCard.Name != "Point")
            {
                discardDisplay = "X";
            }
            else
            {
                discardDisplay = lastDiscardedCard.Value.ToString();
            }
            IInteract interacter = new ConsoleIO();

            interacter.Write($"Your turn, {currentPlayer.Name}: \n\n");

            interacter.Write(" ------    -----  ");
            interacter.Write("|      |  |     | ");
            interacter.Write($"| Deck |  |  {discardDisplay}  | ");
            interacter.Write("|      |  |     | ");
            interacter.Write(" ------    -----  \n\n");

            interacter.Write(" -----    -----    -----    ----- ");
            interacter.Write("|Card |  |Card |  |Card |  |Card |");
            interacter.Write("|  1  |  |  2  |  |  3  |  |  4  |");
            interacter.Write("|     |  |     |  |     |  |     |");
            interacter.Write(" -----    -----    -----    -----  \n\n");

            if (discardDisplay == "X")
            {
                interacter.Write("1) Pick up card from deck.");
                interacter.Write("Press 1 and then press enter:");
            }
            else
            {
                interacter.Write("1) Pick up card from deck.");
                interacter.Write("2) Pick up card from discard pile.");
                interacter.Write("Press 1 or 2 and then press enter:");
            }
            

        }

    }
}
