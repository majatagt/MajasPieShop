namespace MajasPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies(); //get method to get all pies
        IEnumerable<Pie> PiesOfTheWeek { get; } // get method for pies of the week 
        Pie? GetPieById(int pieId);
        IEnumerable<Pie> SearchPies(string searchQuery);
    }
}
