using Microsoft.AspNetCore.Mvc;

namespace Dealership.Controllers
{
  public class ItemsController: Controller
  {
    [HttpGet("/cars")]
      public ActionResult Index()
      {
        return View();
      }
  }
}