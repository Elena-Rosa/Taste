using Microsoft.AspNetCore.Mvc;
using Taste.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Taste.Controllers
{
  public class HomeController : Controller
  {
    private readonly TasteContext _db;

    public HomeController(TasteContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
  public ActionResult Index()
  {
    Flavor[] flavors = _db.Flavors.ToArray();
    Treat[] treats = _db.Treats.ToArray();
    Dictionary<string, object[]> model = new Dictionary<string, object[]>();
    model.Add("flavors", flavors);
    model.Add("treats", treats);
    return View(model);
  }


  }
}