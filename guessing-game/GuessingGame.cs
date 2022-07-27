namespace guessing_game
{
    public class GuessingGame : Game
    {
        private string playerName;
        private int target;
        private int guessesRemaining;
        private bool userWon;
        Random rnd;

        public GuessingGame(string name)
        {
            this.playerName = name;
            this.guessesRemaining = 10;
            this.rnd = new Random();
        }

        public string PlayerName
        {
            get { return this.playerName; }
            set { this.playerName = value; }
        }

        protected override void gameIntroduction()
        {
            Console.WriteLine($"Welcome, {this.playerName}! Make a guess between 0 and 100 to start the game!");

            this.gameLoop();
        }

        public override void gameStart()
        {
            this.target = this.getRandomTarget();
            this.userWon = false;
            this.guessesRemaining = 10;
            this.gameIntroduction();
        }

        protected override void gameLoop()
        {
            Console.WriteLine($"Guesses remaining: {this.guessesRemaining}");
            Console.WriteLine("Please make your guess:");
            int guess = InputReceiver.GetIntegerInput();

            this.compare(guess);

            if (this.userWon || this.guessesRemaining == 0)
            {
                this.gameOver();
                return;
            }

            this.gameLoop();
        }

        protected void playAgain()
        {
            Console.WriteLine("Wanna play again?");
            Console.WriteLine("If so, input 1, if not, input 0:");

            bool playAgain = InputReceiver.GetBooleanInput();

            if (playAgain)
            {
                this.gameStart();
            }
        }

        protected override void gameOver()
        {
            if (this.userWon)
            {
                Console.WriteLine($"You won {this.playerName}!");
                this.playAgain();
                return;
            }

            Console.WriteLine($"You lost {this.playerName}..");
            this.playAgain();
        }

        protected int getRandomTarget()
        {
            return (int)rnd.NextInt64(0, 101);
        }

        protected void compare(int guess)
        {
            if (guess > this.target)
            {
                Console.WriteLine("Guess lower!");
                this.guessesRemaining--;
                return;
            }

            if (guess < this.target)
            {
                Console.WriteLine("Guess higher!");
                this.guessesRemaining--;
                return;
            }

            this.userWon = true;
        }
    }
}