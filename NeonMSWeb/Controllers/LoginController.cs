using Microsoft.AspNetCore.Mvc;

namespace NeonMSWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public IActionResult Login(string role, string username, string password)
        {
            // Your login logic goes here
            // Example: Check username and password, and redirect to appropriate action

            if (IsValidLogin(role, username, password))
            {

                // Redirect to a success page or another action
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Handle invalid login, maybe show an error message
                ViewBag.ErrorMessage = "Invalid login credentials";
                return View("Login");
            }
        }

        private bool IsValidLogin(string role, string username, string password)
        {
            if (role == "student" && username.ToLower() == "jawwad" && password == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Example: Additional action for the dashboard

    }
}

