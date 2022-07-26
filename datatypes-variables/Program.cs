namespace DatatypesVariables
{
    class Program
    {
        public static void Main(string[] args)
        {
            //     sbyte test = Convert.ToSByte(Math.Pow(2, 7) - 1.0);
            //     float parsedNum;

            //     float.TryParse("0.05", out parsedNum);

            //     Console.WriteLine(String.Format("Sbyte: {0}, Float: {1}", test, parsedNum));

            // int age = 31;
            // string name = "Alfonso";

            // Console.WriteLine("Hello, my name is {0}, my age is {1}", name, age);

            // // This seems cleaner
            // Console.WriteLine($"Hello, my name is {name}, and my age is {age}");

            // // Verbatim strings (raw strings)
            // Console.WriteLine(@"\n as you see there is no regex here, only raw strings \t");

            // string sentence = $"Name: {name}\nAge: {age}";
            // Console.WriteLine(sentence);

            // string? test;
            // test = Console.ReadLine();

            // if (String.IsNullOrWhiteSpace(test))
            // {
            //     throw new Exception("You wrote an empty or invalid value!");
            // }

            // Console.WriteLine(test);

            string myStr;

            Console.WriteLine("Please enter your word:");
            myStr = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(myStr))
            {
                //
            }
        }
    }
}
