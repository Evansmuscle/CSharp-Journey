namespace random_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine(rnd.Next(5, 11));
            //     Console.WriteLine(rnd.NextDouble() * 10);
            // }
            // 

            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel("Yigit Kaan", "Korkmaz"),
                new PersonModel("Nihat", "Korkmaz"),
                new PersonModel("Selma", "Korkmaz")
            };

            foreach (var p in people)
            {
                Console.WriteLine(p.FullName);
            }

            var shuffledPeople = Shuffle.DurstenfeldShuffle<PersonModel>(people, rnd);

            foreach (var p in shuffledPeople)
            {
                Console.WriteLine(p.FullName);
            }

            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }

        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}