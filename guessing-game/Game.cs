namespace guessing_game
{
    public abstract class Game
    {
        private string playerName = "Player";

        protected abstract void gameIntroduction();
        public abstract void gameStart();
        protected abstract void gameLoop();
        protected abstract void gameOver();
    }
}