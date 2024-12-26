using Microsoft.AspNetCore.Mvc;

namespace AutoCubes.UI.Controllers
{
  public class AdminController : Controller
  {
    public IActionResult Index()=> View();
    public IActionResult Supplier() => View();
    public IActionResult Dealer() => View();
    public IActionResult Branch() => View();

  }
}
