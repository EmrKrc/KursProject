using Microsoft.AspNetCore.Mvc;

namespace KursProjectWebUI.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
