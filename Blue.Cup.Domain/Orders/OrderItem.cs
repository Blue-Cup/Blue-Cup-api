using Blue.Cup.Domain.Catalog;

namespace Blue.Cup.Domain.Orders
{
    public class OrderItem
    {
        public int ID { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal Price => Item.Price * Quantity;
    }
}