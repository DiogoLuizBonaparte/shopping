using Microsoft.EntityFrameworkCore;

namespace Shopping.ProductAPI.Model.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext()   {}
        public SQLContext(DbContextOptions<SQLContext>options) :base(options)   {}
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Camisa Marte",                
                Price = new decimal(79.9),
                Description = "Camisa Marte Preta",
                CategoryName = "Camisa algodão",
                ImageURL = "https://github.com/DiogoLuizBonaparte/shopping/blob/master/ShoppingImages/11_mars.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Camisa Dragon Ball Z",
                Price = new decimal(99.9),
                Description = "Camisa Dragonball Z, Goku",
                CategoryName = "Camisa",
                ImageURL = "https://github.com/DiogoLuizBonaparte/shopping/blob/master/ShoppingImages/13_dragon_ball.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camisa No Internet",
                Price = new decimal(19),
                Description = "Camisa No Internet preta",
                CategoryName = "Camisa",
                ImageURL = "https://github.com/DiogoLuizBonaparte/shopping/blob/master/ShoppingImages/2_no_internet.jpg"
            });
        }
    }
}
