using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
  
    class Bet
    {
        public bool NumbersBet(int landed)
        {
            Console.WriteLine("What Number do you want to bet on?");
            int playerBet = int.Parse(Console.ReadLine());
            Console.WriteLine($"Player bet on: {playerBet}");
            Console.WriteLine($"Ball Landed on {landed}");

            bool winner = false;

            if (landed == playerBet)
            {
                return winner = true;
            }
            else return winner;
        }

        public bool EvenOdd(int landed)
        {
            Console.WriteLine("Odd or Even");
            string result = Console.ReadLine().ToLower();

            bool winner = false;
            //TODO: Add where ball landed

            if (result == "even" && landed %2 ==0)
            {
                return winner = true;
            }
            if (result == "odd" && landed % 2 != 0)
            {
                return winner = true;
            }
            else return winner;
        }
        public bool ColorsBet(string color)
        {
            Console.WriteLine("Red or Black");
            string result = Console.ReadLine().ToLower();
            Console.WriteLine($"Color is: {color}");
            bool winner = false;

            if (color == result)
            {
                return winner = true;
            }
            else return winner;
        }

        public bool LowHigh(int landed)
        {
            Console.WriteLine("Low (1 - 18) or high (19 - 38)");
            string result = Console.ReadLine().ToLower();
            Console.WriteLine($"Ball landed on: {landed} ");
            bool winner = false;

            if (result == "low" && landed <= 18)
            {
                Console.Write(" (1 - 18)");
                return winner = true;
            }
            if (result == "high" && landed >= 18)
            {
                Console.Write(" (19 - 38)");
                return winner = true;
            }
            else return winner;
        }

        public bool Dozens(int landed)
        {
            Console.WriteLine("Which Row?\n1st(1-12) 2nd(13-24) 3rd(25-36)");
            string result = Console.ReadLine().ToLower();

            Console.WriteLine($"Ball landed on: {landed} ");

            bool winner = false;

            if (result == "1st" && landed <= 12 && landed > 0)
            {
                return winner = true;
            }
            if (result == "2nd" && landed <= 24)
            {
                return winner = true;
            }
            if (result == "3rd" && landed >= 25 && landed <= 36)
            {
                return winner = true;
            }
            else return winner;
        }

        public bool Columns(int landed)
        {
            int[,] columns =
            {
                { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34}, //1st Column
                { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35},//2nd Column
                {3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36}//3rd Column

            };

            Console.WriteLine("Which Column would you like to bet?");
            Console.WriteLine("1. (1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34)");
            Console.WriteLine("2. (2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35)");
            Console.WriteLine("3. (3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36)");
            int userAnswer = int.Parse(Console.ReadLine()) -1;

            Console.WriteLine($"Ball landed on: {landed} ");

            bool winner = false;




            if (result == "1st" && landed <= 12 && landed > 0)
            {
                return winner = true;
            }
            if (result == "2nd" && landed <= 24)
            {
                return winner = true;
            }
            if (result == "3rd" && landed >= 25 && landed <= 36)
            {
                return winner = true;
            }
            else return winner;
        }
    }
}
