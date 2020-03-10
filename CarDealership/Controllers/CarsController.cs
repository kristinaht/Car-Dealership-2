using Microsoft.AspNetCore.Mvc;
using Dealership.Models;

namespace Dealership.Controllers
{
  public class ItemsController: Controller
  {
    [HttpGet("/cars")]
      public ActionResult Index()
      {
        return View();
      }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price, int miles, string message)
    {
      Car newCar = new Car(makeModel, price, miles, message);
      return RedirectToAction("Index");
    }
  }
}