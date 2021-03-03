using System;

namespace Roulette
{
    class Program
    {
        public static void LetsPlay()
        {
            Wheel wheel = new Wheel();
            Gamble gamble = new Gamble();
            Bet bet = new Bet();

            int[] ball = wheel.Spin();
            int whatColor = ball[0];
            int land = wheel.Lands(ball);
            string color = wheel.RedOrBlack(whatColor).ToLower();
            
            int typeOfBet = gamble.YourBet();

            bool youWon;

            switch (typeOfBet )
            {
                case 1:
                    youWon = bet.NumbersBet(land);
                    if (youWon == true)
                    {
                        Console.WriteLine("WINNER");
                    }
                    else Console.WriteLine("YAH FUCKIN LOST");
                    break;
                case 2:
                    youWon = bet.EvenOdd(land);
                    if (youWon == true)
                    {
                        Console.WriteLine("Winner");
                    }
                    else Console.WriteLine("Broke Bitch");
                    break;
                case 3:
                    youWon = bet.ColorsBet(color);
                    if (youWon == true) Console.WriteLine("Dan go buy another boat!");
                    else Console.WriteLine("Dan please... stop gambling");
                    break;

                case 4:
                    youWon = bet.LowHigh(land);
                    if (youWon == true)
                    {
                        Console.WriteLine("Dan lives in Vegas");
                    }
                    else Console.WriteLine("Dan... please leave");
                    break;
                case 5:
                    youWon = bet.Dozens(land);
                    if (youWon == true)
                    {
                        Console.WriteLine("DAN GO BUY SOME PEPSI!!");
                    }
                    else Console.WriteLine("Dan spilled his diet Pepsi");
                    break;
            }
        }
        static void Main(string[] args)
        { 
            LetsPlay();
        }
    }
}
