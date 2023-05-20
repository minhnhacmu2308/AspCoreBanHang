using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangCoreMcv.Models;

namespace WebBanHangCoreMcv.ViewComponents
{
    public class vcMenu : ViewComponent
    {
		public IViewComponentResult Invoke()
		{
			DBContext dBContext = new DBContext();
			var data = dBContext.Categories
								.ToList();
			return View(data);
		}
	}
}
