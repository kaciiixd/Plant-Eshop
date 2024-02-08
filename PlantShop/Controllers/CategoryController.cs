using Microsoft.AspNetCore.Mvc;
using PlantShop.Data;
using PlantShop.Models;

namespace PlantShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext db;

        public CategoryController(ApplicationDbContext db)
        {
            this.db = db;
        }


        public IActionResult Index()
        {
            List<Category> objCategoryList = db.Categories.ToList();

            return View(objCategoryList);
        }
    }
}
