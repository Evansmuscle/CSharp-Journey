using DemoLibrary;

namespace ConsoleUI
{
    public class ConsoleUI
    {
        static void Main(string[] args)
        {
            List<DataAccess> databases = new List<DataAccess>
            {
                new SqlDataAccess(),
                new SqliteDataAccess()
            };

            foreach (var db in databases)
            {
                db.LoadConnectionString("demo");
                db.LoadData("select * from table");
                db.SaveData("insert into table");
                Console.WriteLine();
            }
        }
    }
}