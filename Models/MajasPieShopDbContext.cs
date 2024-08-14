using Microsoft.EntityFrameworkCore;
namespace MajasPieShop.Models
    
{
    public class MajasPieShopDbContext : DbContext
    {
        public MajasPieShopDbContext(DbContextOptions<MajasPieShopDbContext>
        options) : base(options) 
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }


    }
}
