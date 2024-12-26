using Microsoft.AspNetCore.Mvc;

namespace AutoCubes.UI.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Register() => View();
        public IActionResult Login() => View();
        public IActionResult ForgotPassword() => View();
    }
}
