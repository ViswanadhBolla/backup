using Microsoft.AspNetCore.Mvc;

namespace MVCEFeg.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult login()
        {
            return View();
        }
    }
}
