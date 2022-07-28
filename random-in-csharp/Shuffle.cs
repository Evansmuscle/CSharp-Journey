namespace random_in_csharp
{
    public class Shuffle
    {
        public static List<T> DurstenfeldShuffle<T>(List<T> notShuffledList, Random rnd)
        {
            bool notShuffled = true;
            List<T> shuffledList = new List<T> { };
            int roll = 0;

            while (notShuffled)
            {
                if (!notShuffledList.Any())
                {
                    notShuffled = false;
                    continue;
                }

                roll = rnd.Next(0, notShuffledList.Count);
                shuffledList.Insert(0, notShuffledList[roll]);

                if (roll == notShuffledList.Count - 1)
                {
                    notShuffledList.RemoveAt(roll);
                    continue;
                }

                notShuffledList[roll] = notShuffledList[notShuffledList.Count - 1];
                notShuffledList.RemoveAt(notShuffledList.Count - 1);
            }

            return shuffledList;
        }
    }
}