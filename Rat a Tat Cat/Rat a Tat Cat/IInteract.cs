using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Rat_a_Tat_Cat
{
    // This interface defines methods by which the program interacts with the user.
    // The type may depend on where the program is implemented.
    // Currently the program only works in the console.
    interface IInteract
    {
        public void Write(string message);
        public string Read();
        public void PrintDictionary(Dictionary<int, IEnumerable> dictionary);

    }
}
