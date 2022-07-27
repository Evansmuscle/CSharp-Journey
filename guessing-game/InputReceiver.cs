namespace guessing_game
{
    public static class InputReceiver
    {
        public static int GetIntegerInput()
        {
            string? input = Console.ReadLine();

            if (input is null)
            {
                throw new Exception("Please enter a viable value!");
            }

            try
            {
                int integerInput = Convert.ToInt16(input);

                return integerInput;
            }
            catch (System.Exception)
            {
                throw new Exception("The input you've given is not a number!");
            }
        }

        public static string GetStringInput()
        {
            string? input = Console.ReadLine();

            if (input is null)
            {
                throw new Exception("Please enter a viable value!");
            }

            return input;
        }

        public static bool GetBooleanInput()
        {
            string? input = Console.ReadLine();

            if (input is null || (input is not "1" && input is not "0"))
            {
                throw new Exception("Please enter a viable value!");
            }

            if (input == "1")
            {
                return true;
            }

            return false;
        }
    }
}