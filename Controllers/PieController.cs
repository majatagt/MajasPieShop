using MajasPieShop.Models;
using MajasPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
 

namespace MajasPieShop.Properties.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pierepository;
        private readonly ICategoryRepository _categoryRepository;

        // Using constructor injection
        public PieController(IPieRepository pierepository, ICategoryRepository categoryRepository)
        {
            _pierepository = pierepository;
            _categoryRepository = categoryRepository;
        }
        // figure out how to make it searchable
        public IActionResult List()
        {
            //Viewbag current.category = "Cheese cakes";
            // return View (_pieRepository.AllPies);
            PieListViewModel piesListViewModel = new PieListViewModel(_pierepository.AllPies(),"");
            return View(piesListViewModel);
        }

        //gets the detail view of each pie by taking the pieID
        public IActionResult Details(int id) 
        {
        var pie = _pierepository.GetPieById(id);
            if (pie == null)
                return NotFound();
            return View(pie);
        }
    }
}
