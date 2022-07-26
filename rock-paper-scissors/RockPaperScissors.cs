namespace rock_paper_scissors
{
    public class RockPaperScissors : Game
    {
        String name;
        int userScore;
        int computerScore;
        int roundsPlayed;

        public RockPaperScissors()
        {
            this.name = this.askForName();
        }

        protected override String askForName()
        {
            bool nameEntered = false;
            string? name = "";

            while (!nameEntered)
            {
                Console.WriteLine("Please enter your name to start the game:");
                name = Console.ReadLine();

                if (name is null)
                {
                    Console.WriteLine("You did not enter your name! Please enter it:");
                    continue;
                }

                nameEntered = true;
            }

            return name;
        }

        private AcceptedGameInput getUserChoice()
        {
            Console.WriteLine("Please input your choice!");
            string? choice = Console.ReadLine();

            if (choice is null)
            {
                Console.WriteLine("You did not input anything.");
                return this.getUserChoice();
            }

            choice = choice.ToLower();

            switch (choice)
            {
                case "rock":
                    return AcceptedGameInput.Rock;
                case "paper":
                    return AcceptedGameInput.Paper;
                case "scissors":
                    return AcceptedGameInput.Scissors;
                default:
                    Console.WriteLine("You did not input a viable choice.");
                    Console.WriteLine("Please input either Rock, Paper or Scissors in any character case.");
                    return this.getUserChoice();
            }
        }

        private AcceptedGameInput getComputerChoice()
        {
            Random rnd = new Random();
            int choice = rnd.Next(0, 3);

            switch (choice)
            {
                case 0:
                    return AcceptedGameInput.Rock;
                case 1:
                    return AcceptedGameInput.Paper;
                case 2:
                    return AcceptedGameInput.Scissors;
                default:
                    return AcceptedGameInput.Rock;
            }
        }

        protected override void gameLoop()
        {
            if (this.roundsPlayed == 3)
            {
                this.gameOver();
                return;
            }

            AcceptedGameInput computerChoice = this.getComputerChoice();
            AcceptedGameInput userChoice = this.getUserChoice();

            switch ((int)userChoice - (int)computerChoice)
            {
                case 2:
                    this.computerScore++;
                    Console.WriteLine($"The computer won this round {this.name}, try harder!");
                    break;
                case 1:
                    this.userScore++;
                    Console.WriteLine($"You won this round {this.name}, good one!");
                    break;
                case 0:
                    this.userScore++;
                    this.computerScore++;
                    Console.WriteLine($"It's a draw!");
                    break;
                case -1:
                    this.computerScore++;
                    Console.WriteLine($"The computer won this round {this.name}, try harder!");
                    break;
                case -2:
                    this.userScore++;
                    Console.WriteLine($"You won this round {this.name}, good one!");
                    break;
            }

            this.roundsPlayed++;
            this.gameLoop();
        }

        protected override void gameOver()
        {
            if (userScore > computerScore)
            {
                Console.WriteLine($"You won {this.name}!");
            }

            if (userScore == computerScore)
            {
                Console.WriteLine($"It's a draw {this.name}!");
            }

            if (userScore < computerScore)
            {
                Console.WriteLine($"The computer has won {this.name}");
            }

            Console.WriteLine("Wanna play again?");
            Console.WriteLine("If so, input 1, if not, input 0");

            string? startAgain = Console.ReadLine();

            if (startAgain is null)
            {
                return;
            }

            if (startAgain == "1")
            {
                this.startGame();
            }

            return;
        }

        public override void startGame()
        {
            this.computerScore = 0;
            this.userScore = 0;
            this.roundsPlayed = 0;
            this.gameLoop();
        }
    }
}