using CodingWiki.DataAccess;
using CodingWiki.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingWikiWebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CategoryController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            List<Category> categories = _applicationDbContext.Categories.ToList();
            return View(categories);
        }

        public IActionResult Upsert(int? id)
        {
            Category obj = new();
            if (id == null || id == 0)
            {
                //create
                return View(obj);
            }
            //edit
            obj = _applicationDbContext.Categories.FirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
    }
}