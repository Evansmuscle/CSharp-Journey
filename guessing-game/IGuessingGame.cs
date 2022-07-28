namespace guessing_game
{
    public interface IGuessingGame
    {
        protected int getRandomTarget();
        protected void compare(int guess);
    }
}