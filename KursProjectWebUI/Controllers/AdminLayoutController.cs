using Microsoft.AspNetCore.Mvc;

namespace KursProjectWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
