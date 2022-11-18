
using ECommerceWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceWeb.Controllers
{
    public class AccountsController : Controller
    {
        private void MigrateShoppingCart(string username)
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            cart.MigrateCart(username);
            HttpContext.Session.SetString(ShoppingCart.CartSessionKey, username);  
        }

        public ActionResult LogOn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogOn(LogonModel model,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if()
            }
        }
    }
}
