using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Kaan",
                LastName = "Korkmaz",
                City = "Test",
                EmailAddress = "test@test.com",
                PhoneNumber = "124135135",
                StreetAddress = "Test"
            };
        }

        private static List<PhysicalProductModel> AddSampleData()
        {
            List<PhysicalProductModel> data = new List<PhysicalProductModel>();

            data.Add(new PhysicalProductModel { Title = "Car tire" });
            data.Add(new PhysicalProductModel { Title = "Water bottle" });
            data.Add(new PhysicalProductModel { Title = "Cup holder" });
            data.Add(new PhysicalProductModel { Title = "Cellphone holder" });
            data.Add(new PhysicalProductModel { Title = "Headphones" });

            return data;
        }

        static void Main(string[] args)
        {
            CustomerModel customer = GetCustomer();
            List<PhysicalProductModel> productList = AddSampleData();

            foreach (var product in productList)
            {
                product.ShipItem(customer);
            }

            Console.ReadLine();
        }
    }
}