using Microsoft.AspNetCore.Mvc;

namespace NeonMSWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
