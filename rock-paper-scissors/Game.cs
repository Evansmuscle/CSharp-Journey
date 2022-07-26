namespace rock_paper_scissors
{
    public abstract class Game
    {
        protected abstract String askForName();
        protected abstract void gameLoop();
        protected abstract void gameOver();
        public abstract void startGame();
    }
}