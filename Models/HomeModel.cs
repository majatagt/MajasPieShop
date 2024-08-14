using System.Collections.Generic;
using MajasPieShop.Models;

namespace MajasPieShop.ViewModels
{
    public class HomeModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public HomeModel(IEnumerable<Pie> piesOfTheWeek)
        {
            PiesOfTheWeek = piesOfTheWeek;
        }
    }
}