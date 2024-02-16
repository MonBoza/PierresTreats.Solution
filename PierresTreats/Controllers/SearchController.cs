using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using PierresTreats.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class SearchController : Controller
{
  private readonly PierresTreatsContext _db;

  public SearchController(PierresTreatsContext db)
  {
    _db = db;
  }

  public ActionResult Index()
  {
    return View();
  }

  [HttpPost]
  public async Task<IActionResult> Results(string query, string searchType)
  {
    if (searchType == "Treat")
    {
      var treats = await SearchTreats(query);
      return View("Results", treats);
    }
    else if (searchType == "Flavors")
    {
      var flavors = await SearchFlavors(query);
      return View("Results", flavors);
    }

    return View("Results");
  }

  private async Task<List<Treat>> SearchTreats(string query)
  {
    IQueryable<Treat> result = _db.Set<Treat>();

    if (query != null)
    {
      return await result?.Where(treat => treat.TreatName.Contains(query)).ToListAsync();
    }
    else
    {
      return await result.ToListAsync();
    }
  }

  private async Task<List<Flavor>> SearchFlavors(string query)
  {
    IQueryable<Flavor> result = _db.Set<Flavor>();

    if (query != null)
    {
      return await result?.Where(flavor => flavor.FlavorName.Contains(query)).ToListAsync();
    }
    else
    {
      return await result.ToListAsync();
     }
  }
}