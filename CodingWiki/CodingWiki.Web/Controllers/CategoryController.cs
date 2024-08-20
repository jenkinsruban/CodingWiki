using CodingWiki.DataAccess;
using CodingWiki.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingWiki.Web.Controllers
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
    }
}
