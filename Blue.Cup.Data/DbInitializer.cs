using Blue.Cup.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Blue.Cup.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ModelBuilder builder)
        {
            builder.Entity<Item>().HasData(
                new Item("Shirt", "Ohio State shirt", "Nike", 29.99m)
                {
                    ID = 1
                },
                new Item("Shorts", "Ohio State shorts", "Nike", 44.99m)
                {
                    ID = 2
                }
            );
        }
    }
}