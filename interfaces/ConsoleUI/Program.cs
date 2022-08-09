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

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> data = new List<IProductModel>();

            data.Add(new PhysicalProductModel { Title = "Car tire" });
            data.Add(new PhysicalProductModel { Title = "Water bottle" });
            data.Add(new PhysicalProductModel { Title = "Cup holder" });
            data.Add(new PhysicalProductModel { Title = "Cellphone holder" });
            data.Add(new PhysicalProductModel { Title = "Headphones" });
            data.Add(new DigitalProductModel { Title = "Lesson Code" });
            data.Add(new DigitalProductModel { Title = "E-book" });
            data.Add(new DigitalProductModel { Title = "Video Game" });
            data.Add(new DigitalProductModel { Title = "Movie" });
            data.Add(new DigitalProductModel { Title = "Subscription" });

            return data;
        }

        static void Main(string[] args)
        {
            CustomerModel customer = GetCustomer();
            List<IProductModel> productList = AddSampleData();

            foreach (var product in productList)
            {
                product.ShipItem(customer);

                if (product is IDigitalProductModel digitalProduct)
                {
                    Console.WriteLine($"Downloads left: {digitalProduct.TotalDownloadsLeft}");
                }
            }

            Console.ReadLine();
        }
    }
}