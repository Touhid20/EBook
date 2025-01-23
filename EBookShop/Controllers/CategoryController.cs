using Microsoft.AspNetCore.Mvc;

namespace EBookShop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
