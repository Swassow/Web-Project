using Microsoft.AspNetCore.Mvc;

namespace logindemo.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
