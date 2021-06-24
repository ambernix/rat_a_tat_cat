using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Rat_a_Tat_Cat
{
    // This class implements the IInteract interface so that no console commands have to be
    // put into the other classes when the program is interacting with the user.
    public class ConsoleIO : IInteract
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }

        public string Read()
        {
            return Console.ReadLine();
        }

        public void PrintDictionary(Dictionary<int, IEnumerable> dictionary)
        {
            foreach (KeyValuePair<int,IEnumerable> item in dictionary)
            {
                Write($"{item.Key}) {item.Value}");
            }
        }
        
    }
}
