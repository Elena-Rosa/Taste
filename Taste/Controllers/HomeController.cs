using Microsoft.AspNetCore.Mvc;
using Taste.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Taste.Controllers
{
    public class HomeController : Controller
    {
      private readonly TasteContext _db;
      private readonly UserManager<ApplicationUser> _userManager;

      public HomeController(UserManager<ApplicationUser> userManager, TasteContext db)
      {
        _userManager = userManager;
        _db = db;
      }

      [HttpGet("/")]
      public async Task<ActionResult> Index()
      {
      
        string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
        if (currentUser != null)
        {
          Flavor[] flavors = _db.Flavors
                      .Where(entry => entry.User.Id == currentUser.Id)
                      .ToArray();
          model.Add("flavors", flavors);
        }
        return View(model);
      }
    }
}