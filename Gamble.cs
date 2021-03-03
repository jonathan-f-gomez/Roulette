using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{


    class Gamble
    {
        public int YourBet()
        {
            Console.WriteLine("Whats your bet?");
            Console.WriteLine("1. Numbers: the number of the bin");
            Console.WriteLine("2. Evens/Odds: even or odd numbers");
            Console.WriteLine("3. Reds/Blacks: red or black colored numbers");
            Console.WriteLine("4. Lows/Highs: low (1 – 18) or high (19 – 38) numbers.");
            Console.WriteLine("5. Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36");

            int yourChoice = int.Parse(Console.ReadLine());

            return yourChoice;
        }
    }
}
