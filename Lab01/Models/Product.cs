
namespace Lab01.Models
{
    public class Product
    {
        public int ProducID { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Total => UnitPrice * Quantity;
    }
}
