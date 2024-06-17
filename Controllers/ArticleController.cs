using Microsoft.AspNetCore.Mvc;

namespace Challenge_ASP.NET_MVC.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
