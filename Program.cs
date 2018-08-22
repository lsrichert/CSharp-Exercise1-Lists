using System;
using System.Collections.Generic;

namespace exercise1List
{
    class Program
    {
        static void Main()
        {
            // 1. In the Main method, place the following code
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            // 2.  Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            
            // 3. Create another List that contains that last two planet of our solar system.
            List<string> planetListNew = new List<string>(){"Neptune", "Uranus"};

            // 4. User Insert() to add Earth, and Venus in the correct order.

            Console.WriteLine(planetList);
                    }
    }
}
