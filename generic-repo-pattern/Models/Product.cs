namespace generic_repo_pattern.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public List<Order> Orders { get; set; }
    }
}
