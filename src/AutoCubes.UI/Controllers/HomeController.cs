using Microsoft.AspNetCore.Mvc;

namespace AutoCubes.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()=> View();
    }
}
