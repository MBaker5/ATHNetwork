using Microsoft.AspNetCore.Mvc;

namespace ATHNetwork.Controllers
{
    public class Shops : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
