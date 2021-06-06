using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Factory.Models;
using System.Linq;
using System.Dynamic;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;
    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Message = "Welcome to my demo!";
      dynamic mymodel = new ExpandoObject();
      mymodel.Engineers = _db.Engineers.ToList();
      mymodel.Machines = _db.Machines.ToList();
      return View(mymodel);
    }
  }
}
