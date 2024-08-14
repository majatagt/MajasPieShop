namespace MajasPieShop.Models
{
    public class CategoryRepository: ICategoryRepository    
    {
        private readonly MajasPieShopDbContext _majasPieShopDbContext;

        public CategoryRepository(MajasPieShopDbContext majasPieShopDbContext)
        {
            _majasPieShopDbContext = majasPieShopDbContext;
        }
        public IEnumerable<Category> AllCategories =>
            _majasPieShopDbContext.Categories.OrderBy(p => p.CategoryName); 
    }
}
