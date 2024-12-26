using Microsoft.AspNetCore.Mvc;

namespace AutoCubes.UI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index() => View();
    }
}
