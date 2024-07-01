using Microsoft.AspNetCore.Mvc;

namespace KursProjectWebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
