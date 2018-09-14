using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
