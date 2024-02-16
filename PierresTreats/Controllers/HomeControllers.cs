using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;


namespace PierresTreats.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public HomeController(PierresTreatsContext db, UserManager<ApplicationUser> userManager)
    {
      _db = db;
      _userManager = userManager;
    }

    [HttpGet("/")]
    public async Task<ActionResult> Index()
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);

      if (currentUser != null)
      {
        Treat[] treats = _db.Treats
            .Where(entry => entry.User.Id == currentUser.Id)
            .ToArray();
        model.Add("treats", treats);

        Flavor[] flavors = _db.Flavors
            .Where(entry => entry.User.Id == currentUser.Id)
            .ToArray();
        model.Add("flavors", flavors);
      }

      return View(model);
    }
  }
}