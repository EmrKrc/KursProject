﻿using Microsoft.AspNetCore.Mvc;

namespace KursProjectWebUI.ViewComponents
{
	public class _LayoutSidebarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}