using Microsoft.AspNetCore.Mvc;

namespace KursProjectWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
