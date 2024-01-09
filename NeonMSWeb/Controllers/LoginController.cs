using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Security.Cryptography;
using NeonMSWeb.Data;

namespace NeonMSWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDBContext db1;
        public LoginController(ApplicationDBContext db)
        {
            db1 = db;
        }
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public IActionResult Login(string role, string username, string password)
        {

            string hashed_value = db1.Users.FirstOrDefault(x => x.UserName == username).Password;
            if (VerifyPassword(password, hashed_value))
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

        static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert the password string to bytes
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                // Compute the hash
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                // Convert the hash to a base64-encoded string
                string hashedPassword = Convert.ToBase64String(hashBytes);

                return hashedPassword;
            }
        }

        static bool VerifyPassword(string inputPassword, string hashedPassword)
        {
            // Hash the input password and compare with the stored hash
            string hashedInputPassword = HashPassword(inputPassword);

            return string.Equals(hashedInputPassword, hashedPassword);
        }

    }
}

