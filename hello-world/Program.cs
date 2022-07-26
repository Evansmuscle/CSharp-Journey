namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            string? userName;
            Console.WriteLine("Please enter your name:");
            userName = Console.ReadLine();

            if (userName is null || userName is "")
            {
                Console.WriteLine("You must enter a valid value!");
                return;
            }

            Console.WriteLine(String.Format("Hello, {0}!", userName));
        }
    }
}
