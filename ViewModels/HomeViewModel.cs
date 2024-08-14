using System.Collections.Generic;
using MajasPieShop.Models;

namespace MajasPieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> piesoftheweek { get; }

        public HomeViewModel(IEnumerable<Pie> piesOfTheWeek)
        {
            piesoftheweek = piesOfTheWeek;
        }
    }
}