using System;

namespace guessing_game
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string playerName = InputReceiver.GetStringInput();

            GuessingGame guessingGame = new GuessingGame(playerName);

            guessingGame.gameStart();
        }
    }
}