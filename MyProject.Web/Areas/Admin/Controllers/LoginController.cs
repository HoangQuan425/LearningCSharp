using Microsoft.AspNetCore.Mvc;

namespace MyProject.Web.Areas.Admin.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
