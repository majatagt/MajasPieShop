using Microsoft.EntityFrameworkCore;

namespace MajasPieShop.Models
{
    public class PieRepository: IPieRepository
    {
        private MajasPieShopDbContext _majasPieShopDbContext;

        public PieRepository(MajasPieShopDbContext majasPieShopDbContext) 
        { 
        _majasPieShopDbContext = majasPieShopDbContext;
        }

        public IEnumerable<Pie> AllPies()
        {
            return _majasPieShopDbContext.Pies.AsEnumerable<Pie>();
        }
        public IEnumerable<Pie> PiesOfTheWeek => throw new NotImplementedException();

        public Pie? GetPieById(int pieId)
        { 
        return _majasPieShopDbContext.Pies.FirstOrDefault(p =>p.PieId == pieId);
        }

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
