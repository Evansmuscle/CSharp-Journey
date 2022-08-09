namespace DemoLibrary
{
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Shipping {Title} to {customer.FullName} in {customer.City}");
                HasOrderBeenCompleted = true;
            }
        }
    }
}