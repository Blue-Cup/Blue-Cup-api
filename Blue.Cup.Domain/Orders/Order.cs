using System.Collections.Generic;
using System.Linq;

namespace Blue.Cup.Domain.Orders
{
    public class Order
    {
        public int ID { get; set; }
        public List<OrderItem> Items { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal TotalPrice => Items.Sum(i => i.Price);
    }
}