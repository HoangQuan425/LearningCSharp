using Microsoft.AspNetCore.Mvc;

namespace MyProject.Web.Areas.Admin.Controllers
{
  public class AuthenticationController : Controller
  {
    public IActionResult Login()
    {
      return View();
    }
  }
}
